namespace proiectPOO;

public class ManagementUtilizatori
{
    private Dictionary<String, String> Utilizatori = new Dictionary<string, string>();

    public Dictionary<String, String> returneazaUtilizatori()
    {
        return Utilizatori;
    }
    
    public void citireUtilizatori()
    {
        try
        {
            using StreamReader reader = new("../../../utilizatori.txt");
            
            string ln;

            while ((ln = reader.ReadLine()) != null) {
                // Console.WriteLine(ln);
                String[] splited = ln.Split(" ");
                Utilizatori.Add(splited[0], splited[1]);
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }
    }

    public void adaugareUtilizator(Utilizator u)
    {
        Utilizatori.Add(u.getEmail(), u.getParola());
        using (StreamWriter writer = new StreamWriter("../../../utilizatori.txt"))
        {
            foreach (KeyValuePair<string, string> kvp in Utilizatori)
            {
                writer.WriteLine(kvp.Key + " " + kvp.Value);
            }
        }
    }
}