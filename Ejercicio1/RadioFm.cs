namespace Ejercicio1
{
    public class RadioFm : RadioFrecuency
    {
        public RadioFm()
        {
            BandWith = 20;
            MinFrecuency = 88.1;
            MaxFrecuency = 108.1;
            MaxFrecuencyAvailable = 100;
            Format = "{0:0.0}";
        }
    }
}
