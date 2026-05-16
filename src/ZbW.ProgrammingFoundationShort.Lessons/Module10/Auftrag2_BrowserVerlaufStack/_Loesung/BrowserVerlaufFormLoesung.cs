namespace ZbW.ProgrammingFoundationShort.Lessons.Module10.Auftrag2_BrowserVerlaufStack._Loesung;

public sealed class BrowserVerlaufFormLoesung : Form
{
  private readonly Stack<string> backStack = new Stack<string>();
  private readonly Stack<string> forwardStack = new Stack<string>();
  private string currentUrl = "about:blank";

  private readonly TextBox txtUrl;
  private readonly Label lblCurrent;
  private readonly Button cmdVisit;
  private readonly Button cmdBack;
  private readonly Button cmdForward;

  public BrowserVerlaufFormLoesung()
  {
    Text = "Browser-Verlauf – Lösung";
    ClientSize = new Size(520, 150);

    txtUrl = new TextBox { Location = new Point(12, 12), Size = new Size(330, 23), Text = "https://zbw.ch" };
    cmdVisit = new Button { Location = new Point(350, 10), Size = new Size(80, 27), Text = "Besuchen" };
    cmdBack = new Button { Location = new Point(12, 50), Size = new Size(80, 27), Text = "Zurück" };
    cmdForward = new Button { Location = new Point(100, 50), Size = new Size(80, 27), Text = "Vorwärts" };
    lblCurrent = new Label { Location = new Point(12, 95), Size = new Size(490, 40) };

    cmdVisit.Click += CmdVisit_Click;
    cmdBack.Click += CmdBack_Click;
    cmdForward.Click += CmdForward_Click;

    Controls.Add(txtUrl);
    Controls.Add(cmdVisit);
    Controls.Add(cmdBack);
    Controls.Add(cmdForward);
    Controls.Add(lblCurrent);

    UpdateView();
  }

  private void CmdVisit_Click(object sender, EventArgs e)
  {
    string nextUrl = txtUrl.Text.Trim();

    if (nextUrl.Length == 0)
      return;

    backStack.Push(currentUrl);
    currentUrl = nextUrl;
    forwardStack.Clear();
    UpdateView();
  }

  private void CmdBack_Click(object sender, EventArgs e)
  {
    if (backStack.Count == 0)
      return;

    forwardStack.Push(currentUrl);
    currentUrl = backStack.Pop();
    UpdateView();
  }

  private void CmdForward_Click(object sender, EventArgs e)
  {
    if (forwardStack.Count == 0)
      return;

    backStack.Push(currentUrl);
    currentUrl = forwardStack.Pop();
    UpdateView();
  }

  private void UpdateView()
  {
    lblCurrent.Text = $"Aktuelle URL: {currentUrl}";
    cmdBack.Enabled = backStack.Count > 0;
    cmdForward.Enabled = forwardStack.Count > 0;
  }
}
