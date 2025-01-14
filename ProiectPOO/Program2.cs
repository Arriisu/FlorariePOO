namespace proiectPOO;

class Program
{
static void Main(string[] args)
{
    Florarie florarie = new Florarie("Floraria Mea");
    bool exit = false;

    while (!exit)
    {
        Console.WriteLine("\nMeniu:");
        Console.WriteLine("1. Adauga comanda client");
        Console.WriteLine("2. Afiseaza comenzi clienti");
        Console.WriteLine("3. Adauga comanda materie prima");
        Console.WriteLine("4. Afiseaza comenzi materie prima");
        Console.WriteLine("5. Finalizeaza comanda materie prima");
        Console.WriteLine("6. Iesire");
        Console.Write("Selectati o optiune: ");

        string optiune = Console.ReadLine();

        switch (optiune)
        {
            case "1":
                Console.Write("Nume destinatar: ");
                string numeDestinatar = Console.ReadLine();
                Console.Write("Numar telefon: ");
                string numarTelefon = Console.ReadLine();
                Console.Write("Descriere comanda: ");
                string descriere = Console.ReadLine();
                florarie.AdaugaComanda(numeDestinatar, numarTelefon, descriere);
                Console.WriteLine("Comanda a fost adăugata.");
                break;

            case "2":
                florarie.AfiseazaComenzi();
                break;

            case "3":
                Console.Write("Cod unic: ");
                if (int.TryParse(Console.ReadLine(), out int codUnic))
                {
                    Console.Write("Descriere materie: ");
                    string descriereMaterie = Console.ReadLine();
                    florarie.AdaugaComandaMaterie(codUnic, descriereMaterie);
                }
                else
                {
                    Console.WriteLine("Cod unic invalid.");
                }
                break;

            case "4":
                florarie.AfiseazaComandaMaterie();
                break;

            case "5":
                Console.Write("Introduceti codul unic al comenzii de materie: ");
                if (int.TryParse(Console.ReadLine(), out int codFinalizare))
                {
                    florarie.FinalizeazaComandaMaterie(codFinalizare);
                }
                else
                {
                    Console.WriteLine("Cod unic invalid.");
                }
                break;

            case "6":
                exit = true;
                Console.WriteLine("La revedere!");
                break;

            default:
                Console.WriteLine("Optiune invalida.");
                break
            
        }
        
    }
}

}
