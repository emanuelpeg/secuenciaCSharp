using System;

namespace dotNetSecuencia.model
{
    public class Juego
    {
        private int puntaje = 0;
        private Secuencia secuencia = null;

        public Juego() 
        {
            this.generarSecuencia();
        }

        public int Nro1 {
            get {
                return this.secuencia.Nro[0];
            }
        }

        public int Nro2 {
            get {
                return this.secuencia.Nro[1];
            }
        }

        public int Nro4 {
            get {
                return this.secuencia.Nro[3];
            }
        }

        public int Puntaje {
            get {
                return this.puntaje;
            }
        }

        public void generarSecuencia() 
        {
            int semilla = new Random ().Next (3);
            switch (semilla)
            {
                case 0 :
                    this.secuencia = new SecuenciaPar(); 
                break;
                case 1 :
                    this.secuencia = new SecuenciaImpar(); 
                break;
                default:
                    this.secuencia = new SecuenciaFibonacci();
                break;
            }
        }

        public bool isOk(int valor) {
            bool result = false;
            if (this.secuencia.Nro[2] == valor) {
                this.puntaje++;
                result = true;
            } else {
                this.puntaje--;
            }
            this.generarSecuencia();
            return result;
        }
    }

}