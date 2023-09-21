namespace BankSoftware_API
{
    public class Konto
    {
        public required string KontoNummer { get; set; }
        public required string KontoInhaber { get; set; }
        public double Kontostand { get; set; } = 0;
        public double Dispo { get; set; } = 0;
        public double Zinssatz { get; set; } = 0;
        public bool IstAktiv { get; set; } = true;
        public KontoTypen KontoTyp { get; set; } = KontoTypen.Girokonto;

    }
    public enum KontoTypen
    {
        Girokonto = 1,
        Sparkonto = 2,
        Festgeldkonto = 3
    }
}