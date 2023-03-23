using FQXAutoMec.Cadastros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FQXAutoMec.Menu;
using FQXAutoMec.Módulos;
using FQXAutoMec.Visualização;

namespace FQXAutoMec
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            Customizado();
        }

        private void Customizado()
        {
            panelPedidoMenu.Visible = false;
            panelConfiguracao.Visible = false;
        }

        public MenuPrincipal(string valor1, string valor2)
        {
            InitializeComponent();
            lblUsuario.Text = valor1;
            lblFuncao.Text = valor2;
        }

        private void MostrarMenu()
        {
            if (panelPedidoMenu.Visible == true)
                panelPedidoMenu.Visible = false;
        }

        private void MostrarMenuConfig()
        {
            if (panelConfiguracao.Visible == true)
                panelConfiguracao.Visible = false;
        }

        private void MostrarSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                MostrarMenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void MostrarMenuConfig(Panel configMenu)
        {
            if (configMenu.Visible == false)
            {
                MostrarMenuConfig();
                configMenu.Visible = true;
            }
            else
                configMenu.Visible = false;
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadProduto CCAD = new CadProduto();
            CCAD.Show();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadMaquina FCCAD = new CadMaquina();
            FCCAD.Show();
        }

        private void fornecedorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CadInsumo FCAD = new CadInsumo();
            FCAD.Show();
        }

        private void btnEscondeMenu_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Width == 242)
            {
                pnlMenu.Width = 70;
            }
            else
            {
                pnlMenu.Width = 242;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MenuPrincipal MP = new MenuPrincipal();
            MP.Show();
        }

        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.btnConfiguracao.Controls.Count > 0)
                this.btnConfiguracao.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.btnConfiguracao.Controls.Add(fh);
            this.btnConfiguracao.Tag = fh;
            fh.Show();
        }

        private void panelLogo_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new PainelPrincipal());
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            
            panelLogo_Click(null, e);
            lblStatusServer.Text = "Online";
        }

        private void btnPedidoMenu_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelPedidoMenu);
            panelConfiguracao.Visible = false;
        }

        private void btnInserirDadosMenu_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new PedidoMenu());
        }

        private void CadastrarInsumo_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new CadInsumo());
        }

        private void btnContaReceberMenu_Click(object sender, EventArgs e)
        {
            PedidosLancados PL = new PedidosLancados();
            PL.ShowDialog();
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void CadastrarProdutos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new CadProduto());
        }

        private void CadastrarMaquina_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new CadMaquina());
        }

        private void btnConfiguracaoMenu_Click(object sender, EventArgs e)
        {
            MostrarMenuConfig(panelConfiguracao);
            panelPedidoMenu.Visible = false;
        }
    }
}