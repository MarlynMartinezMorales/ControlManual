using System;
using System.Collections.Generic;
using System.Text;

namespace ControladorManual.Model
{
    public class Contador
    {
        private int _Conteo;
        public int Conteo
        {
            get => _Conteo;
            set
            {
                if(_Conteo != value)
                {
                    _Conteo = value;
                }
            }
        }

        public Contador()
        {
            ReiniciarConteo();
        }
        public void Contar()
        {
            Conteo++;
        }
        public void ReiniciarConteo()
        {
            Conteo = 0;
        }
    }
}
