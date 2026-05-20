namespace ZbW.ProgrammingFoundationShort.Lessons.Module10.Auftrag1_AblaufPlanen;

public static class AblaufPlanen
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

  public static string EvaluatePointsDraft(int points)
  {
    // TODO: Prüfen, ob points kleiner als 0 oder grösser als 100 ist.
    // TODO: Prüfen, ob points mindestens 80 ist.
    // TODO: Prüfen, ob points mindestens 60 ist.
    // TODO: Sonst "Nicht bestanden" zurückgeben.
    return "TODO";
  }
}