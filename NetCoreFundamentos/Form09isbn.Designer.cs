namespace NetCoreFundamentos
{
    partial class Form09isbn
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
            btnComprobar = new Button();
            label1 = new Label();
            txtCaja = new TextBox();
            lblValido = new Label();
            SuspendLayout();
            // 
            // btnComprobar
            // 
            btnComprobar.Font = new Font("Segoe UI", 12F);
            btnComprobar.Location = new Point(41, 119);
            btnComprobar.Name = "btnComprobar";
            btnComprobar.Size = new Size(120, 34);
            btnComprobar.TabIndex = 0;
            btnComprobar.Text = "Comprobar";
            btnComprobar.UseVisualStyleBackColor = true;
            btnComprobar.Click += btnComprobar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(41, 32);
            label1.Name = "label1";
            label1.Size = new Size(139, 21);
            label1.TabIndex = 1;
            label1.Text = "Introduce un ISBN:";
            // 
            // txtCaja
            // 
            txtCaja.Location = new Point(42, 72);
            txtCaja.Name = "txtCaja";
            txtCaja.Size = new Size(138, 23);
            txtCaja.TabIndex = 2;
            // 
            // lblValido
            // 
            lblValido.AutoSize = true;
            lblValido.Location = new Point(38, 178);
            lblValido.Name = "lblValido";
            lblValido.Size = new Size(64, 15);
            lblValido.TabIndex = 3;
            lblValido.Text = "El ISBN es: ";
            // 
            // Form09isbn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(260, 209);
            Controls.Add(lblValido);
            Controls.Add(txtCaja);
            Controls.Add(label1);
            Controls.Add(btnComprobar);
            Name = "Form09isbn";
            Text = "Form09isbn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnComprobar;
        private Label label1;
        private TextBox txtCaja;
        private Label lblValido;
    }
}