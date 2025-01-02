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
}
