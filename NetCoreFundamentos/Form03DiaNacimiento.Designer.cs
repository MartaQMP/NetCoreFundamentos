namespace NetCoreFundamentos
{
    partial class Form03DiaNacimiento
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtAnio = new TextBox();
            txtMes = new TextBox();
            txtDia = new TextBox();
            lblDiaSemana = new Label();
            SuspendLayout();
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(53, 144);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(123, 54);
            btnMostrar.TabIndex = 0;
            btnMostrar.Text = "Mostrar dia de Nacimiento";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 42);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 1;
            label1.Text = "Dia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 66);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 2;
            label2.Text = "Mes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 92);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 5;
            label3.Text = "Año";
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(127, 89);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(100, 23);
            txtAnio.TabIndex = 4;
            // 
            // txtMes
            // 
            txtMes.Location = new Point(127, 63);
            txtMes.Name = "txtMes";
            txtMes.Size = new Size(100, 23);
            txtMes.TabIndex = 5;
            // 
            // txtDia
            // 
            txtDia.Location = new Point(127, 39);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(100, 23);
            txtDia.TabIndex = 6;
            // 
            // lblDiaSemana
            // 
            lblDiaSemana.AutoSize = true;
            lblDiaSemana.Location = new Point(53, 231);
            lblDiaSemana.Name = "lblDiaSemana";
            lblDiaSemana.Size = new Size(124, 15);
            lblDiaSemana.TabIndex = 7;
            lblDiaSemana.Text = "El dia de la semana es ";
            // 
            // Form03DiaNacimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 276);
            Controls.Add(lblDiaSemana);
            Controls.Add(txtDia);
            Controls.Add(txtMes);
            Controls.Add(txtAnio);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnMostrar);
            Name = "Form03DiaNacimiento";
            Text = "Form03DiaNacimiento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMostrar;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtAnio;
        private TextBox txtMes;
        private TextBox txtDia;
        private Label lblDiaSemana;
    }
}