namespace ZbW.ProgrammingFoundationShort.Challenges.Module09.Aufgabe1_TierHierarchie;

public sealed class TierHierarchieForm : Form
{
  private readonly ComboBox cmbType;
  private readonly TextBox txtName;
  private readonly TextBox txtAge;
  private readonly TextBox txtExtra;
  private readonly Label lblResult;

  public TierHierarchieForm()
  {
    Text = "Tier-Hierarchie – Aufgabe 1";
    ClientSize = new Size(430, 230);

    cmbType = new ComboBox { Location = new Point(120, 12), Size = new Size(160, 23), DropDownStyle = ComboBoxStyle.DropDownList };
    cmbType.Items.AddRange(new object[] { "Hund", "Katze", "Vogel" });
    cmbType.SelectedIndex = 0;
    txtName = new TextBox { Location = new Point(120, 45), Size = new Size(160, 23), Text = "Bello" };
    txtAge = new TextBox { Location = new Point(120, 78), Size = new Size(80, 23), Text = "3" };
    txtExtra = new TextBox { Location = new Point(120, 111), Size = new Size(160, 23), Text = "Golden Retriever" };
    Button cmdCreate = new Button { Location = new Point(120, 145), Size = new Size(130, 28), Text = "Erstellen" };
    lblResult = new Label { Location = new Point(12, 185), Size = new Size(400, 35) };

    Controls.Add(new Label { Location = new Point(12, 15), Size = new Size(100, 20), Text = "Tierart:" });
    Controls.Add(new Label { Location = new Point(12, 48), Size = new Size(100, 20), Text = "Name:" });
    Controls.Add(new Label { Location = new Point(12, 81), Size = new Size(100, 20), Text = "Alter:" });
    Controls.Add(new Label { Location = new Point(12, 114), Size = new Size(100, 20), Text = "Rasse/Fliegt:" });
    Controls.Add(cmbType);
    Controls.Add(txtName);
    Controls.Add(txtAge);
    Controls.Add(txtExtra);
    Controls.Add(cmdCreate);
    Controls.Add(lblResult);

    cmdCreate.Click += CmdCreate_Click;
  }

  private void CmdCreate_Click(object sender, EventArgs e)
  {
    if (!int.TryParse(txtAge.Text, out int age))
    {
      lblResult.Text = "Alter ist ungültig.";
      return;
    }

    Animal animal;

    if (cmbType.SelectedItem?.ToString() == "Hund")
      animal = new Dog { Name = txtName.Text, Age = age, Breed = txtExtra.Text };
    else if (cmbType.SelectedItem?.ToString() == "Vogel")
      animal = new Bird { Name = txtName.Text, Age = age, CanFly = txtExtra.Text.Equals("ja", StringComparison.OrdinalIgnoreCase) };
    else
      animal = new Cat { Name = txtName.Text, Age = age };

    lblResult.Text = $"{animal.MakeSound()} ({animal})";
  }
}

public class Animal
{
  public string Name { get; set; } = "";
  public int Age { get; set; }

  public virtual string MakeSound()
  {
    return "...";
  }

  public override string ToString()
  {
    return $"{Name}, {Age} Jahre";
  }
}

public sealed class Dog : Animal
{
  public string Breed { get; set; } = "";

  public override string MakeSound()
  {
    return "Wuff!";
  }

  public override string ToString()
  {
    return $"{base.ToString()}, {Breed}";
  }
}

public sealed class Cat : Animal
{
  public override string MakeSound()
  {
    return "Miau!";
  }
}

public sealed class Bird : Animal
{
  public bool CanFly { get; set; }

  public override string MakeSound()
  {
    return "Piep!";
  }

  public override string ToString()
  {
    return $"{base.ToString()}, kann fliegen: {CanFly}";
  }
}
