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
