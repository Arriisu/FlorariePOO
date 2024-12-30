namespace proiectPOO;

public class Utilizator
{
    protected String CodUnic;
    protected String Nume;
    protected String Prenume;
    protected String Email;
    protected String Parola;
    protected bool Logat;

    public Utilizator(String CodUnic, String Nume, String Prenume, String Email, String Parola)
    {
        this.CodUnic = CodUnic;
        this.Nume = Nume;
        this.Prenume = Prenume;
        this.Email = Email;
        this.Parola = Parola;
        this.Logat = false;
    }

    public String ToString()
    {
        return CodUnic + " " + Nume + " " + Prenume + " " + Email + " " + Parola;
    }
}