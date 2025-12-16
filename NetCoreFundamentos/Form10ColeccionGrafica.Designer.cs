namespace NetCoreFundamentos
{
    partial class Form10ColeccionGrafica
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
            lstElementos = new ListBox();
            label2 = new Label();
            txtNuevo = new TextBox();
            btnInsertar = new Button();
            btnBorrarTodo = new Button();
            btnEliminar = new Button();
            lblItem = new Label();
            lblIndex = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 23);
            label1.Name = "label1";
            label1.Size = new Size(82, 21);
            label1.TabIndex = 0;
            label1.Text = "Elementos";
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.Location = new Point(28, 66);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(169, 151);
            lstElementos.TabIndex = 1;
            lstElementos.SelectedIndexChanged += lstElementos_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(257, 23);
            label2.Name = "label2";
            label2.Size = new Size(125, 21);
            label2.TabIndex = 2;
            label2.Text = "Nuevo Elemento";
            // 
            // txtNuevo
            // 
            txtNuevo.Location = new Point(257, 66);
            txtNuevo.Name = "txtNuevo";
            txtNuevo.Size = new Size(153, 29);
            txtNuevo.TabIndex = 3;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(257, 109);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(100, 32);
            btnInsertar.TabIndex = 4;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Location = new Point(257, 185);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(100, 32);
            btnBorrarTodo.TabIndex = 5;
            btnBorrarTodo.Text = "Borrar todo";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(257, 147);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 32);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Location = new Point(28, 229);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(48, 21);
            lblItem.TabIndex = 7;
            lblItem.Text = "Item: ";
            // 
            // lblIndex
            // 
            lblIndex.AutoSize = true;
            lblIndex.Location = new Point(28, 264);
            lblIndex.Name = "lblIndex";
            lblIndex.Size = new Size(54, 21);
            lblIndex.TabIndex = 8;
            lblIndex.Text = "Index: ";
            // 
            // Form10ColeccionGrafica
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 312);
            Controls.Add(lblIndex);
            Controls.Add(lblItem);
            Controls.Add(btnEliminar);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnInsertar);
            Controls.Add(txtNuevo);
            Controls.Add(label2);
            Controls.Add(lstElementos);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form10ColeccionGrafica";
            Text = "Form10ColeccionGrafica";
            Load += Form10ColeccionGrafica_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstElementos;
        private Label label2;
        private TextBox txtNuevo;
        private Button btnInsertar;
        private Button btnBorrarTodo;
        private Button btnEliminar;
        private Label lblItem;
        private Label lblIndex;
    }
}