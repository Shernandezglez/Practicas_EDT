using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1_EDT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    private void btnCalcular_Click_1(object sender, EventArgs e)
        {
           

            getBits();
            


        }

        public void getBits()
        {
            Int32 sn1 = 1;
            Int32 sn2 = 1;
            Int32 nivel = 3;
            Int32 dir = 7;
            Int32 dia = 31;
            Int32 mes = 15;
            Int32 year = 127;
            

            int input = Convert.ToInt32(txtNumero.Text);

            input >>= 1;

            dir = (byte)(input & dir);
            input = input >> 3;

            nivel = (byte)(input & nivel);
            input = input >> 2;

            sn1 = (byte)(input & sn1);
            input = input >> 1;

            sn2 = (byte)(input & sn2);
            input = input >> 1;

            dia = (byte)(input & dia);
            input = input >> 5;

            mes = (byte)(input & mes);
            input = input >> 4;

            year = (byte)(input & year);
            input = year + 1900;



            mostrarRes(dir, nivel, sn1, sn2);
            showFecha(dia, mes, year + 1900);
            
        }

        public void mostrarRes(int d, int niv, int s1, int s2)
        {
            switch (d)
            {
                case 0:
                        txtDirecciones.Text = "N";
                    break;
                case 1:
                        txtDirecciones.Text = "NE";
                    break;
                case 2:
                        txtDirecciones.Text = "E";
                    break;
                case 3:
                        txtDirecciones.Text = "SE";
                    break;
                case 4:
                        txtDirecciones.Text = "S";
                    break;
                case 5:
                        txtDirecciones.Text = "SO";
                    break;
                case 6:
                        txtDirecciones.Text = "O";
                    break;
                case 7:
                        txtDirecciones.Text = "NO";
                    break;
            }

            switch (niv)
            {
                case 0:
                    txtNivDeTanque.Text = "Vacio";
                    break;

                case 1:
                    txtNivDeTanque.Text = "Nivel medio";
                    break;

                case 2:
                    txtNivDeTanque.Text = "lleno";
                    break;

                case 3:
                    txtNivDeTanque.Text = "Proceso de llenado";
                    break;
            }

            if (s1 == 1)
                txtSensorUno.Text = "Encendido";
            else
                txtSensorUno.Text = "Apagado";

            if (s2 == 1)
                txtSensor2.Text = "Encendido";
            else
                txtSensor2.Text = "Apagado";
        }


        public void showFecha(int day, int ms, int yr)
        {
            lblFecha.Text = day + " / " + ms + " / " + yr;
        }


        public int sacarValorFecha(int tag, int monat, int jahr)
        {
            int dat = 0;
            jahr -= 1900;

            dat = (byte)(tag);
            monat >>= 4;

            dat = dat | monat;
            jahr <<= 9;
            dat = dat | jahr;

            return dat;
        }

        private void dtpFechas_ValueChanged(object sender, EventArgs e)
        {
            int dd = dtpFechas.Value.Day;
            int mm = dtpFechas.Value.Month;
            int yy = dtpFechas.Value.Year;

            txtFechaFinal.Text = Convert.ToString(sacarValorFecha(dd, mm, yy));
        }
    }
}
