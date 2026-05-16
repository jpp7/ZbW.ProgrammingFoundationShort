namespace ZbW.ProgrammingFoundationShort.Lessons.Module10.Auftrag2_BrowserVerlaufStack;

public sealed class BrowserVerlaufForm : Form
{
  private readonly Stack<string> backStack = new Stack<string>();
  private readonly Stack<string> forwardStack = new Stack<string>();
  private string currentUrl = "about:blank";

  private readonly TextBox txtUrl;
  private readonly Label lblCurrent;
  private readonly Button cmdVisit;
  private readonly Button cmdBack;
  private readonly Button cmdForward;

  public BrowserVerlaufForm()
  {
    Text = "Browser-Verlauf – Auftrag 2";
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
    // TODO: Aktuelle URL auf backStack legen, TextBox als neue URL übernehmen.
    // TODO: forwardStack leeren und UpdateView() aufrufen.
  }

  private void CmdBack_Click(object sender, EventArgs e)
  {
    // TODO: currentUrl auf forwardStack legen, letzte URL von backStack holen.
  }

  private void CmdForward_Click(object sender, EventArgs e)
  {
    // TODO: currentUrl auf backStack legen, nächste URL von forwardStack holen.
  }

  private void UpdateView()
  {
    lblCurrent.Text = $"Aktuelle URL: {currentUrl}";
    cmdBack.Enabled = backStack.Count > 0;
    cmdForward.Enabled = forwardStack.Count > 0;
  }
}
