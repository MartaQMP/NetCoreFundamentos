using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form19TablaMultiplicar : Form
    {
        List<Button> botones;
        List<TextBox> textos;
        public Form19TablaMultiplicar()
        {
            InitializeComponent();
            botones = new List<Button>();
            textos = new List<TextBox>();
            foreach (Control btn in this.Controls)
            {
                if (btn is Button)
                {
                    this.botones.Add((Button)btn);
                    btn.Click += MultiplicarNumero;
                }

            }
            foreach (Control txt in this.Controls)
            {
                if (txt is TextBox)
                {
                    this.textos.Add((TextBox)txt);
                }
            }
        }

        private void MultiplicarNumero(object? sender, EventArgs e)
        {
            for (int i = 0; i < this.textos.Count; i++)
            {
                int numero = (int.Parse(((Button)sender).Text));
                this.textos[i].Text = ((i+1) * numero).ToString();
            }
        }
    }
}
