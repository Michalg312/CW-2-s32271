namespace abpdcw2;

public class KontenerNaGaz:Kontener,IHazardNotifier
{
    private double cisnienie;
    public KontenerNaGaz(double masaLadunku, double wyskosc, double masaWlasna, double glebokosc, double maxLadownosc, string typKontenera, Id id,double cisnienie) : base(masaLadunku, wyskosc, masaWlasna, glebokosc, maxLadownosc, typKontenera, id)
    {
        this.cisnienie = cisnienie;
    }

    public void NotifyHazard(string containerId)
    {
        Console.WriteLine($"znaleziono niebezpieczenstwo w {containerId}.");
    }
       
    public void oproznienieLadunku()
    {
        this.MasaLadunku = this.MasaLadunku*0.05;
    }
    public void zaladujKontener(int masa)
    {
        
        if (masa > this.MaxLadownosc)
        {
            throw new InvalidOperationException("probojesz zaladowac wiecej niz mozna");
        }
        this.MasaLadunku = masa;
        
    }
}