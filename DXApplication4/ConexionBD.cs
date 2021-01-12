using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication4
{
    public class ConexionBD
    {
        public static int Findrow(DataTable tabla, string Nombre_columna, string Value)
        {
            int result = -1;
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                if (tabla.Rows[i][Nombre_columna].ToString() == Value)
                {
                    result = i;
                    break;
                }
            }
            return result;
        }


        public static SqlConnection GetConnection()
        {
            try
            {
                string strConnect = "Data Source=" + "192.168.0.21" + ";Initial Catalog=" + "REGISTRO_CEPV" + ";User ID=" + "sa" + ";Password=" + "sistemas123" + "";

                return new SqlConnection(strConnect);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }



        public static string Right(string sValue, int iMaxLength)
        {
            //Check if the value is valid
            if (string.IsNullOrEmpty(sValue))
            {
                //Set valid empty string as string could be null
                sValue = string.Empty;
            }
            else if (sValue.Length > iMaxLength)
            {
                //Make the string no longer than the max length
                sValue = sValue.Substring(sValue.Length - iMaxLength, iMaxLength);
            }
            //Return the string
            return sValue;
        }


        public static bool Ejecutar(string Consulta, Byte[] Imagen = null)
        {
            SqlConnection Cn = GetConnection();
            bool exito = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Cn;
                cmd.CommandTimeout = 0;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = Consulta;
                if (Imagen != null)
                {
                    SqlParameter parametro = new SqlParameter("@PIC", SqlDbType.Image);
                    parametro.Value = Imagen;
                    cmd.Parameters.Add(parametro);
                }
                //else
                //{
                //    SqlParameter parametro = new SqlParameter("@PIC", SqlDbType.Image);
                //    Imagen = null;
                //    parametro.Value = Imagen;
                //    cmd.Parameters.Add(parametro);
                //}
                Cn.Open();
                //if ((Parametros != null))
                //{
                //    SqlCommandBuilder.DeriveParameters(cmd);
                //    for (int i = 1; i <= Parametros.Length; i++)
                //    {
                //        cmd.Parameters[i].Value = Parametros[i - 1];
                //    }
                //}
                cmd.ExecuteNonQuery();
                Cn.Close();
                cmd.Dispose();
                exito = true;

            }
            catch (Exception ex)
            {
                exito = false;
                throw new Exception(ex.Message);
            }

            return exito;
        }
        public static DataTable ExtraeDatos(string Cmd, string NombreTabla = "DATOS")
        {
            DataTable dt = new DataTable();
            SqlConnection Cn = GetConnection();
            SqlDataAdapter da = new SqlDataAdapter(Cmd, Cn);

            try
            {
                Cn.Open();
                da.SelectCommand.Connection = Cn;
                da.Fill(dt);
                dt.TableName = NombreTabla;
                int ds = dt.Rows.Count;
            }
            catch (Exception ex)
            {
                try
                {
                    da = new SqlDataAdapter(("SET DATEFORMAT DMY; EXEC " + Cmd), Cn);
                    da.SelectCommand.Connection = Cn;
                    da.Fill(dt);
                    dt.TableName = NombreTabla;
                }
                catch (Exception exa)
                {
                    throw new Exception(exa.Message);
                }
            }
            Cn.Close();

            return dt;
        }
        public static DataTable Leer(string Procedimiento, params object[] Parametros)
        {
            SqlConnection cn = GetConnection();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = Procedimiento;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;
            cn.Open();
            cmd.Connection = cn;
            da.SelectCommand = cmd;
            SqlCommandBuilder.DeriveParameters(cmd);

            try
            {
                if ((Parametros != null))
                {
                    for (int i = 1; i <= Parametros.Length; i++)
                    {
                        cmd.Parameters[i].Value = (Parametros[i - 1] == null ? DBNull.Value : Parametros[i - 1]);
                    }
                }

                da.Fill(dt);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            cn.Close();
            return dt;
        }

        public static Boolean EjecutarPro(string Procedimiento, params object[] Parametros)
        {
            Boolean exito = false;
            SqlConnection cn = GetConnection();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = Procedimiento;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;
            cn.Open();
            cmd.Connection = cn;
            SqlCommandBuilder.DeriveParameters(cmd);
            try
            {
                if ((Parametros != null))
                {
                    for (int i = 1; i <= Parametros.Length; i++)
                    {
                        cmd.Parameters[i].Value = (Parametros[i - 1] == null ? DBNull.Value : Parametros[i - 1]);
                    }
                }

                cmd.ExecuteNonQuery();
                exito = true;
            }
            catch (Exception ex)
            {
                exito = false;
                MessageBox.Show($"({Procedimiento}) {ex.Message}");
            }

            cn.Close();
            return exito;
        }

        public static void SetCulture(string cultureName)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(cultureName);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(cultureName);
        }

    }
}
