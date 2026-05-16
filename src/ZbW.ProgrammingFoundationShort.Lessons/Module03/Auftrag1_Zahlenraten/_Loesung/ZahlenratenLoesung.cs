namespace ZbW.ProgrammingFoundationShort.Lessons.Module03.Auftrag1_Zahlenraten;

/// <summary>
///   Lösung: Auftrag 1 – Zahlenraten
///   while-Schleife mit Random und Versuchszähler.
/// </summary>
public static class ZahlenratenLoesung
{
  public static void Start()
  {
    var random = new Random();
    int geheimzahl = random.Next(1, 101);
    int versuche = 0;
    bool geraten = false;

    Console.WriteLine("=== Zahlenraten (1–100) ===");
    Console.WriteLine("Versuche die geheime Zahl zu erraten!");

    while (!geraten)
    {
      Console.Write("Dein Tipp: ");
      string eingabe = Console.ReadLine() ?? "";

      if (!int.TryParse(eingabe, out int tipp))
      {
        Console.WriteLine("Bitte eine ganze Zahl eingeben.");
        continue;
      }

      versuche++;

      if (tipp < geheimzahl)
        Console.WriteLine("Zu klein! Versuche es nochmal.");
      else if (tipp > geheimzahl)
        Console.WriteLine("Zu gross! Versuche es nochmal.");
      else
      {
        geraten = true;
        Console.WriteLine($"Richtig! Du hast die Zahl {geheimzahl} in {versuche} Versuch(en) erraten.");
      }
    }
  }
}
