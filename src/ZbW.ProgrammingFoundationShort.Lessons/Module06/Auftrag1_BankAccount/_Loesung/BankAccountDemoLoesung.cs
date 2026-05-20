namespace ZbW.ProgrammingFoundationShort.Lessons.Module06.Auftrag1_BankAccount;

/// <summary>
///   Lösung: BankAccount Demo – zwei Konten, mehrere Transaktionen.
/// </summary>
public static class BankAccountDemoLoesung
{
  public static void Start()
  {
    Console.WriteLine("=== Bank-Demo ===\n");

    var konto1 = new BankAccountLoesung("Anna", 1000m);
    var konto2 = new BankAccountLoesung("Bob");

    Console.WriteLine($"Anfangsstand: {konto1}");
    Console.WriteLine($"Anfangsstand: {konto2}");

    konto1.Deposit(200m);
    konto2.Deposit(500m);
    Console.WriteLine($"\nNach Einzahlung 200: {konto1}");
    Console.WriteLine($"Nach Einzahlung 500: {konto2}");

    bool erfolg1 = konto1.Withdraw(300m);
    Console.WriteLine($"Abhebung 300 ({(erfolg1 ? "OK" : "Fehlgeschlagen")}): {konto1}");

    bool erfolg2 = konto2.Withdraw(600m);
    Console.WriteLine($"Abhebung 600 ({(erfolg2 ? "OK" : "Fehlgeschlagen – kein Guthaben")}): {konto2}");
  }
}