namespace ZbW.ProgrammingFoundationShort.Lessons.Module06.Auftrag1_BankAccount;

// ============================================================
// HILFSKLASSE: BankAccount
// ============================================================

public class BankAccount
{
  // TODO: Owner (string), Balance (decimal, readonly via Property)
  // TODO: Konstruktor(string owner, decimal startBalance)
  // TODO: void Deposit(decimal amount) – Betrag > 0 prüfen
  // TODO: bool Withdraw(decimal amount) – Betrag > 0 und <= Balance prüfen, return bool
  // TODO: override ToString()

  public string Owner { get; private set; } = "";
  public decimal Balance { get; private set; }

  // Konstruktor zum Überschreiben
  public BankAccount(string owner, decimal startBalance)
  {
    // TODO: Owner und Balance setzen (startBalance >= 0 prüfen)
    throw new NotImplementedException("TODO: Konstruktor implementieren");
  }

  public void Deposit(decimal amount)
  {
    // TODO: Betrag > 0 prüfen, Balance erhöhen
    throw new NotImplementedException("TODO: Deposit implementieren");
  }

  public bool Withdraw(decimal amount)
  {
    // TODO: Betrag > 0 und <= Balance prüfen, Balance reduzieren, true/false zurückgeben
    throw new NotImplementedException("TODO: Withdraw implementieren");
  }

  public override string ToString()
  {
    // TODO: $"Konto {Owner}: {Balance:C}"
    throw new NotImplementedException("TODO: ToString implementieren");
  }
}
