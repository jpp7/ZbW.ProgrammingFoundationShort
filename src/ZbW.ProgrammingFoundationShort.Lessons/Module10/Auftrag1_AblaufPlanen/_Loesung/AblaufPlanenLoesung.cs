namespace ZbW.ProgrammingFoundationShort.Lessons.Module10.Auftrag1_AblaufPlanen._Loesung;

public static class AblaufPlanenLoesung
{
  public static string BuildFlowchart()
  {
    return """
           Start
             |
           Punkte erhalten
             |
           Punkte gültig?
             |-- nein --> Ungültig --> Ende
             |
            ja
             |
           Punkte >= 80?
             |-- ja --> Sehr gut --> Ende
             |
            nein
             |
           Punkte >= 60?
             |-- ja --> Bestanden --> Ende
             |
            nein
             |
           Nicht bestanden
             |
           Ende
           """;
  }

  public static string BuildTodoDraft()
  {
    return """
           static string EvaluatePoints(int points)
           {
               // TODO: Gültigkeit prüfen
               // TODO: Sehr gute Punktzahl prüfen
               // TODO: Bestandene Punktzahl prüfen
               // TODO: Sonst nicht bestanden zurückgeben
           }
           """;
  }
}