using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceclicker : MonoBehaviour
{
    public AudioSource click; //Ljud för klick.
    public GameObject score; //score
    public Points points; //päng
    public int scoreValue = 1; // Hur mycket ett score är värt.
    public event Action Click; // Event för när man klickar.
    public event Action ClickUpp; // Event för när man släpper musknappen.

    private void OnMouseDown() // När man klickar ner musknapp spelar den upp klickljud och invokear klick och sätter score.
    {
        click.Play();
        Click?.Invoke();
        points = score.GetComponent<Points>();
        points.score += scoreValue;

    }
    private void OnMouseUpAsButton() //När man släpper musknapp så invokear den ClickUpp
    {
        ClickUpp?.Invoke();
    }
   
}
