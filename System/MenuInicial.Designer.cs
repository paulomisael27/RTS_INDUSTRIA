﻿
namespace FQXAutoMec.SqlConnection
{
    partial class MenuInicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private SqlConnection.ComponentModel.IContainer components = null;

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
            this.components = new SqlConnection.ComponentModel.Container();
            this.AutoScaleMode = SqlConnection.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new SqlConnection.Drawing.Size(800, 450);
            this.Text = "MenuInicial";
        }

        #endregion
    }
}