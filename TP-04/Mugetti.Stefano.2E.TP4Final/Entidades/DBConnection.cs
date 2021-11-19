using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Entidades
{
    public static class DBConnection
    {
        static SqlConnection conexion;
        static SqlCommand comando;
        static SqlDataReader reader;

        static DBConnection()
        {
            conexion = new SqlConnection(@"Data Source=DESKTOP-QIA3L6D\SQLEXPRESS;Database=Tp4Stefano;Trusted_Connection=True;");

            comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
        }

        public static List<Equipo> ConsultaEquipos(string query)
        {
            List<Equipo> auxLista = new List<Equipo>();
            try
            {
                comando.Connection = conexion;
                comando.CommandText = query;

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    auxLista.Add(new Equipo(reader[0].ToString(), double.Parse(reader[1].ToString()), int.Parse(reader[2].ToString())));
                }

                return auxLista;
            }
            catch (Exception ex)
            {
                Archivos<bool>.InformarError(ex.Message);
            }

            finally
            {
                conexion.Close();
            }
            return auxLista;
        }
        public static List<Jugador> ConsultaJugadores(string query)
        {
            List<Jugador> auxLista = new List<Jugador>();
            try
            {
                comando.Connection = conexion;
                comando.CommandText = query;

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    auxLista.Add(new Jugador(reader[0].ToString(), reader[1].ToString(), int.Parse(reader[2].ToString()),
                        double.Parse(reader[3].ToString()), double.Parse(reader[4].ToString()), reader[5].ToString(),
                        reader[6].ToString(), reader[7].ToString(), double.Parse(reader[8].ToString()), reader[9].ToString(),
                        long.Parse(reader[10].ToString())));
                }

                return auxLista;
            }
            catch (Exception ex)
            {
                Archivos<bool>.InformarError(ex.Message);
            }

            finally
            {
                conexion.Close();
            }
            return auxLista;
        }
        public static void InsertarEquipo(string nombre, double valor, int añoCreacion)
        {
            try
            {
                comando.Connection = conexion;   
                comando.CommandText = "INSERT INTO EQUIPOS VALUES (@Nombre, @Valor, @AñoCreacion ) ";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Valor", valor);
                comando.Parameters.AddWithValue("@AñoCreacion", añoCreacion);

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Archivos<bool>.InformarError(ex.Message);
            }

            finally
            {
                conexion.Close();
            }

        }
        public static void ModificarEquipo(string equipoAModif,string nombre, double valor, int añoCreacion)
        {
            try
            {
                comando.Connection = conexion;
                comando.CommandText = $"UPDATE EQUIPOS SET Nombre = (@Nombre),Valor = (@Valor),AñoCreacion = (@AñoCreacion) where Nombre = '{equipoAModif}'";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Valor", valor);
                comando.Parameters.AddWithValue("@AñoCreacion", añoCreacion);

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Archivos<bool>.InformarError(ex.Message);
            }

            finally
            {
                conexion.Close();
            }

        }
        public static void EliminarEquipo(string nombre)
        {
            try
            {
                comando.Connection = conexion;
                comando.CommandText = $"DELETE FROM EQUIPOS WHERE Nombre = '{nombre}'";

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Archivos<bool>.InformarError(ex.Message);
            }

            finally
            {
                conexion.Close();
            }
        }
        public static void EliminarJugador(long dni)
        {
            try
            {
                comando.Connection = conexion;
                comando.CommandText = $"DELETE FROM JUGADORES WHERE Dni = {dni}";

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Archivos<bool>.InformarError(ex.Message);
            }

            finally
            {
                conexion.Close();
            }
        }
        public static void InsertarJugador(string nombre, string apellido, int edad, double altura, double peso, string nacionalidad, string pieHabil, string club, double valor, string posicion, long dni)
        {
            try
            {
                comando.Connection = conexion;
                comando.CommandText = "Insert into Jugadores values (@Nombre, @Apellido, @Edad, @Altura, @Peso, @Nacionalidad, @PieHabil, @Club, @Valor, @Posicion, @Dni ) ";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Apellido", apellido);
                comando.Parameters.AddWithValue("@Edad", edad);
                comando.Parameters.AddWithValue("@Altura", altura);
                comando.Parameters.AddWithValue("@Peso", peso);
                comando.Parameters.AddWithValue("@Nacionalidad", nacionalidad);
                comando.Parameters.AddWithValue("@PieHabil", pieHabil);
                comando.Parameters.AddWithValue("@Club", club);
                comando.Parameters.AddWithValue("@Valor", valor);
                comando.Parameters.AddWithValue("@Posicion", posicion);
                comando.Parameters.AddWithValue("@Dni", dni);

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Archivos<bool>.InformarError(ex.Message);
            }

            finally
            {
                conexion.Close();
            }

        }
        public static void ModificarJugador(long dniAModif,string nombre, string apellido, int edad, double altura, double peso, string nacionalidad, string pieHabil, string club, double valor, string posicion, long dni)
        {
            try
            {
                comando.Connection = conexion;
                comando.CommandText = $"UPDATE JUGADORES SET Nombre = @Nombre,Apellido = @Apellido,Edad = @Edad,Altura = @Altura,Peso = @Peso,Nacionalidad =@Nacionalidad,PieHabil =@PieHabil,Club = @Club,Valor = @Valor,Posicion = @Posicion,Dni = @Dni WHERE Dni = '{dniAModif.ToString()}'";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Apellido", apellido);
                comando.Parameters.AddWithValue("@Edad", edad);
                comando.Parameters.AddWithValue("@Altura", altura);
                comando.Parameters.AddWithValue("@Peso", peso);
                comando.Parameters.AddWithValue("@Nacionalidad", nacionalidad);
                comando.Parameters.AddWithValue("@PieHabil", pieHabil);
                comando.Parameters.AddWithValue("@Club", club);
                comando.Parameters.AddWithValue("@Valor", valor);
                comando.Parameters.AddWithValue("@Posicion", posicion);
                comando.Parameters.AddWithValue("@Dni", dni);

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Archivos<bool>.InformarError(ex.Message);
            }

            finally
            {
                conexion.Close();
            }

        }
    }
}
