namespace proiectPOO;

public class Client : Utilizator
{
    public Client(String CodUnic, String Nume, String Prenume, String Email, String Parola) : base(CodUnic, Nume,
        Prenume, Email, Parola)
    {
        
    }

    public void comandaBuchet(Florarie Florarie, String NumeDestinatar, String NumarTelefon, String Descriere)
    {
        Florarie.adaugaComanda(NumeDestinatar, NumarTelefon, Descriere);
    }
}