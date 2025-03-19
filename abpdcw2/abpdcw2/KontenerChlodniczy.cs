namespace abpdcw2;

public class KontenerChlodniczy:Kontener
{
    private string rodzajProduktu{ get; set; }
    private double temperatura{ get; set; }

    public KontenerChlodniczy(double masaLadunku, double wyskosc, double masaWlasna, double glebokosc, double maxLadownosc, string typKontenera, Id id, string rodzajProduktu, double temperatura) : base(masaLadunku, wyskosc, masaWlasna, glebokosc, maxLadownosc, typKontenera, id)
    {
        this.rodzajProduktu = rodzajProduktu;
        this.temperatura = temperatura;
    }
    public string RodzajProduktu
    {
        get { return rodzajProduktu; }
        set { rodzajProduktu = value; }
    }
    public double Temperatura
    {
        get { return temperatura; }
        set { temperatura = value; }
    }


}