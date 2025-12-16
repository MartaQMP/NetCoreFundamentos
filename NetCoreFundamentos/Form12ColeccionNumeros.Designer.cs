namespace NetCoreFundamentos
{
    partial class Form12ColeccionNumeros
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
            btnMostrar = new Button();
            btnGenerar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lstCaja = new ListBox();
            txtPares = new TextBox();
            txtImpares = new TextBox();
            txtSuma = new TextBox();
            SuspendLayout();
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(278, 77);
            btnMostrar.Margin = new Padding(4);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(167, 37);
            btnMostrar.TabIndex = 0;
            btnMostrar.Text = "Mostrar datos";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(278, 23);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(167, 36);
            btnGenerar.TabIndex = 1;
            btnGenerar.Text = "Generar Numeros";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 23);
            label1.Name = "label1";
            label1.Size = new Size(75, 21);
            label1.TabIndex = 2;
            label1.Text = "Numeros";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(240, 145);
            label2.Name = "label2";
            label2.Size = new Size(50, 21);
            label2.TabIndex = 3;
            label2.Text = "Suma";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(240, 189);
            label3.Name = "label3";
            label3.Size = new Size(50, 21);
            label3.TabIndex = 4;
            label3.Text = "Pares:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(240, 225);
            label4.Name = "label4";
            label4.Size = new Size(69, 21);
            label4.TabIndex = 5;
            label4.Text = "Impares:";
            // 
            // lstCaja
            // 
            lstCaja.FormattingEnabled = true;
            lstCaja.Location = new Point(27, 52);
            lstCaja.Name = "lstCaja";
            lstCaja.Size = new Size(167, 214);
            lstCaja.TabIndex = 6;
            // 
            // txtPares
            // 
            txtPares.Location = new Point(332, 181);
            txtPares.Name = "txtPares";
            txtPares.Size = new Size(100, 29);
            txtPares.TabIndex = 7;
            // 
            // txtImpares
            // 
            txtImpares.Location = new Point(332, 222);
            txtImpares.Name = "txtImpares";
            txtImpares.Size = new Size(100, 29);
            txtImpares.TabIndex = 8;
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(332, 137);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(100, 29);
            txtSuma.TabIndex = 9;
            // 
            // Form12ColeccionNumeros
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 306);
            Controls.Add(txtSuma);
            Controls.Add(txtImpares);
            Controls.Add(txtPares);
            Controls.Add(lstCaja);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGenerar);
            Controls.Add(btnMostrar);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form12ColeccionNumeros";
            Text = "Form12ColeccionNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMostrar;
        private Button btnGenerar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox lstCaja;
        private TextBox txtPares;
        private TextBox txtImpares;
        private TextBox txtSuma;
    }
}