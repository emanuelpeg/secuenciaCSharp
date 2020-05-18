using System;

namespace dotNetSecuencia.model
{
    public class SecuenciaFibonacci : Secuencia
    {
        public override void generar() {
            int until = new Random ().Next (15);
            this.nros[0] = 0;
            this.nros[1] = 1;
            this.nros[2] = 1;
            this.nros[3] = 2;
            for (int i = 0; i<until; i++) {
                 this.nros[0] = this.nros[1];
                 this.nros[1] = this.nros[2];
                 this.nros[2] = this.nros[3];
                 this.nros[3] = this.nros[1] + this.nros[2];
            }
        }
    }
}