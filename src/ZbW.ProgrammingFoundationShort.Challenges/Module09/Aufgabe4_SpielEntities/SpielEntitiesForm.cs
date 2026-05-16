using System.Text;

namespace ZbW.ProgrammingFoundationShort.Challenges.Module09.Aufgabe4_SpielEntities;

public sealed class SpielEntitiesForm : Form
{
  private readonly TextBox txtLog;

  public SpielEntitiesForm()
  {
    Text = "Spiel-Entities – Aufgabe 4";
    ClientSize = new Size(560, 360);

    Button cmdFight = new Button { Location = new Point(12, 12), Size = new Size(120, 28), Text = "Kampf starten" };
    txtLog = new TextBox { Location = new Point(12, 55), Size = new Size(530, 285), Multiline = true, ScrollBars = ScrollBars.Vertical };

    cmdFight.Click += CmdFight_Click;

    Controls.Add(cmdFight);
    Controls.Add(txtLog);
  }

  private void CmdFight_Click(object sender, EventArgs e)
  {
    Warrior warrior = new Warrior { Name = "Ragnar", MaxHealth = 120, Health = 120, Strength = 18 };
    Mage mage = new Mage { Name = "Mira", MaxHealth = 90, Health = 90, MagicPower = 16 };
    txtLog.Text = new Battle().SimulateFight(warrior, mage);
  }
}

public abstract class GameEntity
{
  public string Name { get; set; } = "";
  public int Health { get; set; }
  public int MaxHealth { get; set; }
  public bool IsAlive => Health > 0;

  public virtual void TakeDamage(int damage)
  {
    Health = Math.Max(0, Health - damage);
  }

  public abstract int Attack();
}

public sealed class Warrior : GameEntity
{
  private static readonly Random Random = new Random();
  public int Strength { get; set; }

  public override int Attack()
  {
    return Strength + Random.Next(1, 7);
  }
}

public sealed class Mage : GameEntity
{
  private int attackCounter;
  public int MagicPower { get; set; }

  public override int Attack()
  {
    attackCounter++;
    return attackCounter % 2 == 0 ? 0 : MagicPower * 2;
  }
}

public sealed class Archer : GameEntity
{
  public int Accuracy { get; set; }

  public override int Attack()
  {
    return Accuracy > 70 ? 35 : 20;
  }
}

public sealed class Battle
{
  public string SimulateFight(GameEntity firstEntity, GameEntity secondEntity)
  {
    StringBuilder builder = new StringBuilder();
    int round = 1;

    while (firstEntity.IsAlive && secondEntity.IsAlive)
    {
      int firstDamage = firstEntity.Attack();
      secondEntity.TakeDamage(firstDamage);
      builder.AppendLine($"Runde {round}: {firstEntity.Name} verursacht {firstDamage}. {secondEntity.Name}: {secondEntity.Health}/{secondEntity.MaxHealth}");

      if (!secondEntity.IsAlive)
        break;

      int secondDamage = secondEntity.Attack();
      firstEntity.TakeDamage(secondDamage);
      builder.AppendLine($"Runde {round}: {secondEntity.Name} verursacht {secondDamage}. {firstEntity.Name}: {firstEntity.Health}/{firstEntity.MaxHealth}");
      round++;
    }

    builder.AppendLine(firstEntity.IsAlive ? $"{firstEntity.Name} gewinnt." : $"{secondEntity.Name} gewinnt.");
    return builder.ToString();
  }
}
