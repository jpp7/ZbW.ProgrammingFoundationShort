namespace ZbW.ProgrammingFoundationShort.Challenges.Module08.Aufgabe2_InstanceCounter;

public sealed class InstanceCounterForm : Form
{
  private readonly ListBox lstUsers;
  private readonly Label lblCount;

  public InstanceCounterForm()
  {
    Text = "Instance Counter – Aufgabe 2";
    ClientSize = new Size(400, 280);

    Button cmdCreate = new Button { Location = new Point(12, 12), Size = new Size(140, 28), Text = "Benutzer erstellen" };
    Button cmdReset = new Button { Location = new Point(160, 12), Size = new Size(120, 28), Text = "Reset" };
    lstUsers = new ListBox { Location = new Point(12, 55), Size = new Size(360, 170) };
    lblCount = new Label { Location = new Point(12, 235), Size = new Size(360, 30) };

    cmdCreate.Click += CmdCreate_Click;
    cmdReset.Click += CmdReset_Click;

    Controls.Add(cmdCreate);
    Controls.Add(cmdReset);
    Controls.Add(lstUsers);
    Controls.Add(lblCount);
    UpdateView();
  }

  private void CmdCreate_Click(object sender, EventArgs e)
  {
    CountedUser user = new CountedUser($"User {CountedUser.InstanceCount + 1}");
    lstUsers.Items.Add(user.ToString());
    UpdateView();
  }

  private void CmdReset_Click(object sender, EventArgs e)
  {
    CountedUser.ResetCounter();
    lstUsers.Items.Clear();
    UpdateView();
  }

  private void UpdateView()
  {
    lblCount.Text = $"Erstellte Instanzen: {CountedUser.InstanceCount}";
  }
}

public sealed class CountedUser
{
  public CountedUser(string name)
  {
    Name = name;
    InstanceCount++;
    Id = InstanceCount;
  }

  public string Name { get; set; }
  public int Id { get; private set; }
  public static int InstanceCount { get; private set; }

  public static void ResetCounter()
  {
    InstanceCount = 0;
  }

  public override string ToString()
  {
    return $"{Id}: {Name}";
  }
}
