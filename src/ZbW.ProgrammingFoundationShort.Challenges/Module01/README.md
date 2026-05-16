# Modul 01 – Variablen, Datentypen & Operatoren (Challenges / Musterlösungen)

> **Hausaufgaben – Musterlösungen** | Programming Foundation Short | ZbW

---

## Aufgaben-Übersicht

| Nr. | Titel            | Schwierigkeit | Zeit     |
|-----|------------------|---------------|----------|
| 1   | BMI-Rechner      | ⭐             | ~45 Min. |
| 2   | Währungsrechner  | ⭐⭐            | ~75 Min. |
| 3   | Zahlen-Analyse   | ⭐⭐⭐           | ~90 Min. |
| 4   | Einheitenrechner | ⭐⭐⭐⭐ Bonus    | ~60 Min. |

---

## Wie starte ich eine Form?

Öffne `Program.cs` im Challenges-Projekt und kommentiere die gewünschte Zeile ein:

```csharp
Application.Run(new Module01.Aufgabe1_Bmi.BmiForm());
```

---

## Wichtige Konzepte in dieser Lösung

- `double.TryParse` / `decimal.TryParse` für sichere Eingabekonvertierung
- `const` für unveränderliche Umrechnungsfaktoren
- `MessageBox.Show` für Fehlermeldungen
- String-Interpolation: `$"{wert:F2}"`
- Modulo-Operator `%` (Aufgabe 3)
- `GroupBox` als Container-Steuerelement (Aufgabe 4)
