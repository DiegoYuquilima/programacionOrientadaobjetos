using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cliente
{
    public partial class Form1 : Form
    {
        
        Producto mostrar = new Producto();
        Cliente objcliente = new Cliente();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            objcliente.EncargoID = Convert.ToInt32 (this.textBox1.Text);
            objcliente.Fecha = this.textBox1.Text;
            objcliente.Valor = Convert.ToInt32(this.textBox3.Text);

           mostrar.mostrar_producto = Convert.ToInt32(this.txtid.Text);

            MessageBox.Show(objcliente.EncargoID.ToString() + " , " + objcliente.Fecha.ToString() + " , " + objcliente.Valor.ToString());
        }
    }
    
}
