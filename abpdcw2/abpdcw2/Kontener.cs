namespace abpdcw2;

public abstract class Kontener 
{
    private string typKontenera;
    private double masaLadunku { get; set; }
    private double wyskosc { get; set; }
    private double masaWlasna { get; set; }
    private double glebokosc { get; set; }
    private string nrSer { get; set; }
    private double maxLadownosc { get; set; }
   

    public Kontener(double masaLadunku, double wyskosc, double masaWlasna, double glebokosc, double maxLadownosc, string typKontenera,
        Id id)
    {
        this.masaLadunku = masaLadunku;
        this.wyskosc = wyskosc;
        this.masaWlasna = masaWlasna;
        this.glebokosc = glebokosc;
        this.maxLadownosc = maxLadownosc;
        this.typKontenera = typKontenera;
        this.nrSer = generujNumerSer(id);
    }

    private string generujNumerSer(Id id)
    {
       
        string nrSer = "KON-"+this.typKontenera+"-"+ id.IdValue;
        id.Increment();
        return nrSer; 
    }
    
    public void oproznienieLadunku()
    {
        masaLadunku = 0;
    }

    public void zaladujKontener(int masa)
    {
        
        if (masa > maxLadownosc)
        {
            throw new InvalidOperationException("Attempting to load more than allowed capacity.");
        }
        this.masaLadunku = masa;

     
    }


    public string TypKontenera
    {
        get { return typKontenera; }
        set { typKontenera = value; }
    }

    public double MasaLadunku
    {
        get { return masaLadunku; }
        set { masaLadunku = value; }
    }

    public double Wyskosc
    {
        get { return wyskosc; }
        set { wyskosc = value; }
    }

    public double MasaWlasna
    {
        get { return masaWlasna; }
        set { masaWlasna = value; }
    }

    public double Glebokosc
    {
        get { return glebokosc; }
        set { glebokosc = value; }
    }

    public string NrSer
    {
        get { return nrSer; }
        set { nrSer = value; }
    }

    public double MaxLadownosc
    {
        get { return maxLadownosc; }
        set { maxLadownosc = value; }
    }

    public virtual void wypisz()
    {
        Console.WriteLine("===========================================\nDane kontenera");
        Console.WriteLine($"Typ kontenera: {typKontenera}");
        Console.WriteLine($"Masa ładunku: {masaLadunku} kg");
        Console.WriteLine($"Wysokość: {wyskosc} cm");
        Console.WriteLine($"Masa własna: {masaWlasna} kg");
        Console.WriteLine($"Głębokość: {glebokosc} cm");
        Console.WriteLine($"Numer seryjny: {nrSer}");
        Console.WriteLine($"Maksymalna ładowność: {maxLadownosc} kg");
    }
}