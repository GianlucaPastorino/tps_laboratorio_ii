using System;
using System.IO;
using System.Text.Json;

namespace Entidades
{
    public static class Serializer<T>
    {
        static string path;

        static Serializer()
        {
            path = AppDomain.CurrentDomain.BaseDirectory;
        }

        public static void EscribirJson(T datos, string nombre)
        {
            string nombreArchivo = path + nombre;

            try
            {
                File.WriteAllText(nombreArchivo, JsonSerializer.Serialize(datos));
            }
            catch (Exception)
            {
                throw new SerializacionException($"Error al guardar el archivo \"{nombreArchivo}\".");
            }
        }

        public static T LeerJson(string nombre)
        {
            string archivo = string.Empty;
            T datosRecuperados = default;
            try
            {
                if (Directory.Exists(path))
                {
                    string[] archivosEnElPath = Directory.GetFiles(path);
                    foreach (string path in archivosEnElPath)
                    {
                        if (path.Contains(nombre))
                        {
                            archivo = path;
                            break;
                        }
                    }

                    if (archivo != null)
                    {
                        datosRecuperados = JsonSerializer.Deserialize<T>(File.ReadAllText(archivo));
                    }
                }

                return datosRecuperados;
            }
            catch (Exception)
            {
                throw new SerializacionException($"Error al cargar el archivo \"{nombre}\".");
            }

        }
    }
}
