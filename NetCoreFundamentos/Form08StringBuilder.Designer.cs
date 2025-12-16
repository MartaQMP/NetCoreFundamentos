namespace NetCoreFundamentos
{
    partial class Form08StringBuilder
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
            txtTexto = new RichTextBox();
            lblTiempo = new Label();
            btnString = new Button();
            btnBuilder = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(46, 17);
            label1.Name = "label1";
            label1.Size = new Size(226, 25);
            label1.TabIndex = 0;
            label1.Text = "Copie texto para trabajar:";
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(46, 53);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(461, 199);
            txtTexto.TabIndex = 1;
            txtTexto.Text = "";
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Location = new Point(49, 275);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(120, 15);
            lblTiempo.TabIndex = 2;
            lblTiempo.Text = "Tiempo en realizarse: ";
            // 
            // btnString
            // 
            btnString.BackColor = Color.LightSkyBlue;
            btnString.Font = new Font("Segoe UI", 12F);
            btnString.Location = new Point(76, 300);
            btnString.Name = "btnString";
            btnString.Size = new Size(153, 37);
            btnString.TabIndex = 3;
            btnString.Text = "Invertir string";
            btnString.UseVisualStyleBackColor = false;
            btnString.Click += btnString_Click;
            // 
            // btnBuilder
            // 
            btnBuilder.BackColor = Color.LightSkyBlue;
            btnBuilder.Font = new Font("Segoe UI", 12F);
            btnBuilder.Location = new Point(323, 300);
            btnBuilder.Name = "btnBuilder";
            btnBuilder.Size = new Size(166, 36);
            btnBuilder.TabIndex = 4;
            btnBuilder.Text = "Invertir StringBuilder";
            btnBuilder.UseVisualStyleBackColor = false;
            btnBuilder.Click += btnBuilder_Click;
            // 
            // Form08StringBuilder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 353);
            Controls.Add(btnBuilder);
            Controls.Add(btnString);
            Controls.Add(lblTiempo);
            Controls.Add(txtTexto);
            Controls.Add(label1);
            Name = "Form08StringBuilder";
            Text = "Form08StringBuilder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox txtTexto;
        private Label lblTiempo;
        private Button btnString;
        private Button btnBuilder;
    }
}