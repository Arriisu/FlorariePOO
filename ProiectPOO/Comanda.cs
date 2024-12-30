namespace proiectPOO;

enum StatusComanda
{
    InPreluare,
    AsteptareMaterie,
    InLucru,
    Finalizat,
    Revendicat
}

public class Comanda
{
    private String NumeDestinatar;
    private int AWB;
    private String NumarTelefon;
    private String Descriere;
    private StatusComanda Status;
    private static int count = 1;

    public Comanda(String numeDestinatar, String numarTelefon, String descriere)
    {
        this.NumeDestinatar = numeDestinatar;
        this.AWB = count++;
        this.NumarTelefon = numarTelefon;
        this.Descriere = descriere;
        this.Status = StatusComanda.InPreluare;
    }

    public String ToString()
    {
        return NumeDestinatar + " " + AWB + " " + NumarTelefon + " " + Descriere + " " + Status;
    }
}