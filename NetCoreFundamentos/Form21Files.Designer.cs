namespace NetCoreFundamentos
{
    partial class Form21Files
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
            label2 = new Label();
            txtContenido = new TextBox();
            txtNombre = new TextBox();
            btnNuevo = new Button();
            btnLeer = new Button();
            btnEscribir = new Button();
            lstNombres = new ListBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 44);
            label1.Name = "label1";
            label1.Size = new Size(110, 21);
            label1.TabIndex = 0;
            label1.Text = "Contenido File";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(320, 44);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // txtContenido
            // 
            txtContenido.Location = new Point(27, 90);
            txtContenido.Multiline = true;
            txtContenido.Name = "txtContenido";
            txtContenido.Size = new Size(254, 218);
            txtContenido.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(320, 90);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(138, 29);
            txtNombre.TabIndex = 3;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(320, 147);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(138, 39);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "Nuevo Nombre";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnLeer
            // 
            btnLeer.Location = new Point(320, 206);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(138, 39);
            btnLeer.TabIndex = 5;
            btnLeer.Text = "Leer File";
            btnLeer.UseVisualStyleBackColor = true;
            btnLeer.Click += btnLeer_Click;
            // 
            // btnEscribir
            // 
            btnEscribir.Location = new Point(320, 269);
            btnEscribir.Name = "btnEscribir";
            btnEscribir.Size = new Size(138, 39);
            btnEscribir.TabIndex = 6;
            btnEscribir.Text = "Escribir File";
            btnEscribir.UseVisualStyleBackColor = true;
            btnEscribir.Click += btnEscribir_Click;
            // 
            // lstNombres
            // 
            lstNombres.FormattingEnabled = true;
            lstNombres.Location = new Point(498, 90);
            lstNombres.Name = "lstNombres";
            lstNombres.Size = new Size(174, 214);
            lstNombres.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(498, 44);
            label3.Name = "label3";
            label3.Size = new Size(75, 21);
            label3.TabIndex = 8;
            label3.Text = "Nombres";
            // 
            // Form21Files
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 327);
            Controls.Add(label3);
            Controls.Add(lstNombres);
            Controls.Add(btnEscribir);
            Controls.Add(btnLeer);
            Controls.Add(btnNuevo);
            Controls.Add(txtNombre);
            Controls.Add(txtContenido);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form21Files";
            Text = "Form21Files";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtContenido;
        private TextBox txtNombre;
        private Button btnNuevo;
        private Button btnLeer;
        private Button btnEscribir;
        private ListBox lstNombres;
        private Label label3;
    }
}