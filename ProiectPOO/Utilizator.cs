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
    
    public String getEmail()
    {
        return this.Email;
    }
    
    public String getParola()
    {
        return this.Parola;
    }
    
    public void Login(ManagementUtilizatori mu)
    {
        Dictionary<String, String> utilizatori = mu.returneazaUtilizatori();
        foreach (KeyValuePair<string, string> kvp in utilizatori)
        {
            if (this.Email == kvp.Key && this.Parola == kvp.Value)
            {
                this.Logat = true;
                Console.WriteLine("Logat cu succes");
            }
        }
        if (this.Logat == false)
            Console.WriteLine("Logat fara succes");
    }

    public void Logout()
    {
        Console.WriteLine("Delogat cu succes");
        this.Logat = false;
    }
}