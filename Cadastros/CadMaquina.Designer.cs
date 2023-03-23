
namespace FQXAutoMec.Cadastros
{
    partial class CadMaquina
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadMaquina));
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.MenuCadastroMaquina = new System.Windows.Forms.ToolStrip();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecoMaquina = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtItemMaquina = new System.Windows.Forms.TextBox();
            this.txtCodMaquina = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dgvMaquinas = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.MenuCadastroMaquina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaquinas)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabel1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(352, 33);
            this.toolStripLabel1.Text = "Cadastro de Máquina - Novo";
            // 
            // MenuCadastroMaquina
            // 
            this.MenuCadastroMaquina.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MenuCadastroMaquina.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.MenuCadastroMaquina.Location = new System.Drawing.Point(0, 0);
            this.MenuCadastroMaquina.Name = "MenuCadastroMaquina";
            this.MenuCadastroMaquina.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MenuCadastroMaquina.Size = new System.Drawing.Size(1146, 36);
            this.MenuCadastroMaquina.TabIndex = 14;
            this.MenuCadastroMaquina.Text = "toolStrip1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "R$";
            // 
            // txtPrecoMaquina
            // 
            this.txtPrecoMaquina.Location = new System.Drawing.Point(355, 206);
            this.txtPrecoMaquina.Name = "txtPrecoMaquina";
            this.txtPrecoMaquina.Size = new System.Drawing.Size(89, 20);
            this.txtPrecoMaquina.TabIndex = 35;
            this.txtPrecoMaquina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Preço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Item";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Cod Máquina";
            // 
            // txtItemMaquina
            // 
            this.txtItemMaquina.Location = new System.Drawing.Point(140, 206);
            this.txtItemMaquina.Name = "txtItemMaquina";
            this.txtItemMaquina.Size = new System.Drawing.Size(208, 20);
            this.txtItemMaquina.TabIndex = 31;
            // 
            // txtCodMaquina
            // 
            this.txtCodMaquina.Location = new System.Drawing.Point(51, 206);
            this.txtCodMaquina.Name = "txtCodMaquina";
            this.txtCodMaquina.Size = new System.Drawing.Size(67, 20);
            this.txtCodMaquina.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Código";
            this.label5.Visible = false;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(51, 117);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(46, 20);
            this.txtID.TabIndex = 37;
            this.txtID.Visible = false;
            // 
            // dgvMaquinas
            // 
            this.dgvMaquinas.AllowUserToAddRows = false;
            this.dgvMaquinas.BackgroundColor = System.Drawing.Color.White;
            this.dgvMaquinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaquinas.GridColor = System.Drawing.Color.White;
            this.dgvMaquinas.Location = new System.Drawing.Point(690, 117);
            this.dgvMaquinas.Name = "dgvMaquinas";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Cyan;
            this.dgvMaquinas.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMaquinas.Size = new System.Drawing.Size(444, 208);
            this.dgvMaquinas.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(687, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Últimos produtos cadastrados";
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.White;
            this.btnNovo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(816, 555);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 37);
            this.btnNovo.TabIndex = 45;
            this.btnNovo.TabStop = false;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = false;
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.White;
            this.btnInserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInserir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnInserir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserir.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir.Image")));
            this.btnInserir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserir.Location = new System.Drawing.Point(897, 555);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 37);
            this.btnInserir.TabIndex = 47;
            this.btnInserir.TabStop = false;
            this.btnInserir.Text = "Salvar";
            this.btnInserir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInserir.UseVisualStyleBackColor = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.White;
            this.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(978, 555);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 37);
            this.btnAlterar.TabIndex = 48;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.White;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(1059, 555);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 37);
            this.btnExcluir.TabIndex = 49;
            this.btnExcluir.TabStop = false;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // CadMaquina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1146, 604);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgvMaquinas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrecoMaquina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtItemMaquina);
            this.Controls.Add(this.txtCodMaquina);
            this.Controls.Add(this.MenuCadastroMaquina);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadMaquina";
            this.Load += new System.EventHandler(this.CadMaquina_Load);
            this.MenuCadastroMaquina.ResumeLayout(false);
            this.MenuCadastroMaquina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaquinas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStrip MenuCadastroMaquina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecoMaquina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemMaquina;
        private System.Windows.Forms.TextBox txtCodMaquina;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dgvMaquinas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
    }
}