using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form18SumarCheckbox : Form
    {
        List<CheckBox> botones;
        public Form18SumarCheckbox()
        {
            InitializeComponent();
            this.botones = new List<CheckBox>();
            /*RECORREMOS TODOS LOS BOTONES DEL PANEL 
             COMO SOLO HE DIBUJADO BOTONES, HACEMOS LA ABSTRACCION A BUTTON*/
            foreach (CheckBox btn in this.panel1.Controls)
            {
                this.botones.Add(btn);
                btn.CheckedChanged += SumarNumeros; ;
                
            }
        }

        private void SumarNumeros(object? sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            int numero = int.Parse(check.Text);
            int total = int.Parse(this.txtSuma.Text);
            if (check.Checked) 
            {
                total += numero;
            }else
            {
                total -= numero;
            }

                this.txtSuma.Text = total.ToString();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            foreach (CheckBox btn in this.botones)
            {
                int ale = random.Next(1, 50);
                btn.Text = ale.ToString();
            }
        }
    }
}
