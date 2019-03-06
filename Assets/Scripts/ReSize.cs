using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReSize : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindWithTag("Player")
       .GetComponent<Spaceclicker>()
       .Click += increaseSize;

        GameObject.FindWithTag("Player")
       .GetComponent<Spaceclicker>()
       .ClickUpp += decreaseSize;
    }

    void increaseSize()
    {
        transform.localScale = new Vector3(2f, 2f, 1f);
        GetComponent<SpriteRenderer>().color = new Color(255, 0, 0, 255);
    }

    void decreaseSize()
    {
        transform.localScale += new Vector3(1f, 1f, 1f);
        GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 255);
    }
}
