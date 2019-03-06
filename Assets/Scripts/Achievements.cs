using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class Achievements : MonoBehaviour
{
    public Animator animator1; //Animators 
    public Animator animator2;
    public Animator animator3;
    public Animator animator4;
    public Animator animator5;
    public Animator animator6;
    public bool startanimation1 = false; //bool för om animationen ska starta eller inte.
    public bool startanimation2 = false;
    public bool startanimation3 = false;
    public bool startanimation4 = false;
    public bool startanimation5 = false;
    public bool startanimation6 = false;
    public Shop shop; 
    public int points; //int för antal poäng
    public event Action Dedication;// Events för alla achievements
    public event Action Slurper;
    public event Action Auto;
    public event Action Buy;
    public event Action Each;
    public event Action Half;
    // Start is called before the first frame update
    void Start()
    {
        Dedication += StartAnimation1; //Om man får en achievement startar animationen för den achievementen.
        Slurper += StartAnimation2;
        Auto += StartAnimation3;
        Buy += StartAnimation4;
        Each += StartAnimation5;
        Half += StartAnimation6;
    }

    // Update is called once per frame
    void Update()
    {
        shop = GameObject.FindGameObjectWithTag("shop").GetComponent<Shop>(); // Gör så man kan komma åt Shop scriptet 
        points = GameObject.FindGameObjectWithTag("score").GetComponent<Points>().score; // Kommer åt Points scriptet
        if (points >=1 && PlayerPrefs.GetInt("achievement1gotten")==0) //Om man når kraven för achievementen så får man det. Gäller alla nedan ner till if(startanim...
        {
            Dedication?.Invoke();
        }
        
        if (points >=10 && PlayerPrefs.GetInt("achievement2gotten")==0)
        {
            Slurper?.Invoke();
        }

        if (shop.Clicker >= 1 && PlayerPrefs.GetInt("achievement3gotten")==0)
        {
            Auto?.Invoke();
        }
        if (shop.Clicker >= 1 ||shop.CentupleClicker >= 1 || shop.DecupleClicker >= 1||shop.TenXClicker >= 1 ||shop.doubleClicker >= 1 || shop.HundredXClicker >=1 )
        {
            if (PlayerPrefs.GetInt("achievement4gotten") == 0)
                Buy?.Invoke();
        }
        if (shop.Clicker >= 1 && shop.CentupleClicker >= 1 && shop.DecupleClicker >= 1 && shop.TenXClicker >= 1 && shop.doubleClicker >= 1 && shop.HundredXClicker >= 1 && PlayerPrefs.GetInt("achievement5gotten") == 0)
        {
            Each.Invoke();
        }
        if (points >= 50000000 && PlayerPrefs.GetInt("achievement6gotten")==0)
        {
            Half.Invoke();
        }
        if (startanimation1 == true) // om man animationen startat så sätter den achievementgotten till 1 och spelar upp animationen.
        {
            animator1.SetBool("start",true);
            StartCoroutine(AnimatorWait());
            PlayerPrefs.SetInt("achievement1gotten", 1);
        }
        if (startanimation2 == true)
        {
            animator2.SetBool("start", true);
            StartCoroutine(AnimatorWait2());
            PlayerPrefs.SetInt("achievement2gotten", 1);
        }
        if (startanimation3 == true)
        {
            animator3.SetBool("start", true);
            StartCoroutine(AnimatorWait3());
            PlayerPrefs.SetInt("achievement3gotten",1 );
        }
        if (startanimation4 == true)
        {
            animator4.SetBool("start", true);
            StartCoroutine(AnimatorWait4());
            PlayerPrefs.SetInt("achievement4gotten", 1);
        }
        if (startanimation5 == true)
        {
            animator5.SetBool("start",true);
            StartCoroutine(AnimatorWait5());
            PlayerPrefs.SetInt("achievement5gotten", 1);
        }
        if (startanimation6 == true)
        {
            animator6.SetBool("start", true);
            StartCoroutine(AnimatorWait6());
            PlayerPrefs.SetInt("achievement6gotten", 1);
        }
    }
    public void StartAnimation1() // Funktion för animation
    {
        startanimation1 = true;
    }

    public void StartAnimation2()
    {
        startanimation2 = true;
    }
    public void StartAnimation3()
    {
        startanimation3 = true;
    }
    public void StartAnimation4()
    {
        startanimation4 = true;
    }
    public void StartAnimation5()
    {
        startanimation5 = true;
    }
    public void StartAnimation6()
    {
        startanimation6 = true;
    }
    
    public IEnumerator AnimatorWait6()  // Visar animationen och fäster den i tre sekunder innan den åker ner igen.
    {
        yield return new WaitForSeconds(3f);
        animator6.SetTrigger("return");
        animator6.SetBool("start", false);
    }
    
    public IEnumerator AnimatorWait5()
    {
        yield return new WaitForSeconds(3f);
        animator5.SetTrigger("return");
        animator5.SetBool("start", false);
    }
    public IEnumerator AnimatorWait4()
    {
        yield return new WaitForSeconds(3f);
        animator4.SetTrigger("return");
        animator4.SetBool("start", false);
    }
    public IEnumerator AnimatorWait3()
    {
        yield return new WaitForSeconds(3f);
        animator3.SetTrigger("return");
        animator3.SetBool("start", false);
    }
    public IEnumerator AnimatorWait2()
    {
        yield return new WaitForSeconds(3f);
        animator2.SetTrigger("return");
        animator2.SetBool("start", false);
    
    }
    public IEnumerator AnimatorWait()
    {
        yield return new WaitForSeconds(3f);
        animator1.SetTrigger("return");
        animator1.SetBool("start", false);
    }
}
