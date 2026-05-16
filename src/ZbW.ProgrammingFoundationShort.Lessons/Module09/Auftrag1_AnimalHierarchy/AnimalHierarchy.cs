namespace ZbW.ProgrammingFoundationShort.Lessons.Module09.Auftrag1_AnimalHierarchy;

public class Animal
{
  public string Name { get; set; } = "";
  public int Age { get; set; }

  public virtual string MakeSound()
  {
    // TODO: Standardsound zurückgeben.
    return "";
  }

  public override string ToString()
  {
    // TODO: Name und Alter formatieren.
    return "";
  }
}

public sealed class Dog : Animal
{
  public string Breed { get; set; } = "";

  public override string MakeSound()
  {
    // TODO: Hundesound zurückgeben.
    return "";
  }
}

public sealed class Cat : Animal
{
  public override string MakeSound()
  {
    // TODO: Katzensound zurückgeben.
    return "";
  }
}

public sealed class Bird : Animal
{
  public override string MakeSound()
  {
    // TODO: Vogelsound zurückgeben.
    return "";
  }
}

public static class AnimalHierarchy
{
  public static string RunDemo()
  {
    List<Animal> animals = new List<Animal>();

    // TODO: Je 2 Hunde, Katzen und Vögel hinzufügen.
    // TODO: foreach über animals, MakeSound() polymorphisch aufrufen.

    return "";
  }
}
