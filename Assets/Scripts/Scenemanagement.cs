using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Scenemanagement : MonoBehaviour
{
    public void exit() //Funktion för att stänga av spelet.
    {
        Application.Quit();
    }
    public void achievements() // Laddar scenen achievements
    {
        SceneManager.LoadScene("Achievements");
    }
    public void back() // Laddar scenen Main
    {
        SceneManager.LoadScene("Main");
    }
}
