using System;
namespace dotNetSecuencia.model
{
    public abstract class Secuencia
    {
        protected int[] nros = new int[4];

        public Secuencia() {
            this.generar();
        }

        public int[] Nro {
            get {
                return nros;
            }
        }
        
        public abstract void generar();
    }
}