using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Entidades
{
    public static class SqlAlumnos
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;

        static SqlAlumnos()
        {
            connectionString = @"Data Source=.;Initial Catalog=TP4_PASTORINO;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }

        public static void GuardarAlumnos(List<Alumno> alumnos)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"DELETE FROM ALUMNOS";
                command.ExecuteNonQuery();

                foreach (Alumno alumno in alumnos)
                {
                    command.Parameters.Clear();
                    command.CommandText = $"INSERT INTO ALUMNOS (nombre, apellido, dni, correo, estado, idPlanAdquirido) " +
                        "VALUES (@Nombre, @Apellido, @Dni, @Correo, @Estado, @IdPlan)";
                    command.Parameters.AddWithValue("@Nombre", alumno.Nombre);
                    command.Parameters.AddWithValue("@Apellido", alumno.Apellido);
                    command.Parameters.AddWithValue("@Dni", alumno.Dni);
                    command.Parameters.AddWithValue("@Correo", alumno.CorreoElectronico);
                    command.Parameters.AddWithValue("@Estado", alumno.Estado);
                    command.Parameters.AddWithValue("@IdPlan", alumno.IdPlanAdquirido);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Error al guardar la base de datos de Alumnos.");
            }
            finally
            {
                connection.Close();
            }
        }

        public static List<Alumno> LeerAlumnos()
        {
            List<Alumno> alumnos = new List<Alumno>();

            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM ALUMNOS";

                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        alumnos.Add(new Alumno(dataReader["nombre"].ToString(), dataReader["apellido"].ToString(), Convert.ToInt32(dataReader["dni"]),
                            dataReader["correo"].ToString(), (EEstado)Enum.Parse(typeof(EEstado), dataReader["estado"].ToString()),
                            Convert.ToInt32(dataReader["idPlanAdquirido"])));
                    }
                }

                return alumnos;
            }
            catch (Exception)
            {
                throw new Exception("Error al cargar la base de datos de Alumnos.");
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
