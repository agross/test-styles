using System;

using FluentAssertions;

using NUnit.Framework;

namespace TestStyles.A_TestcaseClassPerFeature;

// Test Class per Feature.
// Alle Szenarios in einer Klasse.
public class Schulungsanfrage_Feature_Tests
{
  [Test]
  // Schema: Methodenname_Szenario
  //
  // public void Post_menschlicher_Benutzer()
  //
  // TODO: "HTTP-POST" ist nicht fachlich. Was passieren sollte ist nicht ersichtlich.

  // Schema: Aktion_Szenario
  //
  // public void Anfrage_Verarbeiten_wenn_durch_menschlichen_Benutzer_abgesendet()
  //
  // TODO: Was bedeutet "Verarbeiten"? Auch gern gesehen: "Should work".

  // Schema: Erwartung_Szenario
  //
  // public void Sendet_Benachrichtigungen_und_erzeugt_Aufgabe_wenn_Anfrage_durch_menschlichen_Benutzer_abgesendet()
  //
  // TODO: Yoda-esk.

  // Schema: Szenario__soll__Erwartung:
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
