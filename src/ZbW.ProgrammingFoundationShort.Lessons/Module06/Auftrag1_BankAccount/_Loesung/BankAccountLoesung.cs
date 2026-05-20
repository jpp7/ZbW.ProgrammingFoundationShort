namespace ZbW.ProgrammingFoundationShort.Lessons.Module06.Auftrag1_BankAccount;

/// <summary>
///   Lösung: BankAccount-Klasse mit Owner, Balance, Deposit, Withdraw.
/// </summary>
public class BankAccountLoesung
{
  public string Owner { get; private set; }
  public decimal Balance { get; private set; }

  public BankAccountLoesung(string owner, decimal initialBalance = 0)
  {
    if (string.IsNullOrWhiteSpace(owner))
      throw new ArgumentException("Kontoinhaber darf nicht leer sein.");
    if (initialBalance < 0)
      throw new ArgumentException("Startguthaben darf nicht negativ sein.");

    Owner = owner.Trim();
    Balance = initialBalance;
  }

  public void Deposit(decimal amount)
  {
    if (amount <= 0)
      throw new ArgumentException("Einzahlbetrag muss positiv sein.");
    Balance += amount;
  }

  public bool Withdraw(decimal amount)
  {
    if (amount <= 0)
      throw new ArgumentException("Abhebebetrag muss positiv sein.");
    if (amount > Balance)
      return false;

    Balance -= amount;
    return true;
  }

  public override string ToString()
  {
    return $"[{Owner}] Saldo: {Balance:F2} CHF";
  }
}