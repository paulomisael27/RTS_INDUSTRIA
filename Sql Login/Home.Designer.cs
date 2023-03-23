
namespace FQXAutoMec
{
    partial class Home
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.txtUsuarioLogin = new System.Windows.Forms.TextBox();
            this.txtSenhaLogin = new System.Windows.Forms.TextBox();
            this.btnLogar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFecharHome = new System.Windows.Forms.Button();
            this.btnMinimizarHome = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlVerificaStatus = new System.Windows.Forms.Panel();
            this.tbxCargo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuarioLogin
            // 
            this.txtUsuarioLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtUsuarioLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuarioLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuarioLogin.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.txtUsuarioLogin.Location = new System.Drawing.Point(427, 109);
            this.txtUsuarioLogin.MaxLength = 50;
            this.txtUsuarioLogin.Name = "txtUsuarioLogin";
            this.txtUsuarioLogin.Size = new System.Drawing.Size(198, 18);
            this.txtUsuarioLogin.TabIndex = 1;
            this.txtUsuarioLogin.Text = "USUÁRIO";
            this.txtUsuarioLogin.Click += new System.EventHandler(this.txtUsuarioLogin_Click);
            this.txtUsuarioLogin.TextChanged += new System.EventHandler(this.txtUsuarioLogin_TextChanged);
            this.txtUsuarioLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuarioLogin_KeyPress);
            // 
            // txtSenhaLogin
            // 
            this.txtSenhaLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtSenhaLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenhaLogin.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.txtSenhaLogin.Location = new System.Drawing.Point(427, 157);
            this.txtSenhaLogin.MaxLength = 50;
            this.txtSenhaLogin.Name = "txtSenhaLogin";
            this.txtSenhaLogin.PasswordChar = '*';
            this.txtSenhaLogin.Size = new System.Drawing.Size(198, 18);
            this.txtSenhaLogin.TabIndex = 2;
            this.txtSenhaLogin.Text = "Senha";
            this.txtSenhaLogin.Click += new System.EventHandler(this.txtSenhaLogin_Click);
            // 
            // btnLogar
            // 
            this.btnLogar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnLogar.FlatAppearance.BorderSize = 0;
            this.btnLogar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnLogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogar.ForeColor = System.Drawing.Color.White;
            this.btnLogar.Location = new System.Drawing.Point(424, 256);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(201, 28);
            this.btnLogar.TabIndex = 3;
            this.btnLogar.Text = "Entrar";
            this.btnLogar.UseVisualStyleBackColor = false;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(397, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(397, 151);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(397, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 1);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(397, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 1);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 330);
            this.panel3.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(35, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(162, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(495, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Login";
            // 
            // btnFecharHome
            // 
            this.btnFecharHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnFecharHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFecharHome.BackgroundImage")));
            this.btnFecharHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFecharHome.FlatAppearance.BorderSize = 0;
            this.btnFecharHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnFecharHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFecharHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnFecharHome.ForeColor = System.Drawing.Color.White;
            this.btnFecharHome.Location = new System.Drawing.Point(757, 0);
            this.btnFecharHome.Name = "btnFecharHome";
            this.btnFecharHome.Size = new System.Drawing.Size(23, 22);
            this.btnFecharHome.TabIndex = 17;
            this.btnFecharHome.TabStop = false;
            this.btnFecharHome.UseVisualStyleBackColor = false;
            this.btnFecharHome.Click += new System.EventHandler(this.btnFecharHome_Click);
            // 
            // btnMinimizarHome
            // 
            this.btnMinimizarHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnMinimizarHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizarHome.BackgroundImage")));
            this.btnMinimizarHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimizarHome.FlatAppearance.BorderSize = 0;
            this.btnMinimizarHome.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnMinimizarHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnMinimizarHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizarHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnMinimizarHome.ForeColor = System.Drawing.Color.White;
            this.btnMinimizarHome.Location = new System.Drawing.Point(719, 0);
            this.btnMinimizarHome.Name = "btnMinimizarHome";
            this.btnMinimizarHome.Size = new System.Drawing.Size(23, 22);
            this.btnMinimizarHome.TabIndex = 18;
            this.btnMinimizarHome.TabStop = false;
            this.btnMinimizarHome.UseVisualStyleBackColor = false;
            this.btnMinimizarHome.Click += new System.EventHandler(this.btnMinimizarHome_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(397, 220);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 1);
            this.panel4.TabIndex = 21;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(385, 184);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(36, 38);
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(256, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Status do serviço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(345, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Online";
            // 
            // pnlVerificaStatus
            // 
            this.pnlVerificaStatus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlVerificaStatus.BackgroundImage")));
            this.pnlVerificaStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlVerificaStatus.Location = new System.Drawing.Point(379, 308);
            this.pnlVerificaStatus.Name = "pnlVerificaStatus";
            this.pnlVerificaStatus.Size = new System.Drawing.Size(18, 13);
            this.pnlVerificaStatus.TabIndex = 25;
            this.pnlVerificaStatus.DoubleClick += new System.EventHandler(this.pnlVerificaStatus_DoubleClick);
            // 
            // tbxCargo
            // 
            this.tbxCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.tbxCargo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCargo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.tbxCargo.Location = new System.Drawing.Point(427, 196);
            this.tbxCargo.MaxLength = 50;
            this.tbxCargo.Name = "tbxCargo";
            this.tbxCargo.Size = new System.Drawing.Size(198, 18);
            this.tbxCargo.TabIndex = 26;
            this.tbxCargo.Text = "Cargo";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.tbxCargo);
            this.Controls.Add(this.pnlVerificaStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnMinimizarHome);
            this.Controls.Add(this.btnFecharHome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtUsuarioLogin);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtSenhaLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FQX AutoMec - Versão: 1.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuarioLogin;
        private System.Windows.Forms.TextBox txtSenhaLogin;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFecharHome;
        private System.Windows.Forms.Button btnMinimizarHome;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlVerificaStatus;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private System.Windows.Forms.TextBox tbxCargo;
    }
}

