using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public enum ETipo { Semanal, Mensual, Anual }
    public enum EMedioDePago { Efectivo, Transferencia, Crédito, Débito, QR }

    public class Plan : IDatos
    {
        private int id;
        private Alumno alumno;
        private int cantidadDeMaterias;
        private List<Materia> materias;
        private ETipo tipo;
        private float precio;
        private DateTime fechaAdquirido;
        private DateTime fechaVencimiento;
        private EMedioDePago medioDePago;

        public Plan(Alumno alumno, int cantidadDeMaterias, List<Materia> materias, ETipo tipo, EMedioDePago medioDePago)
        {
            this.alumno = alumno;
            this.cantidadDeMaterias = cantidadDeMaterias;
            this.materias = new List<Materia>();
            this.materias = materias;
            this.tipo = tipo;
            this.medioDePago = medioDePago;
            this.precio = CalcularPrecio(tipo, cantidadDeMaterias);
            this.fechaVencimiento = CalcularFechaVencimiento(tipo);
            this.id = Institucion.ObtenerUltimoIdPlan() + 1;
            this.fechaAdquirido = DateTime.Today;

        }

        public Plan()
        {

        }

        public int Id { get => id; set => id = value; }
        public Alumno Alumno { get => alumno; set => alumno = value; }
        public int CantidadDeMaterias { get => cantidadDeMaterias; set => cantidadDeMaterias = value; }
        public List<Materia> Materias { get => materias; set => materias = value; }
        public ETipo Tipo { get => tipo; set => tipo = value; }
        public float Precio { get => precio; set => precio = value; }
        public DateTime FechaAdquirido { get => fechaAdquirido; set => fechaAdquirido = value; }
        public DateTime FechaVencimiento { get => fechaVencimiento; set => fechaVencimiento = value; }
        public EMedioDePago MedioDePago { get => medioDePago; set => medioDePago = value; }

        public static DateTime CalcularFechaVencimiento(ETipo tipo)
        {
            switch (tipo)
            {
                case ETipo.Semanal:
                    return DateTime.Today.AddDays(7);
                case ETipo.Mensual:
                    return DateTime.Today.AddMonths(1);
                case ETipo.Anual:
                    return DateTime.Today.AddYears(1);
                default:
                    return DateTime.Today;
            }
        }

        public static float CalcularPrecio(ETipo tipo, int cantidadDeMaterias)
        {
            float precio = 0;
            switch (tipo)
            {
                case ETipo.Semanal:
                    precio = cantidadDeMaterias * 500;
                    break;
                case ETipo.Mensual:
                    precio = cantidadDeMaterias * 500 * 4 * 0.9f;
                    break;
                case ETipo.Anual:
                    precio = cantidadDeMaterias * 500 * 52 * 0.7f;
                    break;
            }

            if (cantidadDeMaterias > 2)
            {
                precio *= 0.9f;
            }

            return precio;
        }

        public bool Validar()
        {
            if (this.alumno is not null && cantidadDeMaterias > 0 && materias is not null && precio > 0)
            {
                return true;
            }
            return false;
        }

        public string ObtenerInformacion()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Detalles del plan/venta:");
            sb.AppendLine();
            sb.AppendLine($"Fecha de pago: {this.fechaAdquirido.ToString("dd/MM/yyyy")}");
            sb.AppendLine($"Alumno: {this.alumno.Nombre} {this.alumno.Apellido}");
            sb.AppendLine($"Tipo: {this.tipo}");
            sb.AppendLine($"Fecha de vencimiento: {this.fechaVencimiento.ToString("dd/MM/yyyy")}");
            sb.AppendLine("");
            sb.AppendLine($"Cantidad de materias: {this.cantidadDeMaterias}");
            foreach (Materia materia in materias)
            {
                sb.AppendLine($"Asignatura: {materia.Nombre}, Modalidad: {materia.Modalidad}, Día: {materia.Dia}, Turno: {materia.Turno}");
            }
            sb.AppendLine("");
            sb.AppendLine($"Medio de pago: {this.medioDePago}");
            sb.AppendLine($"Precio final: ${this.precio}");

            return sb.ToString();
        }
    }
}
