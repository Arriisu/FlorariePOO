public class FileManager
{
  private readonly string filePath;
  public FileManager(string filePath)
  {
    this.filePath = filePath;
  }

  public List<string> IncarcaDinFisier()
  {
    try
    {
      return File.ReadAllLines(filePath).ToLits();
    }
    catch (Exception e)
    {
      Console.WriteLine($"Eroare la citirea fisierului {filePath}: {e.Message}");
      return new List<string>();
    }
  }

  public void SalveazaInFisier(List<string> lines)
  {
    try
    {
      File.WriteAllLines(filePath, lines);
    }
    catch (Exception e)
    {
      Console.WriteLine($"Eroare la scrierea fisierului {filePath}: {e.Message}");
    }
  }
}
    
