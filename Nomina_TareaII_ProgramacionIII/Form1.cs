using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nomina_TareaII_ProgramacionIII
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtSueldoBruto.Clear();
            txtAFP.Clear();
            txtARS.Clear();
            txtISR.Clear();
            txtTotalDescuento.Clear();
            txtSN.Clear();
            txtSueldoBruto.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
