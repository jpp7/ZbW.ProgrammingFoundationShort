namespace ZbW.ProgrammingFoundationShort.Challenges.Module09.Aufgabe3_MitarbeiterHierarchie;

public sealed class MitarbeiterForm : Form
{
  private readonly List<Employee> employees = new List<Employee>();
  private readonly ComboBox cmbType;
  private readonly TextBox txtName;
  private readonly TextBox txtBaseSalary;
  private readonly TextBox txtExtra;
  private readonly ListBox lstEmployees;
  private readonly Label lblTotal;

  public MitarbeiterForm()
  {
    Text = "Mitarbeiter-Hierarchie – Aufgabe 3";
    ClientSize = new Size(620, 360);

    cmbType = new ComboBox { Location = new Point(120, 12), Size = new Size(180, 23), DropDownStyle = ComboBoxStyle.DropDownList };
    cmbType.Items.AddRange(new object[] { "FullTime", "PartTime", "Manager" });
    cmbType.SelectedIndex = 0;
    txtName = new TextBox { Location = new Point(120, 45), Size = new Size(180, 23), Text = "Anna" };
    txtBaseSalary = new TextBox { Location = new Point(120, 78), Size = new Size(100, 23), Text = "8000" };
    txtExtra = new TextBox { Location = new Point(120, 111), Size = new Size(180, 23), Text = "10" };
    Button cmdAdd = new Button { Location = new Point(120, 145), Size = new Size(120, 28), Text = "Hinzufügen" };
    lstEmployees = new ListBox { Location = new Point(320, 12), Size = new Size(280, 280) };
    lblTotal = new Label { Location = new Point(320, 305), Size = new Size(280, 35) };

    Controls.Add(new Label { Location = new Point(12, 15), Size = new Size(100, 20), Text = "Typ:" });
    Controls.Add(new Label { Location = new Point(12, 48), Size = new Size(100, 20), Text = "Name:" });
    Controls.Add(new Label { Location = new Point(12, 81), Size = new Size(100, 20), Text = "Basislohn:" });
    Controls.Add(new Label { Location = new Point(12, 114), Size = new Size(100, 20), Text = "Bonus/Std/Team:" });
    Controls.Add(cmbType);
    Controls.Add(txtName);
    Controls.Add(txtBaseSalary);
    Controls.Add(txtExtra);
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
      employee = new Manager { Id = employees.Count + 1, Name = txtName.Text, BaseSalary = baseSalary, BonusPercent = extra, TeamSize = 5 };
    else if (cmbType.SelectedItem?.ToString() == "PartTime")
      employee = new PartTimeEmployee { Id = employees.Count + 1, Name = txtName.Text, HoursPerWeek = (int)extra, HourlyRate = baseSalary };
    else
      employee = new FullTimeEmployee { Id = employees.Count + 1, Name = txtName.Text, BaseSalary = baseSalary, BonusPercent = extra };

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
  public string Name { get; set; } = "";
  public int Id { get; set; }
  public decimal BaseSalary { get; set; }

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
  public double BonusPercent { get; set; }

  public override decimal CalculateSalary()
  {
    return BaseSalary * (1 + (decimal)BonusPercent / 100);
  }
}

public sealed class PartTimeEmployee : Employee
{
  public int HoursPerWeek { get; set; }
  public decimal HourlyRate { get; set; }

  public override decimal CalculateSalary()
  {
    return HoursPerWeek * 4.33m * HourlyRate;
  }
}

public sealed class Manager : FullTimeEmployee
{
  public int TeamSize { get; set; }

  public override decimal CalculateSalary()
  {
    return base.CalculateSalary() + TeamSize * 500m;
  }
}
