namespace NetCoreFundamentos
{
    partial class Form23ObjetoMascotaXML
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
            txtRaza = new TextBox();
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtEdad = new TextBox();
            label3 = new Label();
            btnGuardar = new Button();
            btnLeer = new Button();
            btnExaminar = new Button();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(37, 148);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(138, 29);
            txtRaza.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 124);
            label1.Name = "label1";
            label1.Size = new Size(43, 21);
            label1.TabIndex = 22;
            label1.Text = "Raza";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(37, 78);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(138, 29);
            txtNombre.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 45);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 20;
            label2.Text = "Nombre";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(37, 226);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(68, 29);
            txtEdad.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 202);
            label3.Name = "label3";
            label3.Size = new Size(44, 21);
            label3.TabIndex = 26;
            label3.Text = "Edad";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(224, 124);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(138, 39);
            btnGuardar.TabIndex = 29;
            btnGuardar.Text = "Guardar Clase";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLeer
            // 
            btnLeer.Location = new Point(224, 67);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(138, 39);
            btnLeer.TabIndex = 28;
            btnLeer.Text = "Leer Clase";
            btnLeer.UseVisualStyleBackColor = true;
            btnLeer.Click += btnLeer_Click;
            // 
            // btnExaminar
            // 
            btnExaminar.Location = new Point(223, 194);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(138, 43);
            btnExaminar.TabIndex = 44;
            btnExaminar.Text = "Examinar...";
            btnExaminar.UseVisualStyleBackColor = true;
            btnExaminar.Click += btnExaminar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(406, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 192);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form23ObjetoMascotaXML
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 296);
            Controls.Add(btnExaminar);
            Controls.Add(pictureBox1);
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
            Name = "Form23ObjetoMascotaXML";
            Text = "Form23ObjetoMascotaXML";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRaza;
        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtEdad;
        private Label label3;
        private Button btnGuardar;
        private Button btnLeer;
        private Button btnExaminar;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
    }
}