
namespace FQXAutoMec
{
    partial class VerificaServer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pgbVerificaStatus = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnFecharForm = new System.Windows.Forms.Button();
            this.MudaStatus = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // pgbVerificaStatus
            // 
            this.pgbVerificaStatus.Location = new System.Drawing.Point(133, 157);
            this.pgbVerificaStatus.Name = "pgbVerificaStatus";
            this.pgbVerificaStatus.Size = new System.Drawing.Size(327, 23);
            this.pgbVerificaStatus.TabIndex = 0;
            this.pgbVerificaStatus.Value = 100;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // btnFecharForm
            // 
            this.btnFecharForm.Enabled = false;
            this.btnFecharForm.Location = new System.Drawing.Point(264, 242);
            this.btnFecharForm.Name = "btnFecharForm";
            this.btnFecharForm.Size = new System.Drawing.Size(60, 23);
            this.btnFecharForm.TabIndex = 2;
            this.btnFecharForm.Text = "OK";
            this.btnFecharForm.UseVisualStyleBackColor = true;
            this.btnFecharForm.Click += new System.EventHandler(this.btnFecharForm_Click);
            // 
            // MudaStatus
            // 
            this.MudaStatus.WorkerReportsProgress = true;
            this.MudaStatus.DoWork += new System.ComponentModel.DoWorkEventHandler(this.MudaStatus_DoWork);
            this.MudaStatus.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.MudaStatus_ProgressChanged);
            // 
            // VerificaServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(601, 319);
            this.Controls.Add(this.btnFecharForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pgbVerificaStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerificaServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerificaServer";
            this.Load += new System.EventHandler(this.VerificaServer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgbVerificaStatus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFecharForm;
        private System.ComponentModel.BackgroundWorker MudaStatus;
    }
}