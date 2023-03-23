using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FQXAutoMec
{
    public partial class VerificaServer : Form
    {
        public VerificaServer()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pgbVerificaStatus.Value > 100)
                timer1.Enabled = false;
            else
                pgbVerificaStatus.Value += 1;
        }

        private void VerificaServer_Load(object sender, EventArgs e)
        {
             pgbVerificaStatus.Maximum = 100;
             timer1.Start();
            MudaStatus.RunWorkerAsync();
        }

        private void btnFecharForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MudaStatus_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pgbVerificaStatus.Value = e.ProgressPercentage;
            Text = e.ProgressPercentage.ToString();

            if (pgbVerificaStatus.Value >= 1 && pgbVerificaStatus.Value < 99)
            {
                label1.Text = "Verificando...";
            }
            else if (pgbVerificaStatus.Value > 99 && pgbVerificaStatus.Value <= 100)
            {
                label1.Text = "Status do Serviço OK";
                btnFecharForm.Enabled = true;
            }
        }

        private void MudaStatus_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i <= 100; i++) //loop para o progressbar
            {
                Thread.Sleep(100);
                MudaStatus.ReportProgress(i);
            }
        }
    }
}