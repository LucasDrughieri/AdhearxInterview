using System;
using System.Collections.Generic;

namespace Ejercicio1
{
    public abstract class RadioFrecuency
    {
        public double BandWith { get; set; }

        public double MinFrecuency { get; set; }

        public double MaxFrecuency { get; set; }

        public int MaxFrecuencyAvailable { get; set; }

        public string Format { get; set; }

        public virtual List<string> GetRandomStations(int quantity)
        {
            ThrowExceptionIfQuantityInvalid(quantity);

            var step = BandWith / quantity;

            var result = new List<string>();

            for (double i = MinFrecuency; i < MaxFrecuency; i+= step)
            {
                result.Add(String.Format(Format, i));
            }

            return result;
        }

        private void ThrowExceptionIfQuantityInvalid(int quantity)
        {
            if (quantity > MaxFrecuencyAvailable) throw new Exception("La cantidad solicitada excede el maximo de frecuencias disponibles");
        }
    }
}
