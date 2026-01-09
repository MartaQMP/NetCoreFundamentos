namespace NetCoreFundamentos
{
    partial class Form22MascotasFile
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
            label3 = new Label();
            lstMascotas = new ListBox();
            btnEscribir = new Button();
            btnLeer = new Button();
            btnNuevo = new Button();
            txtNombre = new TextBox();
            label2 = new Label();
            txtRaza = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(203, 27);
            label3.Name = "label3";
            label3.Size = new Size(75, 21);
            label3.TabIndex = 17;
            label3.Text = "Mascotas";
            // 
            // lstMascotas
            // 
            lstMascotas.FormattingEnabled = true;
            lstMascotas.Location = new Point(203, 60);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(197, 277);
            lstMascotas.TabIndex = 16;
            lstMascotas.SelectedIndexChanged += lstMascotas_SelectedIndexChanged;
            // 
            // btnEscribir
            // 
            btnEscribir.Location = new Point(25, 298);
            btnEscribir.Name = "btnEscribir";
            btnEscribir.Size = new Size(138, 39);
            btnEscribir.TabIndex = 15;
            btnEscribir.Text = "Escribir File";
            btnEscribir.UseVisualStyleBackColor = true;
            btnEscribir.Click += btnEscribir_Click;
            // 
            // btnLeer
            // 
            btnLeer.Location = new Point(25, 242);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(138, 39);
            btnLeer.TabIndex = 14;
            btnLeer.Text = "Leer File";
            btnLeer.UseVisualStyleBackColor = true;
            btnLeer.Click += btnLeer_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(25, 185);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(138, 39);
            btnNuevo.TabIndex = 13;
            btnNuevo.Text = "Nueva Mascota";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(25, 60);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(138, 29);
            txtNombre.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 27);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 10;
            label2.Text = "Nombre";
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(25, 130);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(138, 29);
            txtRaza.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 106);
            label1.Name = "label1";
            label1.Size = new Size(43, 21);
            label1.TabIndex = 18;
            label1.Text = "Raza";
            // 
            // Form22MascotasFile
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 386);
            Controls.Add(txtRaza);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(lstMascotas);
            Controls.Add(btnEscribir);
            Controls.Add(btnLeer);
            Controls.Add(btnNuevo);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form22MascotasFile";
            Text = "Form22MascotasFile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private ListBox lstMascotas;
        private Button btnEscribir;
        private Button btnLeer;
        private Button btnNuevo;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtRaza;
        private Label label1;
    }
}