using System.ComponentModel;

namespace abpdcw2;

public class Statek
{
    public List<Kontener> Kontenery { get; set; }
    private double maxPredkosc { get; set; }
    private double maxLiczbaKontenerow { get; set; }
    double LiczbaKontenerow { get; set; }
    private double masaKontenerow { get; set; }

    public Statek(double maxPredkosc, double maxLiczbaKontenerow, double masaKontenerow)
    {
        this.maxPredkosc = maxPredkosc;
        this.maxLiczbaKontenerow = masaKontenerow;
        this.masaKontenerow = masaKontenerow;
        this.Kontenery = new List<Kontener>();
    }

    public void zaladujKontener(Kontener kontener)
    {
        if (LiczbaKontenerow >= maxLiczbaKontenerow)
        {
            throw new InvalidOperationException("Cannot load more containers. Max capacity reached.");
        }

        this.Kontenery.Add(kontener);
        LiczbaKontenerow += 1;
    }

    public void wypiszKontenery()
    {
        Console.WriteLine("lista kontenerow:");
        foreach (Kontener kont in Kontenery)
        {
            Console.WriteLine(kont.NrSer);
        }
    }

    public void zdejmijKontener(Kontener kontener)
    {
        Kontenery.Remove(kontener);
    }

    public void zamienKontenery(Kontener kontener1, Kontener kontener2)
    {
        Kontenery.Remove(kontener1);
        Kontenery.Add(kontener2);
    }
    
}