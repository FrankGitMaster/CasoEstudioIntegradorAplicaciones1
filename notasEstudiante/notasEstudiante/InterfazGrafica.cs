//Desarrollado por Frank Aguilar Garzon y Juan Pablo Pinzon Delgado
namespace notasEstudiante
{
    public partial class InterfazGrafica : Form
    {
        public InterfazGrafica()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalcularDefinitiva_Click(object sender, EventArgs e)
        {
            // Validar entrada de datos
            if (double.TryParse(textBoxCorte1.Text, out double notaCorte1) &&
                double.TryParse(textBoxCorte2.Text, out double notaCorte2) &&
                double.TryParse(textBoxCorte3.Text, out double notaCorte3))
            {
                // Crear instancia de la clase CalculadoraDeNotas y calcular la nota definitiva
                CalcularNotas calculadora = new CalcularNotas();
                double notaDefinitiva = calculadora.CalcularNotaDefinitiva(notaCorte1, notaCorte2, notaCorte3);

                // Mostrar la nota definitiva
                textBoxDefinitiva.Text = notaDefinitiva.ToString("0.0");

                // Guardar las notas en la base de datos
                Conexion repositorio = new Conexion();
                repositorio.GuardarNotas(textBoxEstudiante.Text, notaCorte1, notaCorte2, notaCorte3, notaDefinitiva);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese notas válidas en los campos correspondientes.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
