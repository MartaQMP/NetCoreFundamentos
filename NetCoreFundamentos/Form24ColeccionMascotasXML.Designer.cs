namespace NetCoreFundamentos
{
    partial class Form24ColeccionMascotasXML
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
            btnGuardar = new Button();
            btnLeer = new Button();
            txtEdad = new TextBox();
            label3 = new Label();
            txtRaza = new TextBox();
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            label4 = new Label();
            lstMascotas = new ListBox();
            btnNueva = new Button();
            openFileDialog1 = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            btnExaminar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(476, 152);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(138, 65);
            btnGuardar.TabIndex = 37;
            btnGuardar.Text = "Guardar Mascotas";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLeer
            // 
            btnLeer.Location = new Point(476, 96);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(138, 39);
            btnLeer.TabIndex = 36;
            btnLeer.Text = "Leer Mascotas";
            btnLeer.UseVisualStyleBackColor = true;
            btnLeer.Click += btnLeer_Click;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(26, 216);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(68, 29);
            txtEdad.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 192);
            label3.Name = "label3";
            label3.Size = new Size(44, 21);
            label3.TabIndex = 34;
            label3.Text = "Edad";
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(26, 138);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(167, 29);
            txtRaza.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 114);
            label1.Name = "label1";
            label1.Size = new Size(43, 21);
            label1.TabIndex = 32;
            label1.Text = "Raza";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(26, 68);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(167, 29);
            txtNombre.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 35);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 30;
            label2.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(220, 35);
            label4.Name = "label4";
            label4.Size = new Size(75, 21);
            label4.TabIndex = 39;
            label4.Text = "Mascotas";
            // 
            // lstMascotas
            // 
            lstMascotas.FormattingEnabled = true;
            lstMascotas.Location = new Point(220, 68);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(197, 256);
            lstMascotas.TabIndex = 38;
            lstMascotas.SelectedIndexChanged += lstMascotas_SelectedIndexChanged;
            // 
            // btnNueva
            // 
            btnNueva.Location = new Point(26, 280);
            btnNueva.Name = "btnNueva";
            btnNueva.Size = new Size(167, 44);
            btnNueva.TabIndex = 40;
            btnNueva.Text = "Nueva Mascota";
            btnNueva.UseVisualStyleBackColor = true;
            btnNueva.Click += btnNueva_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(643, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 192);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // btnExaminar
            // 
            btnExaminar.Location = new Point(476, 231);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(138, 43);
            btnExaminar.TabIndex = 42;
            btnExaminar.Text = "Examinar...";
            btnExaminar.UseVisualStyleBackColor = true;
            btnExaminar.Click += btnExaminar_Click;
            // 
            // Form24ColeccionMascotasXML
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 368);
            Controls.Add(btnExaminar);
            Controls.Add(pictureBox1);
            Controls.Add(btnNueva);
            Controls.Add(label4);
            Controls.Add(lstMascotas);
            Controls.Add(btnGuardar);
            Controls.Add(btnLeer);
            Controls.Add(txtEdad);
            Controls.Add(label3);
            Controls.Add(txtRaza);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form24ColeccionMascotasXML";
            Text = "Form24ColeccionMascotasXML";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Button btnLeer;
        private TextBox txtEdad;
        private Label label3;
        private TextBox txtRaza;
        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private Label label4;
        private ListBox lstMascotas;
        private Button btnNueva;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
        private Button btnExaminar;
    }
}