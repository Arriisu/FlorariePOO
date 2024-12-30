namespace proiectPOO;

public class Florarie
{
    private String Nume;
    private List<Comanda> Comenzi = new List<Comanda>();

    public Florarie(String Nume)
    {
        this.Nume = Nume;
    }

    public void adaugaComanda(String numeDestinatar, String numarTelefon, String descriere)
    {
        Comanda c = new Comanda(numeDestinatar, numarTelefon, descriere);
        //Console.WriteLine(c.ToString());
        Comenzi.Add(c);
    }

    public void afiseazaComenzi()
    {
        Console.WriteLine(this.Nume + " are urmatoarele comenzi:");
        foreach (Comanda c in Comenzi)
        {
            Console.WriteLine(c.ToString());
        }
    }
}