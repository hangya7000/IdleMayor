using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Base : MonoBehaviour
{
    //Feliratok
    public Text Idlemuscle;
    public Text Idlemusclepersec;
    public Text Perkatttext, Perkattartext;
    public Text  Benchlevelartext;
    public Text  pullupsartext;
    public Text  dumbellcurlartext;
    public Text  barbellcurlartext;
    public Text  dipsartext;
    public Text  tbarrowartext;
    public Text  pressesartext;
    public Text  deadliftartext;

    //Változók
    public static double muscle = 0, musclepersec = 0;
    public double benchlevel = 0, muscleperkattlevel = 1, tbarrowlevel = 0, pullupslevel = 0, dumbellcurllevel = 0;
    public double barbellcurllevel = 0, dipslevel = 0, presseslevel = 0, deadliftlevel = 0;
    public float  benchbuy = 50, muscleperkattbuy = 10, tbarrowbuy = 5000000, pullupsbuy = 500, dumbellcurlbuy = 5000;
    public float barbellcurlbuy = 50000, dipsbuy = 500000, pressesbuy = 50000000, deadliftbuy = 500000000;
    
    void Start()
    {
        Load();
    }

   
    void Update()
    {
        muscle += musclepersec * Time.deltaTime;
        musclepersec = szorBase.szorzo * (benchlevel + pullupslevel * 10 + dumbellcurllevel * 100 + barbellcurllevel * 1000 + dipslevel * 10000 + tbarrowlevel * 1000000 + presseslevel * 10000000 + deadliftlevel * 100000000);

        Idlemuscle.text = "" + muscle.ToString("F0");
        Idlemusclepersec.text = "" + musclepersec + "/sec";
        Perkatttext.text = "" + muscleperkattlevel + "/click";
        Perkattartext.text = "" + muscleperkattbuy + "muscle";
        Benchlevelartext.text = "" + benchbuy + "muscle";
        pullupsartext.text = "" + pullupsbuy + "muscle";
        dumbellcurlartext.text = "" + dumbellcurlbuy + "muscle";
        barbellcurlartext.text = "" + barbellcurlbuy + "muscle";
        dipsartext.text = "" + dipsbuy + "muscle";
        tbarrowartext.text = "" + tbarrowbuy + "muscle";
        pressesartext.text = "" + pressesbuy + "muscle";
        deadliftartext.text = "" + deadliftbuy + "muscle";
        Save();
    }

    public void Load()
    {

        // doubles

        muscle = double.Parse(PlayerPrefs.GetString("muscle"));
        musclepersec = double.Parse(PlayerPrefs.GetString("musclepersec"));
        benchlevel = double.Parse(PlayerPrefs.GetString("benchlevel"));
        muscleperkattlevel = double.Parse(PlayerPrefs.GetString("muscleperkattlevel"));
        tbarrowlevel = double.Parse(PlayerPrefs.GetString("tbarrowlevel"));
        pullupslevel = double.Parse(PlayerPrefs.GetString("pullupslevel"));
        dumbellcurllevel = double.Parse(PlayerPrefs.GetString("dumbellcurllevel"));
        barbellcurllevel = double.Parse(PlayerPrefs.GetString("barbellcurllevel"));
        dipslevel = double.Parse(PlayerPrefs.GetString("dipslevel"));
        presseslevel = double.Parse(PlayerPrefs.GetString("presseslevel"));
        deadliftlevel = double.Parse(PlayerPrefs.GetString("deadliftlevel"));

        //floats

        benchbuy = float.Parse(PlayerPrefs.GetString("benchbuy"));
        muscleperkattbuy = float.Parse(PlayerPrefs.GetString("muscleperkattbuy"));
        tbarrowbuy = float.Parse(PlayerPrefs.GetString("tbarrowbuy"));
        pullupsbuy = float.Parse(PlayerPrefs.GetString("pullupsbuy"));
        dumbellcurlbuy = float.Parse(PlayerPrefs.GetString("dumbellcurlbuy"));
        barbellcurlbuy = float.Parse(PlayerPrefs.GetString("barbellcurlbuy"));
        dipsbuy = float.Parse(PlayerPrefs.GetString("dipsbuy"));
        pressesbuy = float.Parse(PlayerPrefs.GetString("pressesbuy"));
        deadliftbuy = float.Parse(PlayerPrefs.GetString("deadliftbuy"));
    }

    public void Save()
    {
        
        //doubles

        PlayerPrefs.SetString("muscle", muscle.ToString());
        PlayerPrefs.SetString("musclepersec", musclepersec.ToString());
        PlayerPrefs.SetString("benchlevel", benchlevel.ToString());
        PlayerPrefs.SetString("muscleperkattlevel", muscleperkattlevel.ToString());
        PlayerPrefs.SetString("tbarrowlevel", tbarrowlevel.ToString());
        PlayerPrefs.SetString("pullupslevel", pullupslevel.ToString());
        PlayerPrefs.SetString("dumbellcurllevel", dumbellcurllevel.ToString());
        PlayerPrefs.SetString("barbellcurllevel", barbellcurllevel.ToString());
        PlayerPrefs.SetString("dipslevel", dipslevel.ToString());
        PlayerPrefs.SetString("presseslevel", presseslevel.ToString());
        PlayerPrefs.SetString("deadliftlevel", deadliftlevel.ToString());

        // doubles

        PlayerPrefs.SetString("benchbuy", benchbuy.ToString());
        PlayerPrefs.SetString("muscleperkattbuy", muscleperkattbuy.ToString());
        PlayerPrefs.SetString("tbarrowbuy", tbarrowbuy.ToString());
        PlayerPrefs.SetString("pullupsbuy", pullupsbuy.ToString());
        PlayerPrefs.SetString("dumbellcurlbuy", dumbellcurlbuy.ToString());
        PlayerPrefs.SetString("barbellcurlbuy", barbellcurlbuy.ToString());
        PlayerPrefs.SetString("dipsbuy", dipsbuy.ToString());
        PlayerPrefs.SetString("pressesbuy", pressesbuy.ToString());
        PlayerPrefs.SetString("deadliftbuy", deadliftbuy.ToString());
 
    }

    public void Kattint()
    {
        muscle += muscleperkattlevel;
    }

    //fejlesztések vásárlása

    public void Muscleeperkatt()
    {
        if (muscle >= muscleperkattbuy)
        {
            muscle -= muscleperkattbuy;
            muscleperkattlevel++;
            muscleperkattbuy = Mathf.Round(muscleperkattbuy * 1.3F);
        }
    }

    public void Benchlevel()
    {
        if (muscle >= benchbuy)
        {
            muscle -= benchbuy; 
            benchlevel++;
            benchbuy = Mathf.Round(benchbuy * 1.5F);
        }
    }



    public void Pullupslevel()
    {
        if (muscle >= pullupsbuy)
        {
            muscle -= pullupsbuy;
            pullupslevel++;
            pullupsbuy = Mathf.Round(pullupsbuy * 2F);
        }
    }

    public void DumbbellCurl()
    {
        if (muscle >= dumbellcurlbuy)
        {
            muscle -= dumbellcurlbuy;
            dumbellcurllevel++;
            dumbellcurlbuy = Mathf.Round(dumbellcurlbuy * 2.5F);
        }
    }

    public void BarbellCurl()
    {
        if (muscle >= barbellcurlbuy)
        {
            muscle -= barbellcurlbuy;
            barbellcurllevel++;
            barbellcurlbuy = Mathf.Round(barbellcurlbuy * 3F);
        }
    }

    public void TBarRowlevel()
    {
        if (muscle >= tbarrowbuy)
        {
            muscle -= tbarrowbuy;
            tbarrowlevel++;
            tbarrowbuy = Mathf.Round(tbarrowbuy * 3.5F);
        }
    }

    public void Dips()
    {
        if (muscle >= dipsbuy)
        {
            muscle -= dipsbuy;
            dipslevel++;
            dipsbuy = Mathf.Round(dipsbuy * 4F);
        }
    }

    public void Presses()
    {
        if (muscle >= pressesbuy)
        {
            muscle -= pressesbuy;
            presseslevel++;
            pressesbuy = Mathf.Round(pressesbuy * 2.5F);
        }
    }

    public void Deadliftlevel()
    {
        if (muscle >= deadliftbuy)
        {
            muscle -= deadliftbuy;
            deadliftlevel++;
            deadliftbuy = Mathf.Round(deadliftbuy * 2F);
        }
    }

    public void Reset()
    {
        muscle = 0; 
        musclepersec = 0;
        benchlevel = 0;
        muscleperkattlevel = 1;
        tbarrowlevel = 0;
        pullupslevel = 0; 
        dumbellcurllevel = 0;
        barbellcurllevel = 0;
        dipslevel = 0;
        presseslevel = 0;
        deadliftlevel = 0;
        benchbuy = 50;
        muscleperkattbuy = 10;
        tbarrowbuy = 5000000;
        pullupsbuy = 500;
        dumbellcurlbuy = 5000;
        barbellcurlbuy = 50000;
        dipsbuy = 500000;
        pressesbuy = 50000000;
        deadliftbuy = 500000000;

}
}
