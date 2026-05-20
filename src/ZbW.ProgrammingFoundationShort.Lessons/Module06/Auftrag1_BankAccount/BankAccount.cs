namespace ZbW.ProgrammingFoundationShort.Lessons.Module06.Auftrag1_BankAccount;

// ============================================================
// HILFSKLASSE: BankAccount
// ============================================================

public class BankAccount
{
  // TODO: Owner (string), Balance (decimal, private setter)
  // TODO: Konstruktor(string owner, decimal initialBalance = 0)
  // TODO: void Deposit(decimal amount) – Betrag > 0 prüfen
  // TODO: bool Withdraw(decimal amount) – false wenn nicht genug Guthaben
  // TODO: override ToString(): $"[{Owner}] Saldo: {Balance:F2} CHF"

  public string Owner { get; private set; } = "";
  public decimal Balance { get; private set; }

  public BankAccount(string owner, decimal initialBalance = 0)
  {
    // TODO: Owner und Balance setzen (initialBalance >= 0 prüfen)
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
    // TODO: $"[{Owner}] Saldo: {Balance:F2} CHF"
    throw new NotImplementedException("TODO: ToString implementieren");
  }
}