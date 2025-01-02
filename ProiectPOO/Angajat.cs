namespace proiectPOO;

public class Angajat : Utilizator
{
    private Florarie Florarie;
    
    public Angajat(String CodUnic, String Nume, String Prenume, String Email, String Parola, Florarie Florarie) : base(CodUnic, Nume,
        Prenume, Email, Parola)
    {
        this.Florarie = Florarie;
    }

    public void VizualizeazaComenzi()
    {
       Console.WriteLine("Comenzile clientilor: ");
       Florarie.afiseazaComenzi();
    }

    public void PreluareComandaBuchet (int id)
    {
       var comanda = Florarie.GetComandaId(id);
       if (comanda != null && comanda.Status == StatusComanda.AsteptareMaterie )
       {
          comanda.Status = Status.InLucru;
          Console.WriteLine($"Comanda cu id-ul {id} a fost preluata si este in lucru.");
       }
       else
       {
          Console.WriteLine("Comanda nu poate fi preluata.");
       }
    }

    public void FinalizeazaComandaBuchet(int id)
    {
       var comanda = Florarie.GetComandaId(id);
       if (comanda != null && comanda.Status == StatusComanda.InLucru)
       {  
          comanda.Status = Status.Finalizat;
          Console.WriteLine($"Comanda cu id-ul {id} a fost finalizata.");
       }
       else
       {
          Console.WriteLine("Comanda nu poate fi finalizata.");
       }
    }
          
}
