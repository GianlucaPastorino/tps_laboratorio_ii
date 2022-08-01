using System.Text;
using System.Text.RegularExpressions;

namespace Entidades
{
    public enum EEstado { Activo, Inactivo, Impago }
    public class Alumno : IDatos
    {
        private string nombre;
        private string apellido;
        private int dni;
        private string correoElectronico;
        private EEstado estado;
        private int idPlanAdquirido;

        public Alumno(string nombre, string apellido, int dni, string correoElectronico)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.correoElectronico = correoElectronico;
            estado = EEstado.Inactivo;
            idPlanAdquirido = int.MinValue;
        }

        public Alumno(string nombre, string apellido, int dni, string correoElectronico, EEstado estado, int idPlanAdquirido)
            : this(nombre, apellido, dni, correoElectronico)
        {
            this.estado = estado;
            this.idPlanAdquirido = idPlanAdquirido;
        }

        public Alumno()
        {

        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Dni { get => dni; set => dni = value; }
        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
        public int IdPlanAdquirido { get => idPlanAdquirido; set => idPlanAdquirido = value; }
        public EEstado Estado { get => estado; set => estado = value; }

        public bool BuscarAlumnoExistente()
        {
            foreach (Alumno alumno in Institucion.Alumnos)
            {
                if (alumno == this)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Validar()
        {
            bool retorno = false;

            if (string.IsNullOrWhiteSpace(this.nombre) || string.IsNullOrWhiteSpace(this.apellido) || string.IsNullOrWhiteSpace(this.correoElectronico))
            {
                throw new CampoVacioException("Los campos no pueden estar vacíos.");
            }
            if (!Regex.IsMatch(this.nombre, @"^[a-zA-Z]+$") || !Regex.IsMatch(this.apellido, @"^[a-zA-Z]+$"))
            {
                throw new DatoInvalidoException("El nombre/apellido no puede contener números.");
            }
            if (!correoElectronico.Contains('@'))
            {
                throw new DatoInvalidoException("Error de formato en correo electrónico.");
            }
            if (this.dni < 5000000 || this.dni > 60000000)
            {
                throw new DatoInvalidoException("El DNI debe ser mayor a 5.000.000 y menor a 60.000.000.");
            }
            if (BuscarAlumnoExistente())
            {
                throw new DatoInvalidoException("Ya existe un alumno con este D.N.I en el sistema.");
            }
            retorno = true;
            return retorno;
        }

        public string ObtenerInformacion()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"- Nombre: {this.nombre}");
            sb.AppendLine($"- Apellido: { this.apellido}");
            sb.AppendLine($"- DNI: {this.dni}");
            sb.AppendLine($"- Correo: {this.correoElectronico}");
            sb.AppendLine($"- Estado: {this.estado}");
            if (this.estado == EEstado.Activo)
            {
                Plan auxPlan = Institucion.BuscarPlanPorId(this.idPlanAdquirido);
                sb.AppendLine(auxPlan.ObtenerInformacion());
            }

            return sb.ToString();
        }

        public static bool operator ==(Alumno a1, Alumno a2)
        {
            if (a1.dni == a2.dni)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Alumno a1, Alumno a2)
        {
            return !(a1 == a2);
        }
    }
}
