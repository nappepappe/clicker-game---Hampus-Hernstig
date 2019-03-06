using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Shop : MonoBehaviour
{
    public int CentupleClicker; //Ints för hur många av varje upgrade man har.
    public int DecupleClicker;
    public int TenXClicker;
    public int Clicker;
    public int doubleClicker;
    public int HundredXClicker;
    private float clickerTimer; //Timet för autoclickers
    public Text CentupleClickersOwned; //Text för hur många av varje upgrade man har
    public Text DecupleClickersOwned;
    public Text TenXClickersOwned;
    public Text HundredXClickersOwned;
    public Text clickersOwned;
    public Text doubleClickersOwned;
    public GameObject score; //score
    private Points points;//points
    public GameObject player;//playern
    private Spaceclicker spaceclicker; // Gör så man kommer åt spacecliker scriptet. 

    public void Start()
    {
        Clicker = PlayerPrefs.GetInt("Clicker"); //sätter alla upgrades till mängden uprgades man har.
        CentupleClicker = PlayerPrefs.GetInt("CentupleClicker");
        DecupleClicker = PlayerPrefs.GetInt("DecupleClicker");
        TenXClicker = PlayerPrefs.GetInt("TenXClicker");
        doubleClicker = PlayerPrefs.GetInt("doubleClicker");
        HundredXClicker = PlayerPrefs.GetInt("HundredXClicker");
        clickerTimer = 1f; //Timern är en sekund.
    }

    public void Update()
    {
        PlayerPrefs.SetInt("Clicker", Clicker); //PlayerPrefs sätter intsen till respektive upgrades antal.
        PlayerPrefs.SetInt("CentupleClicker", CentupleClicker);
        PlayerPrefs.SetInt("DecupleClicker", DecupleClicker);
        PlayerPrefs.SetInt("TenXClicker", TenXClicker);
        PlayerPrefs.SetInt("doubleClicker", doubleClicker);
        PlayerPrefs.SetInt("HundredXClicker", HundredXClicker);
        CentupleClickersOwned.text = CentupleClicker + " Owned"; //skiver ut mängden ägda av varje upgrade.
        HundredXClickersOwned.text = HundredXClicker + " Owned";
        DecupleClickersOwned.text = DecupleClicker + " Owned";
        TenXClickersOwned.text = TenXClicker + " Owned";
        clickersOwned.text = Clicker + " Owned";
        doubleClickersOwned.text = doubleClicker + " Owned";
        clickerTimer -= Time.deltaTime; //sätter clickertimer
        if (clickerTimer <= 0) //om klickertimer är mindre eller lika med 0 så sätter den clickertimer till 0.
        {
            clickerEachSecond();
            clickerTimer = 1;
        }
    }
    public void doubleclicker() //Nedan är funtioner för alla upgrades
    {
        
        points = score.GetComponent<Points>();
        if (points.score >= 100)
        {
            doubleClicker += 1;
        spaceclicker = player.GetComponent<Spaceclicker>();
        spaceclicker.scoreValue += 1;
        
        points.score -= 100;
            
        }
           
    }

    public void decupleclicker()
    {

        points = score.GetComponent<Points>();
        if (points.score >= 500)
        {
            DecupleClicker += 1;
            spaceclicker = player.GetComponent<Spaceclicker>();
            spaceclicker.scoreValue += 10;

            points.score -= 500;

        }

    }

    public void Centuplelicker()
    {

        points = score.GetComponent<Points>();
        if (points.score >= 2500)
        {
            CentupleClicker += 1;
            spaceclicker = player.GetComponent<Spaceclicker>();
            spaceclicker.scoreValue += 100;

            points.score -= 2500;

        }

    }

    public void clicker()
    {
        points = score.GetComponent<Points>();
        if (points.score >= 10)
        {
            Clicker += 1;
            spaceclicker = player.GetComponent<Spaceclicker>();
            

            points.score -= 10;
        }
    }

    public void tenxclicker()
    {
        points = score.GetComponent<Points>();
        if (points.score >= 50)
        {
            TenXClicker += 1;
            spaceclicker = player.GetComponent<Spaceclicker>();


            points.score -= 50;
        }
    }

    public void hundredxclicker()
    {
        points = score.GetComponent<Points>();
        if (points.score >= 250)
        {
            HundredXClicker += 1;
            spaceclicker = player.GetComponent<Spaceclicker>();


            points.score -= 250;
        }
    }

    public void clickerEachSecond()
    {
        points = score.GetComponent<Points>();
        points.score += Clicker;
        points.score += TenXClicker * 10;
        points.score += HundredXClicker * 100;
    }

    public void victoryroyale()
    {
        points = score.GetComponent<Points>();
        if (points.score >= 10000000)
        {
            SceneManager.LoadScene("Victory");
        }
    }
    
}
