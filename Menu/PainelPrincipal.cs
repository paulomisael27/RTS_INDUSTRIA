using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FQXAutoMec.Menu
{
    public partial class PainelPrincipal : Form
    {
        public PainelPrincipal()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                lblhora.Text = DateTime.Now.ToString("hh:mm:ss");
                lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void PainelPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'rTS_ConsultaPedidos.REGISTRA_PEDIDO'. Você pode movê-la ou removê-la conforme necessário.
            this.rEGISTRA_PEDIDOTableAdapter.Fill(this.rTS_ConsultaPedidos.REGISTRA_PEDIDO);
        }
    }
}
