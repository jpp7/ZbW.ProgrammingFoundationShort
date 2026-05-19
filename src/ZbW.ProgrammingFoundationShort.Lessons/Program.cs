namespace ZbW.ProgrammingFoundationShort.Lessons;

// ============================================================
// STARTUP-KONFIGURATION
// Kommentiere die Form ein, die du testen möchtest.
// Alle anderen Zeilen müssen auskommentiert sein.
// ============================================================

internal static class Program
{
  [STAThread]
  private static void Main()
  {
    ApplicationConfiguration.Initialize();

    // ---- Modul 01 ----
    // ZbW.ProgrammingFoundationShort.Lessons.Module01.Auftrag1_Taschenrechner.Taschenrechner.Start();
    // Application.Run(new ZbW.ProgrammingFoundationShort.Lessons.Module01.Auftrag2_Temperaturrechner.TemperaturrechnerForm());
    // ZbW.ProgrammingFoundationShort.Lessons.Module01.Auftrag3_DatentypQuiz.DatentypQuiz.Start();

    // ---- Modul 02 ----
    // Application.Run(new ZbW.ProgrammingFoundationShort.Lessons.Module02.Auftrag1_Notenrechner.NotenrechnerForm());
    // Application.Run(new ZbW.ProgrammingFoundationShort.Lessons.Module02.Auftrag2_WochentageApp.WochentageAppForm());
    // Application.Run(new ZbW.ProgrammingFoundationShort.Lessons.Module02.Auftrag3_RabattKalkulator.RabattKalkulatorForm());

    // ---- Modul 03 ----
    // Console.WriteLine(ZbW.ProgrammingFoundationShort.Lessons.Module03.Auftrag1_Zahlenraten.Zahlenraten.RunDemo());
    // Console.WriteLine(ZbW.ProgrammingFoundationShort.Lessons.Module03.Auftrag2_PasswortValidator.PasswortValidator.Validate("Passwort1!"));
    // Application.Run(new ZbW.ProgrammingFoundationShort.Lessons.Module03.Auftrag3_SichererDateiLeser.SichererDateiLeserForm());

    // ---- Modul 04 ----
    // Console.WriteLine(ZbW.ProgrammingFoundationShort.Lessons.Module04.Auftrag1_StatistikRechner.StatistikRechner.RunDemo());
    // Application.Run(new ZbW.ProgrammingFoundationShort.Lessons.Module04.Auftrag2_NotenVerwaltung.NotenVerwaltungForm());
    // Console.WriteLine(ZbW.ProgrammingFoundationShort.Lessons.Module04.Auftrag3_MatrixMultiplikation.MatrixRechner.RunDemo());

    // ---- Modul 05 ----
    // Application.Run(new ZbW.ProgrammingFoundationShort.Lessons.Module05.Auftrag1_Einkaufsliste.EinkaufslisteForm());
    // Application.Run(new ZbW.ProgrammingFoundationShort.Lessons.Module05.Auftrag2_WoerterbuchApp.WoerterbuchAppForm());
    // Console.WriteLine(ZbW.ProgrammingFoundationShort.Lessons.Module05.Auftrag3_FilmarchivAuswertung.FilmarchivAuswertung.RunDemo());

    // ---- Modul 06 ----
    // Console.WriteLine(ZbW.ProgrammingFoundationShort.Lessons.Module06.Auftrag1_BankAccount.BankAccountDemo.RunDemo());
    // Application.Run(new ZbW.ProgrammingFoundationShort.Lessons.Module06.Auftrag2_FahrzeugVerwaltung.FahrzeugVerwaltungForm());
    // Console.WriteLine(ZbW.ProgrammingFoundationShort.Lessons.Module06.Auftrag3_ValidierteProperties.PersonDemo.RunDemo());

    // ---- Modul 07 ----
    // Console.WriteLine(ZbW.ProgrammingFoundationShort.Lessons.Module07.Auftrag1_ReferenzExperiment.ReferenzExperimentDemo.RunDemo());
    // Console.WriteLine(ZbW.ProgrammingFoundationShort.Lessons.Module07.Auftrag2_EqualsUeberschreiben.ProductEqualsDemo.RunDemo());
    // Application.Run(new ZbW.ProgrammingFoundationShort.Lessons.Module07.Auftrag3_Kontaktmanager.KontaktmanagerForm());

    // ---- Modul 08 ----
    // Console.WriteLine(ZbW.ProgrammingFoundationShort.Lessons.Module08.Auftrag1_StatischerZaehler.StatischerZaehlerDemo.RunDemo());
    // Application.Run(new ZbW.ProgrammingFoundationShort.Lessons.Module08.Auftrag2_MathUtils.MathUtilsForm());
    // Application.Run(new ZbW.ProgrammingFoundationShort.Lessons.Module08.Auftrag3_TrafficLightLogger.TrafficLightForm());

    // ---- Modul 09 ----
    // Console.WriteLine(ZbW.ProgrammingFoundationShort.Lessons.Module09.Auftrag1_AnimalHierarchy.AnimalHierarchy.RunDemo());
    // Console.WriteLine(new ZbW.ProgrammingFoundationShort.Lessons.Module09.Auftrag2_AbstractShape.Circle { Color = "Rot", Radius = 5 }.Describe());
    // ZbW.ProgrammingFoundationShort.Lessons.Module09.Auftrag3_MediaHierarchy.MediaDemo.PrintAll(new List<ZbW.ProgrammingFoundationShort.Lessons.Module09.Auftrag3_MediaHierarchy.MediaItem>());

    // ---- Modul 10 ----
    // Console.WriteLine(ZbW.ProgrammingFoundationShort.Lessons.Module10.Auftrag1_SucheVergleichen.SucheVergleichen.LinearSearch(new[] { 3, 1, 7, 5, 9 }, 7));
    // Application.Run(new ZbW.ProgrammingFoundationShort.Lessons.Module10.Auftrag2_BrowserVerlaufStack.BrowserVerlaufForm());
    // Console.WriteLine(ZbW.ProgrammingFoundationShort.Lessons.Module10.Auftrag3_SortierVisualisierung.SortierVisualisierung.BubbleSortSteps(new[] { 64, 34, 25, 12, 22, 11, 90 }));
  }
}

