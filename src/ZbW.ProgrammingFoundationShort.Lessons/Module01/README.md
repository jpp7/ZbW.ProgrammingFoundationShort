# Modul 01 – Variablen, Datentypen & Operatoren (Lessons)

> **In-Class Aufträge** | Programming Foundation Short | ZbW

---

## Lernziele

- Primitive Datentypen (`int`, `double`, `bool`, `string`, `decimal`) kennen und anwenden
- `TryParse` zur sicheren Eingabekonvertierung einsetzen
- Konstanten mit `const` definieren
- Einfache WinForms-Apps und Konsolen-Apps erstellen

---

## Aufträge

| Nr. | Titel             | Typ      | Schwierigkeit | Zeit     |
|-----|-------------------|----------|---------------|----------|
| 1   | Taschenrechner    | Konsole  | ⭐             | ~10 Min. |
| 2   | Temperaturrechner | WinForms | ⭐⭐            | ~10 Min. |
| 3   | Datentyp-Quiz     | Konsole  | ⭐⭐⭐           | ~10 Min. |

---

## Wie starte ich eine Form?

Öffne `Program.cs` im Lessons-Projekt und kommentiere die gewünschte Zeile ein:

```csharp
// Auftrag 2: Temperaturrechner
Application.Run(new Module01.Auftrag2_Temperaturrechner.TemperaturrechnerForm());
```

Für Konsolen-Aufträge (1 und 3): Rufe `Start()` auf und leite die Ausgabe auf die Konsole.

---

## Hinweise

- Alle TODOs sind nummeriert — bearbeite sie der Reihe nach.
- `throw new NotImplementedException(...)` zeigt dir an, wo noch Code fehlt.
- Die `Designer.cs`-Datei musst du **nicht** anfassen — sie enthält nur das Layout.
