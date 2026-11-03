namespace Formulario_de_bienvenida
{
    public partial class FormularioBienvenida : Form
    {
        public FormularioBienvenida()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "Aquí aparecerá el resultado";
            string nombre = txtNombre.Text;
            string textoEdad = txtEdad.Text;
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Introduce tu nombre.");
                return;
            }
            if (!int.TryParse(textoEdad, out int edad) || edad < 0)
            {
                MessageBox.Show("Introduce una edad válida.");
                return;
            }
            if (edad < 18)
            {
                MessageBox.Show("Debes ser mayor de edad para continuar.");
                return;
            }
            lblResultado.Text =
                $"Hola, {nombre}. \nTienes {edad} años.";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        { 
            txtNombre.Text = string.Empty;
            txtEdad.Text = string.Empty;
            lblResultado.Text = "Aquí aparecerá el resultado";
        }

        private void LimpiarEdadOn_Click(object sender, EventArgs e)
        {
            txtEdad.Text = string.Empty;
        }

        private void LimpiarNombreOn_Click(object sender, EventArgs e)
        {
            txtNombre.Text = string.Empty;
        }

        private void Nombre_RatonEntrar(object sender, EventArgs e)
        {
            txtNombre.Text = "Pepito";
        }

        private void Edad_RatonEntrar(object sender, EventArgs e)
        {
            txtEdad.Text = "90";
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            string textoEdad = txtEdad.Text;

            if (string.IsNullOrWhiteSpace(textoEdad))
            {
                lblAvisoEdad.Text = "";
                return;
            }

            if (!int.TryParse(textoEdad, out int edad) ||  edad < 18)
            {
                lblAvisoEdad.ForeColor = Color.Red;
                lblAvisoEdad.Text = "Debes introducir una edad válida y mayor de 18.";
            }
            else
            {
                lblAvisoEdad.ForeColor = Color.Green;
                lblAvisoEdad.Text = "Edad correcta ✓";
            }
        }
    }
}
