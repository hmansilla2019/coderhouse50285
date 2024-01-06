namespace FuncionesForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int suma = sumar((int)numNumero1.Value, (int)numNumero2.Value);


            MessageBox.Show("La suma es: " + suma);       
         }

        int sumar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
    }
}