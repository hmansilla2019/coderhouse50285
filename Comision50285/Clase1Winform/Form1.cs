namespace Clase1Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            const double pi = 3.14159;
            int radioCirculo = 3;
            double areaCirculo;

            areaCirculo = pi * (radioCirculo * radioCirculo);

            lblArea.Text = areaCirculo.ToString();

        }
    }
}