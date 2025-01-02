namespace proiectPOO;

public class Florarie
{
    private String Nume;
    private List<Comanda> Comenzi = new List<Comanda>();
    private List<ComandaMaterie> ComenziMaterie = new List<ComandaMaterie>();

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

    public void AdaugaComandaMaterie(int codUnic, string descriere)
    {
        ComenziMaterie.Add(new ComandaMaterie(codUnic, descriere));
        Console.WriteLine("Comanda de materie prima a fost adaugata");
    }

    public void AfiseazaComandaMaterie()
    {
        Console.WriteLine("Comenzi de materie prima:");
        foreach (var comanda in ComenziMaterie)
        {
            Console.WriteLine(comanda.ToString());
        }
    }

    public void FinalizeazaComandaMaterie(int codUnic)
    {
        var comanda = ComenziMaterie.Find(c => codUnic == codUnic)
        try
        {
            if ( comanda != null && comanda.Status == StatusMaterie.InAsteptare )
            {
                comanda.Status = StatusMaterie.Finalizat;
                Console.WriteLine ($"Comanda de materie cu codul {codUnic} a fost finalizata.");
            }
            else
            {
                Console.WriteLine ("Comanda nu poate fi finalizata.");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine ($"Eroare: {e.Message}");
            throw;
        }
    }

    public Comanda GetComandaId(int id)
    {
        return Comenzi.Find(c => c.AWB == id);
    }
        
}
