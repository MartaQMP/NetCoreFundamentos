namespace NetCoreFundamentos
{
    partial class Form14Metodos
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
            txtNumero = new TextBox();
            lblResultado = new Label();
            btnValor = new Button();
            btnReferencia = new Button();
            btnObjeto = new Button();
            lblRaton = new Label();
            txtNumeros = new TextBox();
            txtLetras = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 33);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 0;
            label1.Text = "Numero";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(35, 57);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(142, 29);
            txtNumero.TabIndex = 1;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(32, 133);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(79, 21);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "Resultado";
            // 
            // btnValor
            // 
            btnValor.Location = new Point(46, 172);
            btnValor.Name = "btnValor";
            btnValor.Size = new Size(112, 35);
            btnValor.TabIndex = 3;
            btnValor.Text = "Doble Valor";
            btnValor.UseVisualStyleBackColor = true;
            btnValor.Click += btnValor_Click;
            // 
            // btnReferencia
            // 
            btnReferencia.Location = new Point(35, 225);
            btnReferencia.Name = "btnReferencia";
            btnReferencia.Size = new Size(138, 35);
            btnReferencia.TabIndex = 4;
            btnReferencia.Text = "Doble Referencia";
            btnReferencia.UseVisualStyleBackColor = true;
            btnReferencia.Click += btnReferencia_Click;
            // 
            // btnObjeto
            // 
            btnObjeto.Location = new Point(46, 282);
            btnObjeto.Name = "btnObjeto";
            btnObjeto.Size = new Size(112, 63);
            btnObjeto.TabIndex = 5;
            btnObjeto.Text = "Objeto Referencia";
            btnObjeto.UseVisualStyleBackColor = true;
            btnObjeto.Click += btnObjeto_Click;
            // 
            // lblRaton
            // 
            lblRaton.BackColor = Color.Salmon;
            lblRaton.Location = new Point(262, 156);
            lblRaton.Name = "lblRaton";
            lblRaton.Size = new Size(285, 189);
            lblRaton.TabIndex = 6;
            lblRaton.Text = "lblRaton";
            lblRaton.TextAlign = ContentAlignment.MiddleCenter;
            lblRaton.MouseMove += lblRaton_MouseMove;
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(377, 27);
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(141, 29);
            txtNumeros.TabIndex = 7;
            txtNumeros.KeyPress += txtNumeros_KeyPress;
            // 
            // txtLetras
            // 
            txtLetras.Location = new Point(377, 83);
            txtLetras.Name = "txtLetras";
            txtLetras.Size = new Size(141, 29);
            txtLetras.TabIndex = 8;
            txtLetras.KeyPress += txtLetras_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(260, 33);
            label2.Name = "label2";
            label2.Size = new Size(107, 21);
            label2.TabIndex = 9;
            label2.Text = "Solo numeros";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(262, 91);
            label3.Name = "label3";
            label3.Size = new Size(83, 21);
            label3.TabIndex = 10;
            label3.Text = "Solo letras";
            // 
            // Form14Metodos
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 366);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtLetras);
            Controls.Add(txtNumeros);
            Controls.Add(lblRaton);
            Controls.Add(btnObjeto);
            Controls.Add(btnReferencia);
            Controls.Add(btnValor);
            Controls.Add(lblResultado);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form14Metodos";
            Text = "Form14Metodos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private Label lblResultado;
        private Button btnValor;
        private Button btnReferencia;
        private Button btnObjeto;
        private Label lblRaton;
        private TextBox txtNumeros;
        private TextBox txtLetras;
        private Label label2;
        private Label label3;
    }
}