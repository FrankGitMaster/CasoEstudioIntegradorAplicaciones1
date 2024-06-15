using Microsoft.Data.SqlClient;

namespace CalculadoraDeNotas
{
    public class RepositorioDeNotas
    {
        private string connectionString = "Server=TU_SERVIDOR;Database=notasPolitecnicoInternacional;Integrated Security=True;";

        public void GuardarNotas(string nombreEstudiante, double notaCorte1, double notaCorte2, double notaCorte3, double notaDefinitiva)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO tecnologiaDesarrolloSoftware (NombreEstudiante, NotaCorte1, NotaCorte2, NotaCorte3, NotaDefinitiva) VALUES (@NombreEstudiante, @NotaCorte1, @NotaCorte2, @NotaCorte3, @NotaDefinitiva)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NombreEstudiante", nombreEstudiante);
                command.Parameters.AddWithValue("@NotaCorte1", notaCorte1);
                command.Parameters.AddWithValue("@NotaCorte2", notaCorte2);
                command.Parameters.AddWithValue("@NotaCorte3", notaCorte3);
                command.Parameters.AddWithValue("@NotaDefinitiva", notaDefinitiva);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
