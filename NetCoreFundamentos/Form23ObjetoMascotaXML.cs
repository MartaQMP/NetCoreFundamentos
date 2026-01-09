using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace NetCoreFundamentos
{
    public partial class Form23ObjetoMascotaXML : Form
    {
        XmlSerializer serializer;

        public Form23ObjetoMascotaXML()
        {
            InitializeComponent();
            this.serializer = new XmlSerializer(typeof(Mascota));
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            using (StreamReader reader = new StreamReader("mascota.xml"))
            {
                mascota = (Mascota)this.serializer.Deserialize(reader);
                reader.Close();
                this.txtNombre.Text = mascota.Nombre;
                this.txtRaza.Text = mascota.Raza;
                this.txtEdad.Text = mascota.Edad.ToString();
                this.SerializarImagenLeer(mascota.Imagen);
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza = this.txtRaza.Text;
            mascota.Edad = int.Parse(this.txtEdad.Text);
            mascota.Imagen = this.SerializarImagenGuardar();

            /* 
             * LAS CLASES QUE SE UTILIZAN SON DE TIPO STREAM 
             * PARA ESCRIBIR NECESITAMOS LA CLASE StreamWriter
             */
            using (StreamWriter writer = new StreamWriter("mascota.xml"))
            {
                this.serializer.Serialize(writer, mascota);
                await writer.FlushAsync();
                writer.Close();
            }
            this.txtEdad.Text = "";
            this.txtRaza.Text = "";
            this.txtNombre.Text = "";
            this.pictureBox1.Image = null;
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            string ruta = this.openFileDialog1.FileName;
            this.pictureBox1.Image = Image.FromFile(ruta);
        }

        private string SerializarImagenGuardar()
        {

            using (MemoryStream ms = new MemoryStream())
            {
                Image image = this.pictureBox1.Image;
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                byte[] imageBytes = ms.ToArray();
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }

        }

        private void SerializarImagenLeer(string base64String)
        {
            byte[] imageBytesFromBase64 = Convert.FromBase64String(base64String);
            MemoryStream msFromBase64 = new MemoryStream(imageBytesFromBase64);
            Image imageFromBase64 = Image.FromStream(msFromBase64);
            pictureBox1.Image = imageFromBase64;

        }


    }
}
