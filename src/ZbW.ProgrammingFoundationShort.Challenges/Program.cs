namespace ZbW.ProgrammingFoundationShort.Challenges;

// ============================================================
// MUSTERLÖSUNG – Challenges Starter
// Kommentiere die Form ein, die du anschauen möchtest.
// ============================================================

internal static class Program
{
  [STAThread]
  private static void Main()
  {
    ApplicationConfiguration.Initialize();

    // ---- Modul 01 ----
    Application.Run(new Module01.Aufgabe1_Bmi.BmiForm());
    // Application.Run(new Module01.Aufgabe2_Waehrungsrechner.WaehrungsrechnerForm());
    // Application.Run(new Module01.Aufgabe3_ZahlenAnalyse.ZahlenAnalyseForm());
    // Application.Run(new Module01.Aufgabe4_Einheitenrechner.EinheitenrechnerForm());

    // TODO: Weitere Module werden hier ergänzt...
  }
}
