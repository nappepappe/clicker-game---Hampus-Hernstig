using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievementScreen : MonoBehaviour
{
    public string AchievementName; // Namnet för achievementgotten
    public Image Image1; //Image
  
    // Start is called before the first frame update
    void Start()
    {
        Image1.color = new Color32(75, 75, 75, 255); //Sätter färgen när man startar.
    }

    // Update is called once per frame
    void Update()
    {
       
        if (PlayerPrefs.GetInt(AchievementName) == 1)// Om man fått achievementen så ändras färgen.
        {
            Image1.color = new Color32(255, 255, 255, 255);
        }
    }
}
