# https://docs.specflow.org/projects/specflow/en/latest/Gherkin/Gherkin-Reference.html

Funktionalität: Kunden können Schulungen anfragen

  Als Kunde kann ich eine Schulung zu einem Thema anfragen,
  sodass ein Angebot für mich erstellt wird.

  Szenario: Anfrage von einem menschlichen Benutzer

    # Arrange.
    Gegeben sei das ausgefüllte Anfrageformular
    Gegeben sei die Spamprüfung die einen menschlichen Benutzer ermittelt
    # Act.
    Wenn das Formular abgesendet wird
    # Assert.
    Dann wird dem Kunden eine Benachrichtigung über den Empfang der Anfrage zugesendet
    Dann wird das Backoffice über die Anfrage informiert
    Dann wird eine Aufgabe für das Backoffice erfasst werden

  Szenario: Anfrage von einem Bot

    # Wiederholungen von "Gegeben sei", "Wenn" und "Dann" kann durch "Und" ersetzt werden.
    # Sprachlich manchmal durchaus fragwürdig wie man sieht.
    # Arrange.
    Gegeben sei das ausgefüllte Anfrageformular
    Und die Spamprüfung die einen Bot ermittelt
    # Act.
    Wenn das Formular abgesendet wird
    # Assert.
    Dann das Backoffice über die Anfrage mit der Möglichkeit zur Freigabe informiert
    Dann besteht die Möglichkeit der Freigabe für 30 Tage

  Szenario: Anfrage von einem menschlichen Benutzer der als Bot identifiziert wurde wird innerhalb von 30 Tagen freigegeben

    Gegeben sei eine Anfrage von einem Bot am 01.02.2022
    Wenn die Freigabe am 03.02.2022 erfolgt
    Dann wird dem Kunden eine Benachrichtigung über den Empfang der Anfrage zugesendet
    Und wird eine Aufgabe für das Backoffice erfasst werden

  Szenario: Anfrage von einem menschlichen Benutzer der als Bot identifiziert wurde wird nach > 30 Tagen freigegeben

    Gegeben sei eine Anfrage von einem Bot am 01.02.2022
    Wenn die Freigabe am 31.12.2022 erfolgt
    Dann wird dem Kunden keine Benachrichtigung zugesendet
    Und wird keine Aufgabe für das Backoffice erfasst werden
