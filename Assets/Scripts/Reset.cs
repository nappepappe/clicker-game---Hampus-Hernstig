using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    public void Update()
    {
        if (Input.GetKey(KeyCode.R)) // Om man trycker R så startar den funktionen resetall.
        {
            resetall();
        }
    }
    public void resetall() // Funktion som resettar alla playerprefs.
    {
            PlayerPrefs.SetInt("Score", 0);
            PlayerPrefs.SetInt("achievement1gotten", 0);
            PlayerPrefs.SetInt("achievement2gotten", 0);
            PlayerPrefs.SetInt("achievement3gotten", 0);
            PlayerPrefs.SetInt("achievement4gotten", 0);
            PlayerPrefs.SetInt("achievement5gotten", 0);
            PlayerPrefs.SetInt("achievement6gotten", 0);
            PlayerPrefs.SetInt("Clicker", 0);
            PlayerPrefs.SetInt("CentupleClicker", 0);
            PlayerPrefs.SetInt("DecupleClicker", 0);
            PlayerPrefs.SetInt("TenXClicker", 0);
            PlayerPrefs.SetInt("doubleClicker", 0);
            PlayerPrefs.SetInt("HundredXClicker", 0);
        }

}
