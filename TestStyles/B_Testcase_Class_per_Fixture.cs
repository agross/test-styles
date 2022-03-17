using FluentAssertions;

using NUnit.Framework;

namespace TestStyles.B_TestcaseClassPerFixture;

// Test Class per Fixture.
// 1 Klasse pro Kontext (hier: Mensch/Bot) der Anfrage.
public class Menschliche_Schulungsanfrage_Tests
{
  [Test]
  public void Menschlicher_Benutzer_stellt_Anfrage__soll__Nachricht_an_Kunde_und_Backoffice_versenden_und_Aufgabe_erzeugen()
  {
    // Arrange.
    // Act.
    var nachrichtAnKundeVersendet = true;
    var nachrichtAnBackofficeVersendet = true;
    var aufgabeErzeugt = true;

    // Assert.
    Assert.IsTrue(nachrichtAnKundeVersendet);
    Assert.IsTrue(nachrichtAnBackofficeVersendet);
    Assert.IsTrue(aufgabeErzeugt);
  }
}

public class Schulungsanfrage_durch_Bot_Tests
{
  // Folgend: geteiltes Setup dieser Fixture.
  Anfrage _botAnfrage;

  [SetUp]
  public void SetUp()
  {
    _botAnfrage = ErzeugeAnfrageDurchBot();
  }

  Anfrage ErzeugeAnfrageDurchBot()
  {
    return new Anfrage();
  }

  [Test]
  public void Bot_stellt_Anfrage__soll__Nachricht_an_Backoffice_zur_Freigabe_innerhalt_von_30_Tagen_versenden()
  {
    // Arrange.
    // Act.
    var nachrichtAnBackofficeVersendet = true;
    var nachrichtAnBackofficeEnthältFreigabe = true;
    var heuteIn30Tagen = DateTime.Now.AddDays(30);
    var freigabeMöglichBis = heuteIn30Tagen;

    // Assert (hier mit Fluent Assertions - wie unterscheiden sich die Fehlermeldungen?).
    nachrichtAnBackofficeVersendet.Should().BeTrue();
    nachrichtAnBackofficeEnthältFreigabe.Should().BeTrue();
    freigabeMöglichBis.Should().Be(heuteIn30Tagen);
  }

  [Test]
  public void Freigabe_innerhalb_von_30_Tagen__soll__Nachricht_an_Kunde_versenden_und_Aufgabe_erzeugen()
  {
    // ...
  }

  [Test]
  public void Freigabe_nach_30_Tagen__soll__keine_Nachricht_an_Kunde_versenden_und_keine_Aufgabe_erzeugen()
  {
    // Wie kann man feststellen, dass etwas nicht passiert ist?
  }
}

class Anfrage
{
}
