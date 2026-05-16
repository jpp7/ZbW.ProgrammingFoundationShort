namespace ZbW.ProgrammingFoundationShort.Challenges.Module10.Aufgabe2_BrowserVerlaufStack;

public sealed class BrowserVerlaufStackForm : Form
{
  private readonly Stack<string> backStack = new Stack<string>();
  private readonly Stack<string> forwardStack = new Stack<string>();
  private readonly List<string> history = new List<string>();
  private string currentUrl = "about:blank";
  private readonly TextBox txtUrl;
  private readonly Button cmdBack;
  private readonly Button cmdForward;
  private readonly Label lblCurrent;
  private readonly ListBox lstHistory;

  public BrowserVerlaufStackForm()
  {
    Text = "Browser-Verlauf mit Stack – Aufgabe 2";
    ClientSize = new Size(560, 340);

    txtUrl = new TextBox { Location = new Point(12, 12), Size = new Size(330, 23), Text = "https://zbw.ch" };
    Button cmdNavigate = new Button { Location = new Point(350, 10), Size = new Size(90, 27), Text = "Navigieren" };
    cmdBack = new Button { Location = new Point(12, 50), Size = new Size(80, 27), Text = "Zurück" };
    cmdForward = new Button { Location = new Point(100, 50), Size = new Size(80, 27), Text = "Vorwärts" };
    lblCurrent = new Label { Location = new Point(12, 90), Size = new Size(520, 35) };
    lstHistory = new ListBox { Location = new Point(12, 135), Size = new Size(520, 180) };

    cmdNavigate.Click += CmdNavigate_Click;
    cmdBack.Click += CmdBack_Click;
    cmdForward.Click += CmdForward_Click;

    Controls.Add(txtUrl);
    Controls.Add(cmdNavigate);
    Controls.Add(cmdBack);
    Controls.Add(cmdForward);
    Controls.Add(lblCurrent);
    Controls.Add(lstHistory);
    UpdateView();
  }

  private void CmdNavigate_Click(object sender, EventArgs e)
  {
    string nextUrl = txtUrl.Text.Trim();

    if (nextUrl.Length == 0)
      return;

    backStack.Push(currentUrl);
    currentUrl = nextUrl;
    forwardStack.Clear();
    history.Add(currentUrl);
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
    lstHistory.Items.Clear();

    foreach (string url in history)
      lstHistory.Items.Add(url);
  }
}
