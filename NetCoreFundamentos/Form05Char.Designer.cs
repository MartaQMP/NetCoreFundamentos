namespace NetCoreFundamentos
{
    partial class Form05Char
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
            label1 = new Label();
            txtLetra = new TextBox();
            txtNumero = new TextBox();
            label2 = new Label();
            txtPuntuacion = new TextBox();
            label3 = new Label();
            txtSimbolo = new TextBox();
            label4 = new Label();
            btnRun = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(55, 33);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 0;
            label1.Text = "Letras";
            // 
            // txtLetra
            // 
            txtLetra.Location = new Point(55, 61);
            txtLetra.Multiline = true;
            txtLetra.Name = "txtLetra";
            txtLetra.Size = new Size(141, 76);
            txtLetra.TabIndex = 1;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(243, 61);
            txtNumero.Multiline = true;
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(141, 76);
            txtNumero.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(243, 33);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 2;
            label2.Text = "Numeros";
            // 
            // txtPuntuacion
            // 
            txtPuntuacion.Location = new Point(55, 263);
            txtPuntuacion.Multiline = true;
            txtPuntuacion.Name = "txtPuntuacion";
            txtPuntuacion.Size = new Size(141, 76);
            txtPuntuacion.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(243, 217);
            label3.Name = "label3";
            label3.Size = new Size(108, 25);
            label3.TabIndex = 4;
            label3.Text = "Puntuacion";
            // 
            // txtSimbolo
            // 
            txtSimbolo.Location = new Point(243, 263);
            txtSimbolo.Multiline = true;
            txtSimbolo.Name = "txtSimbolo";
            txtSimbolo.Size = new Size(141, 76);
            txtSimbolo.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(55, 217);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 6;
            label4.Text = "Simbolos";
            // 
            // btnRun
            // 
            btnRun.Font = new Font("Segoe UI", 12F);
            btnRun.Location = new Point(141, 364);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(106, 37);
            btnRun.TabIndex = 8;
            btnRun.Text = "Run ASCII";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // Form05Char
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 450);
            Controls.Add(btnRun);
            Controls.Add(txtSimbolo);
            Controls.Add(label4);
            Controls.Add(txtPuntuacion);
            Controls.Add(label3);
            Controls.Add(txtNumero);
            Controls.Add(label2);
            Controls.Add(txtLetra);
            Controls.Add(label1);
            Name = "Form05Char";
            Text = "Form05Char";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtLetra;
        private TextBox txtNumero;
        private Label label2;
        private TextBox txtPuntuacion;
        private Label label3;
        private TextBox txtSimbolo;
        private Label label4;
        private Button btnRun;
    }
}