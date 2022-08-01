using System;
using System.Collections.Generic;

namespace Entidades
{
    public static class Institucion
    {
        public static event DelegadoPago PagoRealizado;

        private static List<Alumno> alumnos;
        private static List<Materia> materias;
        private static List<Plan> ventas;

        public static List<Materia> Materias { get => materias; }
        public static List<Alumno> Alumnos { get => alumnos; }
        public static List<Plan> Ventas { get => ventas; }

        static Institucion()
        {
            alumnos = new List<Alumno>();
            materias = new List<Materia>();
            ventas = new List<Plan>();
        }

        public static void CargarDatos(DelegadoError Error)
        {
            try
            {
                alumnos = SqlAlumnos.LeerAlumnos();
                materias = Serializer<List<Materia>>.LeerJson("Materias.json");
                ventas = Serializer<List<Plan>>.LeerJson("Ventas.json");
            }
            catch (Exception ex)
            {
                Error.Invoke(ex.Message);
            }
        }

        public static void GuardarDatos(DelegadoError Error)
        {
            try
            {
                Serializer<List<Materia>>.EscribirJson(Materias, "Materias.json");
                Serializer<List<Plan>>.EscribirJson(ventas, "Ventas.json");
                SqlAlumnos.GuardarAlumnos(Alumnos);
            }
            catch (Exception ex)
            {
                Error.Invoke(ex.Message);
            }
        }

        #region Materias
        public static bool AgregarMateria(Materia materia, DelegadoError Error)
        {
            try
            {
                if (materia.Validar())
                {
                    materias.Add(materia);
                }
            }
            catch (Exception ex)
            {
                Error.Invoke(ex.Message);
                return false;
            }

            return true;
        }

        public static bool EliminarMateria(int idMateria)
        {
            foreach (Materia materia in materias)
            {
                if (idMateria == materia.IdMateria)
                {
                    if (materia.CupoMaximo == materia.CupoDisponible)
                    {
                        materias.Remove(materia);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        public static void ActualizarMaterias()
        {

            foreach (Materia materia in materias)
            {
                List<Alumno> auxAlumnos = new List<Alumno>();
                foreach (Alumno alumno in materia.Alumnos)
                {
                    foreach (Alumno alumno2 in alumnos)
                    {
                        if (alumno == alumno2)
                        {
                            alumno.Estado = alumno2.Estado;
                        }
                    }
                    if (alumno.Estado == EEstado.Inactivo || alumno.Estado == EEstado.Impago)
                    {
                        auxAlumnos.Add(alumno);
                    }
                }
                foreach (Alumno alumno in auxAlumnos)
                {
                    materia.Alumnos.Remove(alumno);
                }
            }
        }

        public static int ObtenerUltimoIdMateria()
        {
            int ultimoId = 0;
            for (int i = 0; i < materias.Count; i++)
            {
                if (materias[i].IdMateria > ultimoId)
                {
                    ultimoId = materias[i].IdMateria;
                }
            }

            return ultimoId;
        }

        public static Materia BuscarMateriaPorId(int id)
        {
            foreach (Materia materia in Materias)
            {
                if (materia.IdMateria == id)
                {
                    return materia;
                }
            }

            return null;
        }
        #endregion

        #region Alumnos
        public static bool AgregarAlumno(Alumno alumno, DelegadoError Error)
        {
            try
            {
                if (alumno.Validar())
                {
                    alumnos.Add(alumno);
                }
            }
            catch (Exception ex)
            {
                Error.Invoke(ex.Message);
                return false;
            }

            return true;
        }

        public static Alumno BuscarAlumnoPorDni(int dni)
        {
            foreach (Alumno alumno in alumnos)
            {
                if (alumno.Dni == dni)
                {
                    return alumno;
                }
            }

            return null;
        }

        public static void ActualizarEstadoAlumnos()
        {
            foreach (Alumno alumno in alumnos)
            {
                if (alumno.IdPlanAdquirido != int.MinValue)
                {
                    Plan auxPlan = BuscarPlanPorId(alumno.IdPlanAdquirido);
                    if (auxPlan is not null)
                    {
                        if (auxPlan.FechaVencimiento >= DateTime.Today)
                        {
                            alumno.Estado = EEstado.Activo;
                        }
                        else if (DateTime.Today > auxPlan.FechaVencimiento.AddDays(7))
                        {
                            alumno.Estado = EEstado.Inactivo;
                        }
                        else
                        {
                            alumno.Estado = EEstado.Impago;
                        }
                    }
                }
                else
                {
                    alumno.Estado = EEstado.Inactivo;
                }
            }
        }
        #endregion

        #region Ventas
        public static void AgregarVenta(Plan plan)
        {
            if (plan.Validar())
            {
                plan.Alumno.Estado = EEstado.Activo;
                plan.Alumno.IdPlanAdquirido = plan.Id;

                foreach (Materia materiaPlan in plan.Materias)
                {
                    foreach (Materia materia in materias)
                    {
                        if (materiaPlan == materia)
                        {
                            materia.Alumnos.Add(plan.Alumno);
                        }
                    }
                }

                ventas.Add(plan);

                if (PagoRealizado is not null)
                {
                    PagoRealizado.Invoke();
                }
            }
        }

        public static int ObtenerUltimoIdPlan()
        {
            int ultimoId = 0;
            for (int i = 0; i < ventas.Count; i++)
            {
                if (ventas[i].Id > ultimoId)
                {
                    ultimoId = ventas[i].Id;
                }
            }

            return ultimoId;
        }

        public static Plan BuscarPlanPorId(int id)
        {
            foreach (Plan plan in ventas)
            {
                if (plan.Id == id)
                {
                    return plan;
                }
            }

            return null;
        }
        #endregion
    }
}
