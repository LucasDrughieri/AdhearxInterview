using System;

namespace Ejercicio1
{
    public static class RadioFrecuencyFactory
    {
        public static RadioFrecuency GetInstance(BandTypes bandType)
        {
            switch (bandType)
            {
                case BandTypes.AM: return new RadioAm();
                case BandTypes.FM: return new RadioFm();
                default: throw new Exception("El tipo de banda no esta disponible");
            }
        }
    }
}
