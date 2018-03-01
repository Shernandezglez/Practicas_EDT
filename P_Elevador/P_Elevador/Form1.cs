using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_Elevador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       


        private void btnPisoUno_Click(object sender, EventArgs e)
        {
            Elevador p1 = new Elevador(6);

            p1.irAPiso(1);
            txtInfo.Text = "Piso: " + p1.getPisoActual;
            
            
        }

        private void btnPisoDos_Click(object sender, EventArgs e)
        {
            Elevador p2 = new Elevador(6);

            if (p2.getEstadoPuerta == false)
            {
                p2.irAPiso(2);
                txtInfo.Text = "Piso: " + p2.getPisoActual;
            }
            else if(p2.getPisoActual == 2)
            {
                txtInfo.Text = "Ya estas en este piso";
            }

        }

        private void btnPisoTres_Click(object sender, EventArgs e)
        {
            Elevador p3 = new Elevador(6);

            if (p3.getPisoActual == 3)
            {
                txtInfo.Text = "Ya estas en este piso";
            }
            else
            {
                p3.irAPiso(3);
                txtInfo.Text = "Piso: " + p3.getPisoActual;
            }
        }

        private void btnPisoCuatro_Click(object sender, EventArgs e)
        {
            Elevador p4 = new Elevador(6);

            if (p4.getPisoActual == 4)
            {
                txtInfo.Text = "Ya estas en este piso";
            }
            else
            {
                p4.irAPiso(4);
                txtInfo.Text = "Piso: " + p4.getPisoActual;
            }

        }

        private void btnPisoCinco_Click(object sender, EventArgs e)
        {
            Elevador p5 = new Elevador(6);

            if (p5.getPisoActual == 5)
            {
                txtInfo.Text = "Ya estas en este piso";
            }
            else
            {
                p5.irAPiso(5);
                txtInfo.Text = "Piso: " + p5.getPisoActual;
            }
        }

        private void btnPisoSeis_Click(object sender, EventArgs e)
        {
            Elevador p6 = new Elevador(6);

            if (p6.getPisoActual == 6)
            {
                txtInfo.Text = "Ya estas en este piso";
            }
            else
            {
                p6.irAPiso(6);
                txtInfo.Text = "Piso: " + p6.getPisoActual;
            }

        }

       

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            Elevador ap = new Elevador(6);
            ap.abrirPuerta();
           // ap.setEstadoDePuerta = true;
           if(ap.getEstadoPuerta == true)
            {
                txtInfo.Text += ("Puerta abierta" + Environment.NewLine);
            }
            else
            {
                txtInfo.Text = "La puerta aun no se abre";
            }
           
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            
            Elevador cp = new Elevador(6);
            cp.cerrarPuerta();
            
           
            if (cp.getEstadoPuerta == false)
            {  
                txtInfo.Text += ("Puerta: Cerrada"  + Environment.NewLine);
               
            }
            else
            {
                txtInfo.Text = "La perta aun no se cierrra";
            }
            


        }
    }
}
