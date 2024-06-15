//Desarrollado por Frank Aguilar Garzon y Juan Pablo Pinzon Delgado

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace notasEstudiante
{
    internal class Conexion
    {

       //rivate string connectionString = "Server=FRANK\\SQLEXPRESS;Database=notasPolitecnicoInternacional;Integrated Security=True;TrustServerCertificate=True;";

        public void GuardarNotas(string nombreEstudiante, double notaCorte1, double notaCorte2, double notaCorte3, double notaDefinitiva)
        {
            using (SqlConnection conexion = new SqlConnection("Server=FRANK\\SQLEXPRESS;Database=notasPolitecnicoInternacional;Integrated Security=True;TrustServerCertificate=True;"))
            {
                string query = "INSERT INTO tecnologiaDesarrolloSoftware (NombreEstudiante, NotaCorte1, NotaCorte2, NotaCorte3, NotaDefinitiva) VALUES (@NombreEstudiante, @NotaCorte1, @NotaCorte2, @NotaCorte3, @NotaDefinitiva)";
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@NombreEstudiante", nombreEstudiante);
                command.Parameters.AddWithValue("@NotaCorte1", notaCorte1);
                command.Parameters.AddWithValue("@NotaCorte2", notaCorte2);
                command.Parameters.AddWithValue("@NotaCorte3", notaCorte3);
                command.Parameters.AddWithValue("@NotaDefinitiva", notaDefinitiva);

                conexion.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
