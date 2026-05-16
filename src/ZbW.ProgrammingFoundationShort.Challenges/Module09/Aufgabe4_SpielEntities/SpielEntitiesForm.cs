using System.Text;

namespace ZbW.ProgrammingFoundationShort.Challenges.Module09.Aufgabe4_SpielEntities;

public sealed class SpielEntitiesForm : Form
{
  private readonly ComboBox cmbFirstType;
  private readonly ComboBox cmbSecondType;
  private readonly TextBox txtFirstName;
  private readonly TextBox txtSecondName;
  private readonly TextBox txtFirstValue;
  private readonly TextBox txtSecondValue;
  private readonly TextBox txtLog;

  public SpielEntitiesForm()
  {
    Text = "Spiel-Entities – Aufgabe 4";
    ClientSize = new Size(650, 430);

    cmbFirstType = new ComboBox { Location = new Point(95, 12), Size = new Size(120, 23), DropDownStyle = ComboBoxStyle.DropDownList };
    cmbSecondType = new ComboBox { Location = new Point(420, 12), Size = new Size(120, 23), DropDownStyle = ComboBoxStyle.DropDownList };
    txtFirstName = new TextBox { Location = new Point(95, 45), Size = new Size(120, 23), Text = "Ragnar" };
    txtSecondName = new TextBox { Location = new Point(420, 45), Size = new Size(120, 23), Text = "Mira" };
    txtFirstValue = new TextBox { Location = new Point(95, 78), Size = new Size(80, 23), Text = "18" };
    txtSecondValue = new TextBox { Location = new Point(420, 78), Size = new Size(80, 23), Text = "16" };
    Button cmdFight = new Button { Location = new Point(260, 45), Size = new Size(120, 28), Text = "Kampf starten" };
    txtLog = new TextBox { Location = new Point(12, 120), Size = new Size(610, 285), Multiline = true, ScrollBars = ScrollBars.Vertical };

    cmbFirstType.Items.AddRange(new object[] { "Warrior", "Mage", "Archer" });
    cmbSecondType.Items.AddRange(new object[] { "Warrior", "Mage", "Archer" });
    cmbFirstType.SelectedIndex = 0;
    cmbSecondType.SelectedIndex = 1;

    cmdFight.Click += CmdFight_Click;

    Controls.Add(new Label { Location = new Point(12, 15), Size = new Size(80, 20), Text = "Charakter 1:" });
    Controls.Add(new Label { Location = new Point(335, 15), Size = new Size(80, 20), Text = "Charakter 2:" });
    Controls.Add(new Label { Location = new Point(12, 48), Size = new Size(80, 20), Text = "Name:" });
    Controls.Add(new Label { Location = new Point(335, 48), Size = new Size(80, 20), Text = "Name:" });
    Controls.Add(new Label { Location = new Point(12, 81), Size = new Size(80, 20), Text = "Wert:" });
    Controls.Add(new Label { Location = new Point(335, 81), Size = new Size(80, 20), Text = "Wert:" });
    Controls.Add(cmbFirstType);
    Controls.Add(cmbSecondType);
    Controls.Add(txtFirstName);
    Controls.Add(txtSecondName);
    Controls.Add(txtFirstValue);
    Controls.Add(txtSecondValue);
    Controls.Add(cmdFight);
    Controls.Add(txtLog);
  }

  private void CmdFight_Click(object sender, EventArgs e)
  {
    if (!int.TryParse(txtFirstValue.Text, out int firstValue) || !int.TryParse(txtSecondValue.Text, out int secondValue))
    {
      txtLog.Text = "Bitte Werte als ganze Zahlen eingeben.";
      return;
    }

    GameEntity firstEntity = CreateEntity(cmbFirstType.Text, txtFirstName.Text, firstValue);
    GameEntity secondEntity = CreateEntity(cmbSecondType.Text, txtSecondName.Text, secondValue);
    txtLog.Text = new Battle().SimulateFight(firstEntity, secondEntity);
  }

  private GameEntity CreateEntity(string type, string name, int value)
  {
    if (type == "Mage")
      return new Mage { Name = name, MaxHealth = 90, Health = 90, MagicPower = value };

    if (type == "Archer")
      return new Archer { Name = name, MaxHealth = 100, Health = 100, Accuracy = value };

    return new Warrior { Name = name, MaxHealth = 120, Health = 120, Strength = value };
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
