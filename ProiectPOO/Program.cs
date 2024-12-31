using proiectPOO;

Utilizator u1 = new Client("U001", "Vucu", "Aris", "aris.vucu@student.upt.ro", "1234");
//Console.WriteLine(u1.ToString());

ManagementUtilizatori mu = new ManagementUtilizatori();
mu.citireUtilizatori();
Dictionary<String, String> utilizatori = mu.returneazaUtilizatori();
foreach (KeyValuePair<string, string> kvp in utilizatori)
{
    Console.WriteLine("Email = {0}, Parola = {1}", kvp.Key, kvp.Value);
}

Florarie f = new Florarie("Trandafiru");
Angajat u3 = new Angajat("U003", "Malmare", "Ari", "ari.malmare@student.upt.ro", "0987", f);
Client u4 = new Client("U004", "Vucu", "Aris", "aris.vucu@student.upt.ro", "1234");
mu.adaugareUtilizator(u3);
Console.WriteLine("Noile valori:");
utilizatori = mu.returneazaUtilizatori();
foreach (KeyValuePair<string, string> kvp in utilizatori)
{
    Console.WriteLine("Email = {0}, Parola = {1}", kvp.Key, kvp.Value);
}
u4.Login(mu);
u4.Logout();

u4.comandaBuchet(f, "Miriam", "+40724123456", "un buchet de trandafiri");
u4.comandaBuchet(f, "Miriam", "+40724123456", "inca un buchet");
f.afiseazaComenzi();
