using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Elevador
{
    class Elevador
    {
        private int _pisosTotales;
        private int _pisoActual;
        private bool _estadoDePuerta;
        
        public Elevador(int pisosTotales)
        {
            _pisosTotales = pisosTotales;
            _pisoActual = 1;
            _estadoDePuerta = true;
            
        }

        public void abrirPuerta()
        {
            if (_estadoDePuerta == false)
            {
                _estadoDePuerta = true;
            }
            else
            {
                _estadoDePuerta = false;
            }

        }

        public void cerrarPuerta()
        {
            if(_estadoDePuerta == true)
            {
                _estadoDePuerta = false;
            }
            
        }

        public void irAPiso(int pisoDestino)
        {
            do
            {

            } while (_pisoActual == pisoDestino);
        }

        private void subirPiso()
        {
            if(_pisoActual == 1 && _estadoDePuerta == true)
            {
                _pisoActual++;
            }
            else
            {
                bajarPiso();
            }
        }

        private void bajarPiso()
        {
            if(_pisoActual >=2 || _pisoActual <=6 && _estadoDePuerta == false)
            {
                _pisoActual--;
            }
            else
            {
                subirPiso();
            }
        }

        public int getPisoActual
        {
            get { return _pisoActual; }
        }

        public int getTotal
        {
            get { return _pisosTotales; }
        }

        public bool getEstadoPuerta
        {
            get { return _estadoDePuerta; }
        }

        

    }
}
