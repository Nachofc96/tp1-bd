using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercico1
{
    public partial class frmEjercicio1 : Form
    {
        public frmEjercicio1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            string tipoCliente = cmbTipoCliente.Text;

            bool esTarjeta = false;

            decimal monto = decimal.Parse(txtMonto.Text);

            decimal descuento = CalcularPorcentajeDescuento(tipoCliente);

            if (rbEfectivo.Checked)
                esTarjeta = false;
            if (rbTarjeta.Checked)
                esTarjeta = true;

            decimal montoMedioPago = CalcularMedioPago(monto, esTarjeta);

            decimal total = OptenerMontoFinal(montoMedioPago, descuento);

            lblResultado.Text  = total.ToString();

        }
        private decimal CalcularPorcentajeDescuento(string tc)
        {
            if (tc == "Regular")
            {
                return 1;
            }
            else
            {
                if (tc == "Socio")
                {
                    return 0.90m;
                }
                else
                {
                    return 0.80m;
                }
            }
        }
        private decimal CalcularMedioPago(decimal monto, bool esTarjeta)
        {
            if (esTarjeta)
            {
                return monto * 1.05m;
            }
            else
            {
                return monto;
            }
        }
        private decimal OptenerMontoFinal(decimal montoBase , decimal descuento)
        { 
            return montoBase * descuento;
        }
    }
}
