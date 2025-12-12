namespace NetCoreFundamentos
{
    partial class Form02ColoresPosicion
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
            txtEjeX = new TextBox();
            txtEjeY = new TextBox();
            txtRojo = new TextBox();
            txtVerde = new TextBox();
            txtAzul = new TextBox();
            btnPosicion = new Button();
            btnColor = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtEjeX
            // 
            txtEjeX.Location = new Point(47, 61);
            txtEjeX.Name = "txtEjeX";
            txtEjeX.Size = new Size(100, 23);
            txtEjeX.TabIndex = 0;
            txtEjeX.TextChanged += textBox1_TextChanged;
            // 
            // txtEjeY
            // 
            txtEjeY.Location = new Point(47, 120);
            txtEjeY.Name = "txtEjeY";
            txtEjeY.Size = new Size(100, 23);
            txtEjeY.TabIndex = 1;
            // 
            // txtRojo
            // 
            txtRojo.Location = new Point(612, 61);
            txtRojo.Name = "txtRojo";
            txtRojo.Size = new Size(100, 23);
            txtRojo.TabIndex = 2;
            // 
            // txtVerde
            // 
            txtVerde.Location = new Point(612, 120);
            txtVerde.Name = "txtVerde";
            txtVerde.Size = new Size(100, 23);
            txtVerde.TabIndex = 3;
            // 
            // txtAzul
            // 
            txtAzul.Location = new Point(612, 173);
            txtAzul.Name = "txtAzul";
            txtAzul.Size = new Size(100, 23);
            txtAzul.TabIndex = 4;
            // 
            // btnPosicion
            // 
            btnPosicion.Location = new Point(47, 164);
            btnPosicion.Name = "btnPosicion";
            btnPosicion.Size = new Size(100, 39);
            btnPosicion.TabIndex = 5;
            btnPosicion.Text = "Cambiar Posicion";
            btnPosicion.UseVisualStyleBackColor = true;
            btnPosicion.Click += btnPosicion_Click;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(612, 228);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(100, 23);
            btnColor.TabIndex = 6;
            btnColor.Text = "Cambiar Color";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 102);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 7;
            label1.Text = "Eje Y";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 43);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 8;
            label2.Text = "Eje X";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(615, 47);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 9;
            label3.Text = "Rojo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(615, 102);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 10;
            label4.Text = "Verde";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(615, 155);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 11;
            label5.Text = "Azul";
            // 
            // Form02ColoresPosicion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnColor);
            Controls.Add(btnPosicion);
            Controls.Add(txtAzul);
            Controls.Add(txtVerde);
            Controls.Add(txtRojo);
            Controls.Add(txtEjeY);
            Controls.Add(txtEjeX);
            Name = "Form02ColoresPosicion";
            Text = "Form02ColoresPosicion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEjeX;
        private TextBox txtEjeY;
        private TextBox txtRojo;
        private TextBox txtVerde;
        private TextBox txtAzul;
        private Button btnPosicion;
        private Button btnColor;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}