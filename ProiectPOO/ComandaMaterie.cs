namespace proiectPOO;

enum StatusMaterie
{
    InAsteptare,
    Finalizat
}
public class ComandaMaterie
{
    public int CodUnic { get; private set; }
    public string Descriere { get; private set; }
    public StatusMaterie Status { get; set; }

    public ComandaMaterie(int codUnic, string descriere)
    {
        CodUnic = codUnic;
        Descriere = descriere;
        Status = StatusMaterie.InAsteptare;
    }

    public override string ToString()
    {
        return $"Cod: {CodUnic}, Descriere: {Descriere}, Status: {Status}";
    }
}
