using System;

using FluentAssertions;

using NUnit.Framework;

namespace TestStyles.C_ContextSpecification;

// Test Class per Szenario.
// Aus meiner Sicht das was Gherkin am nächsten kommt, ohne darüber nachdenken
// zu müssen was eine "Fixture" ist.
public class Wenn_ein_menschlicher_Benutzer_eine_Schulungsanfrage_stellt
{
  bool _nachrichtAnKundeVersendet;
  bool _nachrichtAnBackofficeVersendet;
  bool _aufgabeErzeugt;

  [SetUp]
  public void SetUp()
  {
    // Arrange.
    // Act.
    _nachrichtAnKundeVersendet = true;
    _nachrichtAnBackofficeVersendet = true;
    _aufgabeErzeugt = true;
  }

  // In >95% der Fälle: 1 Assert pro [Test]-Methode.

  [Test]
  public void soll_Nachricht_an_Kunde_versenden()
  {
    Assert.IsTrue(_nachrichtAnKundeVersendet);
  }

  [Test]
  public void soll_Nachricht_an_Backoffice_versenden()
  {
    Assert.IsTrue(_nachrichtAnBackofficeVersendet);
  }

  [Test]
  public void soll_Aufgabe_erzeugen()
  {
    Assert.IsTrue(_aufgabeErzeugt);
  }
}

public class Wenn_ein_Bot_eine_Schulungsanfrage_stellt
{
  bool _nachrichtAnBackofficeVersendet;
  bool _nachrichtAnBackofficeEnthältFreigabe;
  DateTime _freigabeMöglichBis;
  readonly DateTime HeuteIn30Tagen = DateTime.Now.AddDays(30);

  [SetUp]
  public void SetUp()
  {
    // Arrange.
    // Act.
    _nachrichtAnBackofficeVersendet = true;
    _nachrichtAnBackofficeEnthältFreigabe = true;
    _freigabeMöglichBis = HeuteIn30Tagen;
  }

  [Test]
  public void soll_Nachricht_an_Backoffice_versenden()
  {
    _nachrichtAnBackofficeVersendet.Should().BeTrue();
  }

  [Test]
  public void soll_Nachricht_an_Backoffice_mit_Freigabe_versenden()
  {
    _nachrichtAnBackofficeEnthältFreigabe.Should().BeTrue();
  }

  [Test]
  public void besteht_die_Möglichkeit_der_Freigabe_für_30_Tage()
  {
    _freigabeMöglichBis.Should().Be(HeuteIn30Tagen);
  }
}

public class Wenn_ein_durch_einen_Bot_gestellte_eine_Schulungsanfrage_innerhalb_von_30_Tagen_freigegeben_wird
{
  [SetUp]
  public void SetUp()
  {
    // Arrange.
    // Act.
  }

  [Test]
  public void soll_Nachricht_an_Kunde_versenden()
  {
    Assert.Inconclusive("Not yet implemented");
  }

  [Test]
  public void soll_Aufgabe_erzeugen()
  {
    Assert.Inconclusive("Not yet implemented");
  }
}

public class Wenn_ein_durch_einen_Bot_gestellte_eine_Schulungsanfrage_nach_30_Tagen_freigegeben_wird
{
  [SetUp]
  public void SetUp()
  {
    // Arrange.
    // Act.
  }

  [Test]
  public void soll_keine_Nachricht_an_Kunde_versendet_werden()
  {
    Assert.Inconclusive("Not yet implemented");
  }

  [Test]
  public void soll_keine_Aufgabe_erzeugt_werden()
  {
    Assert.Inconclusive("Not yet implemented");
  }
}
