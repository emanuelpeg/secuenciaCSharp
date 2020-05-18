using System;

namespace dotNetSecuencia.model
{
    public class SecuenciaPar : Secuencia
    {        
        public override void generar() {
            int semilla = new Random ().Next (99) * 2;
            for (int i = 0; i<4; i++) {
                this.nros[i] = (semilla + i * 2); 
            }
        }
    }
}