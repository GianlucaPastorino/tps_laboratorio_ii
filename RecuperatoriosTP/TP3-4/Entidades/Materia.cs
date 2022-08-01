using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public enum EDia { Lunes, Martes, Miércoles, Jueves, Viernes }
    public enum EModalidad { Presencial, Virtual }
    public enum ETurno { Mañana, Tarde, Noche }

    public class Materia : IDatos
    {
        private int idMateria;
        private string nombre;
        private EModalidad modalidad;
        private int cupoMaximo;
        private List<Alumno> alumnos;
        private ETurno turno;
        private EDia dia;

        public int IdMateria { get => idMateria; set => idMateria = value; }
        public int CupoDisponible { get => cupoMaximo - alumnos.Count; }
        public string Nombre { get => nombre; set => nombre = value; }
        public EModalidad Modalidad { get => modalidad; set => modalidad = value; }
        public int CupoMaximo { get => cupoMaximo; set => cupoMaximo = value; }
        public List<Alumno> Alumnos { get => alumnos; set => alumnos = value; }
        public ETurno Turno { get => turno; set => turno = value; }
        public EDia Dia { get => dia; set => dia = value; }

        public Materia(string nombre, EModalidad modalidad, int cupoMaximo, EDia dia, ETurno turno)
        {
            this.nombre = nombre;
            this.modalidad = modalidad;
            this.cupoMaximo = cupoMaximo;
            this.dia = dia;
            this.turno = turno;
            alumnos = new List<Alumno>();
            idMateria = Institucion.ObtenerUltimoIdMateria() + 1;
        }

        public Materia()
        {

        }

        public bool ChequearMateriaExistente()
        {
            foreach (Materia materia in Institucion.Materias)
            {
                if (materia == this)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Validar()
        {
            bool retorno = false;

            if (string.IsNullOrWhiteSpace(this.nombre))
            {
                throw new CampoVacioException("El nombre no puede estar vacío.");
            }
            if (int.TryParse(nombre, out int result))
            {
                throw new DatoInvalidoException("El nombre no pueden ser sólo números.");
            }
            if (cupoMaximo == 0 || cupoMaximo > 200)
            {
                throw new DatoInvalidoException("El cupo máximo debe ser mayor a 0 y menor a 201.");
            }
            if (this.ChequearMateriaExistente())
            {
                throw new MateriaDuplicadaException("Ya existe una materia con las mismas características.");
            }

            retorno = true;
            return retorno;
        }

        public string ObtenerInformacion()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"- Asignatura: {this.nombre}");
            sb.AppendLine($"- Modalidad: { this.Modalidad}");
            sb.AppendLine($"- Día: {this.Dia}");
            sb.AppendLine($"- Turno: {this.Turno}");
            sb.AppendLine($"- Cupo máximo: {this.cupoMaximo}");
            sb.AppendLine($"- Cupo disponible: {this.CupoDisponible}");
            if (cupoMaximo != CupoDisponible)
            {
                sb.AppendLine($"- Alumnos inscriptos:");
                foreach (Alumno alumno in alumnos)
                {
                    sb.AppendLine($"{alumno.Nombre} {alumno.Apellido}");
                }
            }

            return sb.ToString();
        }

        public static bool operator ==(Materia m1, Materia m2)
        {
            if (m1.nombre == m2.nombre && m1.modalidad == m2.modalidad && m1.turno == m2.turno && m1.dia == m2.dia)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Materia m1, Materia m2)
        {
            return !(m1 == m2);
        }
    }
}
