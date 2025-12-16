namespace NetCoreFundamentos
{
    partial class Form13TiendaProductos
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
            btnNuevo = new Button();
            btnEliminar = new Button();
            btnBorrar = new Button();
            btnSeleccion = new Button();
            btnTodos = new Button();
            btnSubir = new Button();
            btnBajar = new Button();
            lstTienda = new ListBox();
            lstAlmacen = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNuevo = new TextBox();
            SuspendLayout();
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(25, 109);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(106, 30);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(25, 145);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(106, 30);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(25, 181);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(106, 30);
            btnBorrar.TabIndex = 2;
            btnBorrar.Text = "Borrar Todo";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnSeleccion
            // 
            btnSeleccion.Location = new Point(404, 124);
            btnSeleccion.Name = "btnSeleccion";
            btnSeleccion.Size = new Size(95, 32);
            btnSeleccion.TabIndex = 3;
            btnSeleccion.Text = "Seleccion";
            btnSeleccion.UseVisualStyleBackColor = true;
            btnSeleccion.Click += btnSeleccion_Click;
            // 
            // btnTodos
            // 
            btnTodos.Location = new Point(404, 162);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(95, 31);
            btnTodos.TabIndex = 4;
            btnTodos.Text = "Todos";
            btnTodos.UseVisualStyleBackColor = true;
            btnTodos.Click += btnTodos_Click;
            // 
            // btnSubir
            // 
            btnSubir.Location = new Point(708, 124);
            btnSubir.Name = "btnSubir";
            btnSubir.Size = new Size(75, 32);
            btnSubir.TabIndex = 5;
            btnSubir.Text = "Subir";
            btnSubir.UseVisualStyleBackColor = true;
            btnSubir.Click += btnSubir_Click;
            // 
            // btnBajar
            // 
            btnBajar.Location = new Point(708, 162);
            btnBajar.Name = "btnBajar";
            btnBajar.Size = new Size(75, 31);
            btnBajar.TabIndex = 6;
            btnBajar.Text = "Bajar";
            btnBajar.UseVisualStyleBackColor = true;
            btnBajar.Click += btnBajar_Click;
            // 
            // lstTienda
            // 
            lstTienda.FormattingEnabled = true;
            lstTienda.Location = new Point(176, 51);
            lstTienda.Name = "lstTienda";
            lstTienda.Size = new Size(168, 214);
            lstTienda.TabIndex = 7;
            // 
            // lstAlmacen
            // 
            lstAlmacen.FormattingEnabled = true;
            lstAlmacen.Location = new Point(522, 51);
            lstAlmacen.Name = "lstAlmacen";
            lstAlmacen.Size = new Size(168, 214);
            lstAlmacen.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(176, 18);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 9;
            label1.Text = "Tienda";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(522, 18);
            label2.Name = "label2";
            label2.Size = new Size(70, 21);
            label2.TabIndex = 10;
            label2.Text = "Almacen";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 31);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 11;
            label3.Text = "Producto";
            label3.Click += label3_Click;
            // 
            // txtNuevo
            // 
            txtNuevo.Location = new Point(25, 64);
            txtNuevo.Name = "txtNuevo";
            txtNuevo.Size = new Size(106, 29);
            txtNuevo.TabIndex = 12;
            // 
            // Form13TiendaProductos
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 291);
            Controls.Add(txtNuevo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstAlmacen);
            Controls.Add(lstTienda);
            Controls.Add(btnBajar);
            Controls.Add(btnSubir);
            Controls.Add(btnTodos);
            Controls.Add(btnSeleccion);
            Controls.Add(btnBorrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnNuevo);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form13TiendaProductos";
            Text = "Form13TiendaProductos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNuevo;
        private Button btnEliminar;
        private Button btnBorrar;
        private Button btnSeleccion;
        private Button btnTodos;
        private Button btnSubir;
        private Button btnBajar;
        private ListBox lstTienda;
        private ListBox lstAlmacen;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNuevo;
    }
}