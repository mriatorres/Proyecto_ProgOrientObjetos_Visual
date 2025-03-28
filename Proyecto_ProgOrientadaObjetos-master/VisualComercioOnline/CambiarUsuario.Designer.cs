﻿namespace VisualComercioOnline
{
    partial class CambiarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambiarUsuario));
            label1 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Leelawadee UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(276, 40);
            label1.Name = "label1";
            label1.Size = new Size(243, 40);
            label1.TabIndex = 1;
            label1.Text = "Cambiar usuario";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkSlateBlue;
            label2.Font = new Font("Leelawadee UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(45, 120);
            label2.Name = "label2";
            label2.Size = new Size(182, 32);
            label2.TabIndex = 2;
            label2.Text = "Nuevo usuario";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Leelawadee UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = SystemColors.WindowText;
            txtEmail.Location = new Point(45, 175);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Ingrese su nuevo usuario";
            txtEmail.Size = new Size(474, 33);
            txtEmail.TabIndex = 3;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(192, 192, 255);
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Leelawadee UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.BlueViolet;
            button4.Location = new Point(257, 289);
            button4.Name = "button4";
            button4.Size = new Size(262, 43);
            button4.TabIndex = 5;
            button4.Text = "Actualizar datos";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // CambiarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CambiarUsuario";
            Text = "CambiarUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtEmail;
        private Button button4;
    }
}