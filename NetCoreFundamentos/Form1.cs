namespace NetCoreFundamentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {
            //SOLO ESCRIBIMOS AQUI
            this.txtNombre.Location = new Point(10, 30);
            this.txtNombre.Text = "Soy un texto nuevo!!";
            this.txtNombre.Width = 350;
            this.txtNombre.TextAlign = HorizontalAlignment.Center;
            this.txtNombre.BackColor = Color.Gray;

            //CONVERSION AUTOMATICA
            short pequeño = 88;
            int mayor = pequeño;

            //STRING A PRIMITIVO
            string textoNumero = "Hoy es viernes";
            int numero = int.Parse(textoNumero);

            int mayorcito = 88;
            short pequeñito = (short)mayor;

        }

    }
}
