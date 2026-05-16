namespace ZbW.ProgrammingFoundationShort.Challenges.Module09.Aufgabe3_MitarbeiterHierarchie;

public sealed class MitarbeiterForm : Form
{
  private readonly List<Employee> employees = new List<Employee>();
  private readonly ComboBox cmbType;
  private readonly TextBox txtName;
  private readonly TextBox txtBaseSalary;
  private readonly TextBox txtExtra;
  private readonly TextBox txtTeamSize;
  private readonly ListBox lstEmployees;
  private readonly Label lblTotal;

  public MitarbeiterForm()
  {
    Text = "Mitarbeiter-Hierarchie – Aufgabe 3";
    ClientSize = new Size(650, 390);

    cmbType = new ComboBox { Location = new Point(120, 12), Size = new Size(180, 23), DropDownStyle = ComboBoxStyle.DropDownList };
    cmbType.Items.AddRange(new object[] { "FullTime", "PartTime", "Manager" });
    cmbType.SelectedIndex = 0;
    txtName = new TextBox { Location = new Point(120, 45), Size = new Size(180, 23), Text = "Anna" };
    txtBaseSalary = new TextBox { Location = new Point(120, 78), Size = new Size(100, 23), Text = "8000" };
    txtExtra = new TextBox { Location = new Point(120, 111), Size = new Size(180, 23), Text = "10" };
    txtTeamSize = new TextBox { Location = new Point(120, 144), Size = new Size(80, 23), Text = "5" };
    Button cmdAdd = new Button { Location = new Point(120, 180), Size = new Size(120, 28), Text = "Hinzufügen" };
    lstEmployees = new ListBox { Location = new Point(330, 12), Size = new Size(300, 300) };
    lblTotal = new Label { Location = new Point(330, 325), Size = new Size(300, 35) };

    Controls.Add(new Label { Location = new Point(12, 15), Size = new Size(100, 20), Text = "Typ:" });
    Controls.Add(new Label { Location = new Point(12, 48), Size = new Size(100, 20), Text = "Name:" });
    Controls.Add(new Label { Location = new Point(12, 81), Size = new Size(100, 20), Text = "Basislohn:" });
    Controls.Add(new Label { Location = new Point(12, 114), Size = new Size(100, 20), Text = "Bonus/Std/Team:" });
    Controls.Add(new Label { Location = new Point(12, 147), Size = new Size(100, 20), Text = "Teamgrösse:" });
    Controls.Add(cmbType);
    Controls.Add(txtName);
    Controls.Add(txtBaseSalary);
    Controls.Add(txtExtra);
    Controls.Add(txtTeamSize);
    Controls.Add(cmdAdd);
    Controls.Add(lstEmployees);
    Controls.Add(lblTotal);

    cmdAdd.Click += CmdAdd_Click;
  }

  private void CmdAdd_Click(object sender, EventArgs e)
  {
    if (!decimal.TryParse(txtBaseSalary.Text, out decimal baseSalary) || !double.TryParse(txtExtra.Text, out double extra))
      return;

    Employee employee;

    if (cmbType.SelectedItem?.ToString() == "Manager")
    {
      if (!int.TryParse(txtTeamSize.Text, out int teamSize))
        return;

      employee = new Manager(txtName.Text, employees.Count + 1, baseSalary, extra, teamSize);
    }
    else if (cmbType.SelectedItem?.ToString() == "PartTime")
      employee = new PartTimeEmployee(txtName.Text, employees.Count + 1, (int)extra, baseSalary);
    else
      employee = new FullTimeEmployee(txtName.Text, employees.Count + 1, baseSalary, extra);

    employees.Add(employee);
    RefreshEmployees();
  }

  private void RefreshEmployees()
  {
    lstEmployees.Items.Clear();
    decimal total = 0;

    foreach (Employee employee in employees)
    {
      total += employee.CalculateSalary();
      lstEmployees.Items.Add(employee.GetEmployeeInfo());
    }

    lblTotal.Text = $"Gesamtlohnkosten: {total:F2} CHF";
  }
}

public class Employee
{
  public Employee(string name, int id, decimal baseSalary)
  {
    Name = name;
    Id = id;
    BaseSalary = baseSalary;
  }

  public string Name { get; set; }
  public int Id { get; set; }
  protected decimal BaseSalary { get; set; }

  public virtual decimal CalculateSalary()
  {
    return BaseSalary;
  }

  public virtual string GetEmployeeInfo()
  {
    return $"{Id}: {Name}, Gehalt {CalculateSalary():F2} CHF";
  }
}

public class FullTimeEmployee : Employee
{
  public FullTimeEmployee(string name, int id, decimal baseSalary, double bonusPercent)
    : base(name, id, baseSalary)
  {
    BonusPercent = bonusPercent;
  }

  public double BonusPercent { get; set; }

  public override decimal CalculateSalary()
  {
    return BaseSalary * (1 + (decimal)BonusPercent / 100);
  }
}

public sealed class PartTimeEmployee : Employee
{
  public PartTimeEmployee(string name, int id, int hoursPerWeek, decimal hourlyRate)
    : base(name, id, 0)
  {
    HoursPerWeek = hoursPerWeek;
    HourlyRate = hourlyRate;
  }

  public int HoursPerWeek { get; set; }
  public decimal HourlyRate { get; set; }

  public override decimal CalculateSalary()
  {
    return HoursPerWeek * 4.33m * HourlyRate;
  }
}

public sealed class Manager : FullTimeEmployee
{
  public Manager(string name, int id, decimal baseSalary, double bonusPercent, int teamSize)
    : base(name, id, baseSalary, bonusPercent)
  {
    TeamSize = teamSize;
  }

  public int TeamSize { get; set; }

  public override decimal CalculateSalary()
  {
    return base.CalculateSalary() + TeamSize * 500m;
  }
}
