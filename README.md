# ZbW.ProgrammingFoundationShort

Kurzversion des ZbW-Kurses **Programming Foundation** mit WinForms- und Konsolenübungen.

## Struktur

```text
src/
├── ZbW.ProgrammingFoundationShort.sln
├── Directory.Build.props
├── ZbW.ProgrammingFoundationShort.Lessons/
└── ZbW.ProgrammingFoundationShort.Challenges/
```

## Projekte

| Projekt | Inhalt |
|---|---|
| `ZbW.ProgrammingFoundationShort.Lessons` | In-Class-Aufträge mit TODO-Stubs und `_Loesung` direkt daneben |
| `ZbW.ProgrammingFoundationShort.Challenges` | Hausaufgaben als vollständige Musterlösungen |

## Module

| Modul | Thema | Lessons | Challenges |
|---|---|---:|---:|
| 01 | Variablen, Datentypen & Operatoren | 3 | 4 |
| 02 | Kontrollstrukturen | 3 | 4 |
| 03 | Schleifen, Random & Fehlerbehandlung | 3 | 4 |
| 04 | Arrays & Methoden | 3 | 4 |
| 05 | Collections & Methoden Vertiefung | 3 | 4 |
| 06 | Klassen & Objekte | 3 | 4 |
| 07 | Referenzen & Vergleiche | 3 | 4 |
| 08 | Statische Elemente | 3 | 4 |
| 09 | Vererbung & Polymorphismus | 3 | 4 |
| 10 | Algorithmen & Datenstrukturen | 3 | 4 |

## Start

Öffne `src/ZbW.ProgrammingFoundationShort.sln` in Visual Studio oder Rider.

In `Program.cs` des jeweiligen Projekts ist pro Aufgabe eine Startzeile vorbereitet. Es soll jeweils nur eine `Application.Run(...)`-Zeile aktiv sein.

Beispiel:

```csharp
Application.Run(new ZbW.ProgrammingFoundationShort.Challenges.Module08.Aufgabe1_MathBibliothek.MathBibliothekForm());
```

## Build

```powershell
dotnet build src\ZbW.ProgrammingFoundationShort.sln --ignore-failed-sources
```

Der Zusatz `--ignore-failed-sources` ist nützlich, falls lokal ein privater NuGet-Feed konfiguriert ist, der ohne Anmeldung Warnungen erzeugt.
