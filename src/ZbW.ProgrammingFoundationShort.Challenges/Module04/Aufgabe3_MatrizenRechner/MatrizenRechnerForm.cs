namespace ZbW.ProgrammingFoundationShort.Challenges.Module04.Aufgabe3_MatrizenRechner;

/// <summary>
///   Aufgabe 3 – Matrizen-Rechner (⭐⭐⭐ Schwer)
///   3×3-Matrix-Addition und Transposition.
/// </summary>
public partial class MatrizenRechnerForm : Form
{
  public MatrizenRechnerForm()
  {
    InitializeComponent();
  }

  private int[,] LesMatrixA()
  {
    TextBox[,] felder = {
      { TxtA00, TxtA01, TxtA02 },
      { TxtA10, TxtA11, TxtA12 },
      { TxtA20, TxtA21, TxtA22 }
    };
    var matrix = new int[3, 3];
    for (int i = 0; i < 3; i++)
      for (int j = 0; j < 3; j++)
        if (!int.TryParse(felder[i, j].Text, out matrix[i, j]))
          throw new FormatException($"Ungültiger Wert in Matrix A [{i},{j}]");
    return matrix;
  }

  private int[,] LesMatrixB()
  {
    TextBox[,] felder = {
      { TxtB00, TxtB01, TxtB02 },
      { TxtB10, TxtB11, TxtB12 },
      { TxtB20, TxtB21, TxtB22 }
    };
    var matrix = new int[3, 3];
    for (int i = 0; i < 3; i++)
      for (int j = 0; j < 3; j++)
        if (!int.TryParse(felder[i, j].Text, out matrix[i, j]))
          throw new FormatException($"Ungültiger Wert in Matrix B [{i},{j}]");
    return matrix;
  }

  private void CmdAddieren_Click(object sender, EventArgs e)
  {
    try
    {
      int[,] a = LesMatrixA();
      int[,] b = LesMatrixB();
      int[,] result = MatrixAddieren(a, b);
      LblErgebnis.Text = "A + B =\r\n" + ShowMatrix(result);
    }
    catch (FormatException ex)
    {
      MessageBox.Show(ex.Message, "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
  }

  private void CmdTransponieren_Click(object sender, EventArgs e)
  {
    try
    {
      int[,] a = LesMatrixA();
      int[,] result = Transpose(a);
      LblErgebnis.Text = "A^T =\r\n" + ShowMatrix(result);
    }
    catch (FormatException ex)
    {
      MessageBox.Show(ex.Message, "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
  }

  private static int[,] MatrixAddieren(int[,] a, int[,] b)
  {
    var result = new int[3, 3];
    for (int i = 0; i < 3; i++)
      for (int j = 0; j < 3; j++)
        result[i, j] = a[i, j] + b[i, j];
    return result;
  }

  private static int[,] Transpose(int[,] a)
  {
    var result = new int[3, 3];
    for (int i = 0; i < 3; i++)
      for (int j = 0; j < 3; j++)
        result[j, i] = a[i, j];
    return result;
  }

  private static string ShowMatrix(int[,] m)
  {
    var sb = new System.Text.StringBuilder();
    for (int i = 0; i < 3; i++)
    {
      sb.Append("| ");
      for (int j = 0; j < 3; j++)
        sb.Append($"{m[i, j],4} ");
      sb.AppendLine("|");
    }
    return sb.ToString();
  }
}
