# SussyFighters

## Aufgabenstellung
Aus persönlichem Interesse, aber auch als Auftrag, haben wir unser erstes Spiel auf Unity programmiert. Wir haben dieses Projekt in der Gruppenarbeit gemacht, wobei dieses das erste Gruppenportfolio ist. Bei diesem Portfolio gehen wir mehr in die Richtung, wie einzelne Aspekte des Programms funktionieren und wie man Unity gebraucht.
- Der Leser erfährt, was Unity ist.
- Der Leser lernt, wie man eine Szene macht.
- Der Leser lernt, was Buttons sind und was man mit diesen machen kann.

## Inhalt 🧠
### Ein Spiel mit Unity
Unity ist ein Programm, mit dem man Spiele sehr einfach mit C# programmieren kann. Um Unity zu installieren, kann man einfach auf ihre Webseite gehen und die Schritte dort befolgen: https://unity.com/

Mit der Szene kann man verschiedene Fenster (Szenen) in einem Spiel machen, das ist wie, als würde ich bei einer Webseite auf eine Unterseite gehen, welche bei Unity dann einfach eine weitere Szene wäre. Eine Szene fügt man ein, indem man, wenn man ein neues Spiel erstellt hat, zu den Assets geht, mit der rechten Maustaste darauf drückt und "Create" drückt und dann "Scene" auswählt. Mit Doppelklick auf die nun erstellte Datei kann man sie öffnen.

Nun zu den Buttons, man kann sie hinzufügen, indem man oben Links zum Fenster "Hierarchy" geht, Rechtsklick macht und "UI" auswählt und danach auf Button, nun ist der Button auf der Szene abgebildet. Der Button hat die Eigenschaft, dass man bei Knopfdruck eine Funktion hinzufügen kann, zum Beispiel beim Code verlinkt: void StartFight(){...}
Das macht, dass das Spiel mit der richtigen Szene startet.

### Code
```C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharSelection : MonoBehaviour
{
    private string selectedCharacterP1 = "Amegus";
    private string selectedCharacterP2 = "Amegus";

    public Text textPlayer1;
    public Text textPlayer2;

    public void SelectAmegusP1()
    {
        selectedCharacterP1 = "Amegus";
        textPlayer1.text = "PLAYER 1: " + selectedCharacterP1; 
    }
    public void SelectAmegusP2()
    {
        selectedCharacterP2 = "Amegus";
        textPlayer2.text = "PLAYER 2: " + selectedCharacterP2;
    }
    public void SelectStailinP1()
    {
        selectedCharacterP1 = "Stailn";
        textPlayer1.text = "PLAYER 1: " + selectedCharacterP1;
    }
    public void SelectStalinP2()
    {
        selectedCharacterP2 = "Stailn";
        textPlayer2.text = "PLAYER 2: " + selectedCharacterP2;
    }

    public void SelectOwOP1()
    {
        selectedCharacterP1 = "OwO";
        textPlayer1.text = "PLAYER 1: " + selectedCharacterP1;
    }
    public void SelectOwOP2()
    {
        selectedCharacterP2 = "OwO";
        textPlayer2.text = "PLAYER 2: " + selectedCharacterP2;
    }
    public void StartFight()
    {
        if (selectedCharacterP1 == "Amegus" && selectedCharacterP2 == "Amegus")
            SceneManager.LoadScene(2);
        else if (selectedCharacterP1 == "Amegus" && selectedCharacterP2 == "OwO")
            SceneManager.LoadScene(5);
        else if (selectedCharacterP1 == "Amegus" && selectedCharacterP2 == "Stailn")
            SceneManager.LoadScene(6);
        else if (selectedCharacterP1 == "OwO" && selectedCharacterP2 == "Amegus")
            SceneManager.LoadScene(7);
        else if (selectedCharacterP1 == "OwO" && selectedCharacterP2 == "OwO")
            SceneManager.LoadScene(8);
        else if (selectedCharacterP1 == "OwO" && selectedCharacterP2 == "Stailn")
            SceneManager.LoadScene(9);
        else if (selectedCharacterP1 == "Stailn" && selectedCharacterP2 == "Amegus")
            SceneManager.LoadScene(10);
        else if (selectedCharacterP1 == "Stailn" && selectedCharacterP2 == "OwO")
            SceneManager.LoadScene(11);
        else if (selectedCharacterP1 == "Stailn" && selectedCharacterP2 == "Stailn")
            SceneManager.LoadScene(12);
        else
            SceneManager.LoadScene(2);
    }
}

```
### Video vom Spiel
[![](https://i.imgur.com/Es7ZCve.jpg)](https://youtu.be/7_sjSURV5s8)
## Reflexion ✨
Wir fanden es gut, dass wir in der Gruppe gearbeitet haben, da uns die Grenzen und Möglichkeiten klar wurden. Zuvor haben wir in Gruppenarbeit gearbeitet, jedoch waren wir nicht wirklich voneinander abhängig. Mit Unity waren wir voneinander abhängig, da jeder wichtige Bausteine zur Funktionalität des Programmes hatte.
Ich fand nicht so gut, dass wir nicht in der "richtigen Reihenfolge" gearbeitet haben, damit will ich zeigen, dass wir zuerst mit dem Design gearbeitet haben und erst nacher mit den Funktionen. Da wir uns nicht zuerst mit den Funktionen beschäftigt haben, haben wir zu viel Zeit mit dem Design verbraucht, wobei wir meist sogar zu viele Animationen hatten und somit unnötig Zeit verschwendet haben.  
Als Verbesserung könnte man zuerst sich mit den Hauptgrundlagen des Spiels beschäftigen und sich eine Vision machen zu was es braucht und was die Limite ist.
Zum Beispiel kann man sich Notizen auf einem Word-Dokument machen und schauen, dass das Hauptspiel funktioniert, anstatt dass man sich mit einer anderen Szene lange beschäftigt, aber dann am Schluss kein Spiel hat.

Am 25.1.2022 hat Matteo ein Portfolio gemacht, wo er als Verbesserungsvorschlag hatte, dass man sich eine Mindmap mit XMind macht und seine Ideen somit sammelt, wir haben in unserem Falle mit einer einfachen Textdatei gearbeitet und haben so unsere Ideen gesammelt und sortiert.
Wir haben einige Zeit sparen können beim Programmieren, da wir wussten, was man programmieren soll und wie man genau den Titel zum Beispiel macht.

## Verifikation ✅
Man lernt was Unity ist im Inhalt und dann "Ein Spiel mit Unity" ganz oben. 
Man findet heraus, wie man eine Szene macht im Inhalt, "Ein Spiel mit Unity" und dann der Teil in der Mitte.
Um über die Buttons herauszufinden, kann man zum Inhalt nochmal gehen, "Ein Spiel mit Unity" und dann der untere Teil.

