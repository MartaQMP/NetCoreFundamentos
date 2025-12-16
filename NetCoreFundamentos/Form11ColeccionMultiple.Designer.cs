namespace NetCoreFundamentos
{
    partial class Form11ColeccionMultiple
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
            lblIndex = new Label();
            lblItem = new Label();
            btnEliminar = new Button();
            btnBorrarTodo = new Button();
            btnInsertar = new Button();
            txtNuevo = new TextBox();
            label2 = new Label();
            lstElementos = new ListBox();
            label1 = new Label();
            btnSeleccionados = new Button();
            SuspendLayout();
            // 
            // lblIndex
            // 
            lblIndex.AutoSize = true;
            lblIndex.Location = new Point(30, 346);
            lblIndex.Margin = new Padding(4, 0, 4, 0);
            lblIndex.Name = "lblIndex";
            lblIndex.Size = new Size(54, 21);
            lblIndex.TabIndex = 17;
            lblIndex.Text = "Index: ";
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Location = new Point(30, 306);
            lblItem.Margin = new Padding(4, 0, 4, 0);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(48, 21);
            lblItem.TabIndex = 16;
            lblItem.Text = "Item: ";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(323, 157);
            btnEliminar.Margin = new Padding(4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(129, 45);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Location = new Point(323, 215);
            btnBorrarTodo.Margin = new Padding(4);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(129, 45);
            btnBorrarTodo.TabIndex = 14;
            btnBorrarTodo.Text = "Borrar todo";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(323, 104);
            btnInsertar.Margin = new Padding(4);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(129, 45);
            btnInsertar.TabIndex = 13;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // txtNuevo
            // 
            txtNuevo.Location = new Point(323, 67);
            txtNuevo.Margin = new Padding(4);
            txtNuevo.Name = "txtNuevo";
            txtNuevo.Size = new Size(196, 29);
            txtNuevo.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(323, 25);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(125, 21);
            label2.TabIndex = 11;
            label2.Text = "Nuevo Elemento";
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.Location = new Point(30, 67);
            lstElementos.Margin = new Padding(4);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(216, 193);
            lstElementos.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 21);
            label1.TabIndex = 9;
            label1.Text = "Elementos";
            // 
            // btnSeleccionados
            // 
            btnSeleccionados.Location = new Point(323, 268);
            btnSeleccionados.Margin = new Padding(4);
            btnSeleccionados.Name = "btnSeleccionados";
            btnSeleccionados.Size = new Size(129, 45);
            btnSeleccionados.TabIndex = 19;
            btnSeleccionados.Text = "Seleccionados";
            btnSeleccionados.UseVisualStyleBackColor = true;
            btnSeleccionados.Click += btnSeleccionados_Click;
            // 
            // Form11ColeccionMultiple
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 405);
            Controls.Add(btnSeleccionados);
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
            Name = "Form11ColeccionMultiple";
            Text = "Form11ColeccionMultiple";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIndex;
        private Label lblItem;
        private Button btnEliminar;
        private Button btnBorrarTodo;
        private Button btnInsertar;
        private TextBox txtNuevo;
        private Label label2;
        private ListBox lstElementos;
        private Label label1;
        private Button btnSeleccionados;
    }
}