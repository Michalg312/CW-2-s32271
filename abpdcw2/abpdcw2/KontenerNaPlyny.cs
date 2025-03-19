namespace abpdcw2;

public class KontenerNaPlyny:Kontener,IHazardNotifier
{
    private bool isHazardous;
    public KontenerNaPlyny(double masaLadunku, double wyskosc, double masaWlasna, double glebokosc, double maxLadownosc, string typKontenera,Id id, bool isHazardous) : base(masaLadunku, wyskosc, masaWlasna, glebokosc,  maxLadownosc, typKontenera,id)
    {
        this.isHazardous = isHazardous; 
    }
    
    public void zaladujKontener(int masa)
    {
        
        if (isHazardous == true)
        {
            if (masa >= this.MaxLadownosc * 0.5)
            {
                Console.WriteLine("ladujemy wiecej niz polowe konternera uwaga!!11");
            }
 
        }
        else
        {
            if (masa >= this.MaxLadownosc * 0.9)
            {
                Console.WriteLine("ladujemy wiecej niz 90% konternera uwaga!!11");
            }
        }
        if (masa > this.MaxLadownosc)
        {
            throw new InvalidOperationException("Attempting to load more than allowed capacity");
        }
        this.MasaLadunku = masa;
        
    }
 

    public void NotifyHazard(string containerId)
    {
        Console.WriteLine($"Hazard detected in container {containerId}.");
    }
}