using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;



namespace RhController.Models
{
	public static class Login
	{
		public static bool Autenticar(string usuario, string contraseña)
		{
			//consulta de BD
			string sql = @"Select count(*)
						from Cuentas
						where Nombre=@user and Contraseña=@pass";
			//cadena de conexion
			using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString()))
			{
				conn.Open();//abrimos la conexion
				SqlCommand cmd = new SqlCommand(sql, conn);//ejecutamos la consulta
				cmd.Parameters.AddWithValue("@user", usuario);//enviamos parametros de usuario
				cmd.Parameters.AddWithValue("@pass", contraseña);//enviamos parametros de contraseña

				int count = Convert.ToInt32(cmd.ExecuteScalar());//devuelve la fila afectada

				if (count == 0)
					return false;
				else
					return true;
			}
		}
	}
}