using System.Text;

namespace ZbW.ProgrammingFoundationShort.Lessons.Module09.Auftrag1_AnimalHierarchy._Loesung;

public class AnimalLoesung
{
  public string Name { get; set; } = "";
  public int Age { get; set; }

  public virtual string MakeSound()
  {
    return "...";
  }

  public override string ToString()
  {
    return $"{Name}, {Age} Jahre";
  }
}

public sealed class DogLoesung : AnimalLoesung
{
  public string Breed { get; set; } = "";

  public override string MakeSound()
  {
    return "Wuff!";
  }

  public override string ToString()
  {
    return $"{base.ToString()}, {Breed}";
  }
}

public sealed class CatLoesung : AnimalLoesung
{
  public override string MakeSound()
  {
    return "Miau!";
  }
}

public sealed class BirdLoesung : AnimalLoesung
{
  public override string MakeSound()
  {
    return "Piep!";
  }
}

public static class AnimalHierarchyLoesung
{
  public static string RunDemo()
  {
    List<AnimalLoesung> animals = new List<AnimalLoesung>
    {
      new DogLoesung { Name = "Bello", Age = 3, Breed = "Golden Retriever" },
      new DogLoesung { Name = "Luna", Age = 5, Breed = "Labrador" },
      new CatLoesung { Name = "Mia", Age = 2 },
      new CatLoesung { Name = "Nala", Age = 4 },
      new BirdLoesung { Name = "Kiki", Age = 1 },
      new BirdLoesung { Name = "Rio", Age = 2 }
    };

    StringBuilder builder = new StringBuilder();

    foreach (AnimalLoesung animal in animals)
      builder.AppendLine($"{animal}: {animal.MakeSound()}");

    return builder.ToString();
  }
}
