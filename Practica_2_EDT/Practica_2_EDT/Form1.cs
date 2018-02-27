using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2_EDT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();

            byte[] bmp = { 0x42, 0x4D };

            dialogo.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            dialogo.Filter = "Imagenes (*.bmp)|";

            dialogo.RestoreDirectory = true;

            

            if (dialogo.ShowDialog() == DialogResult.OK) 
            {
                byte img = Convert.ToByte(dialogo.FileName);
                byte[] file = { img };

                if (file == bmp)
                {
                    txtImg.Text = dialogo.SafeFileName;
                }
            }
            else
            {
                 MessageBox.Show ("Seleccione una imapeg tipo BMP", "Advertencia");
            }
            
            
        }

        /*public byte getBytesOfBitMap()
        {

        }*/
    }
}
