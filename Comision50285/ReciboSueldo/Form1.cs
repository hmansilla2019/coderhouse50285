using System.Runtime.CompilerServices;

namespace ReciboSueldo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            OcultarResultados();
            
        }
        void OcultarResultados()
        {
            this.lblTotalDescuentos.Text = "Total Descuentos: ";

            this.lblTotalCobrar.Text = "Total a cobrar bruto: ";

            this.lblTotalNeto.Text = "Total a cobrar neto: ";
            gbResultados.Visible = false;
        }
        private void btnCalcularMostrar_Click(object sender, EventArgs e)
        {

            /*
             Se pide calcular el importe a cobrar teniendo 
            en cuenta que al total que resuelta de multiplicar 
            el valor hora por la cantidad de horas trabajadas, 
            hay que sumarle la cantidad de años trabajados 
            multiplicados por $30, y al total de todas esas
            operaciones restarle el 13% en concepto de descuentos. 
             */
            decimal importeBruto = CalcularImporteCobrarBruto();

            decimal descuento = CalcularDescuento(importeBruto);

            decimal total = CalcularTotal(importeBruto, descuento);

            MostrarResultados(importeBruto, descuento, total);
        }

        void MostrarResultados(decimal importeBruto, decimal descuento, decimal total )
        {
            this.lblTotalDescuentos.Text += descuento.ToString();

            this.lblTotalCobrar.Text += importeBruto.ToString();

            this.lblTotalNeto.Text += total.ToString();

            gbResultados.Visible = true;
        }


        decimal CalcularTotal(decimal bruto, decimal descuento)
        {
            return bruto - descuento;
        }

        decimal CalcularImporteCobrarBruto()
        {
            decimal antiguedad = CalcularAntiguedad();
            decimal importeHoras = CalcularImporteHoras();

            return importeHoras + antiguedad; 
        }

        decimal CalcularAntiguedad()
        {
            return numAntiguedad.Value * 30;
        }
        decimal CalcularImporteHoras()
        {
            return numHorasTrabajadas.Value * numValorHora.Value;
        }

        decimal CalcularDescuento(decimal ImporteBruto)
        {
            // El literal de el tipo decimal es la letra m
            return ImporteBruto*0.3m;
        }
    }
}