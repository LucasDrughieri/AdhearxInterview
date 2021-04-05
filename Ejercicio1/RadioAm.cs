namespace Ejercicio1
{
    public class RadioAm : RadioFrecuency
    {
        public RadioAm()
        {
            BandWith = 1060;
            MinFrecuency = 540;
            MaxFrecuency = 1600;
            MaxFrecuencyAvailable = 106;
            Format = "{0:0}";
        }
    }
}
