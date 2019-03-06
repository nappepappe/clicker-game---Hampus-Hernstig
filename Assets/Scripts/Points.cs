using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public int score;      //int för score 
    Text textpoints; //Poängtext

    private void Start() //Sätter score till score
    {

        score = PlayerPrefs.GetInt("Score");
    }
    void Awake() // Sätter score till noll på awake
    {

        textpoints = GetComponent<Text>();    
        score = 0;
    }

    void Update() // sätter score text till din score.
    {    
        textpoints.text = "Slurps: " + score;
        PlayerPrefs.SetInt("Score", score);
        
    }

  
}
