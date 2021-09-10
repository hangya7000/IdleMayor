using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Base : MonoBehaviour
{
    // Texts

    public Text IdleCoins;
    public Text IdleCrypto;
    public Text Coinspersec;
    public Text LakosEgyszeruText;
    public Text LakosJoModText;
    public Text GazdagLakosText;
    public Text LakosEgyszeruEgyszerText;
    public Text LakosEgyszeruTizszerText;
    public Text LakosEgyszeruFejlesztText;
    public Text LakosJomodEgyszerText;
    public Text LakosJomodTizszerText;
    public Text LakosJomodFejlesztText;
    public Text LakosGazdagEgyszerText;
    public Text LakosGazdagTizszerText;
    public Text LakosGazdagFejlesztText;

    // Variables
    public int LakosEgyszeruszintvalaszto = 1;
    public int Jomodlakosszintvalaszto = 1;
    public int Gazdaglakosszintvalaszto = 1;
    public double coins = 0;
    public double crypto = 0;
    public double coinspersec = 0;
    public double egyszerulakos; 
    public float egyszerulakosar = 10;
    public double Jomodlakos = 0;
    public float Jomodlakosar = 500;
    public double Gazdaglakos = 0;
    public float Gazdaglakosar = 2000;
    public static string Nyelv = "eng";

    public void Start()
    {
        English();
        coins = 10000;
        crypto = 0;
        coinspersec = 0;
        egyszerulakos = 200;
    }

    public void Update()
    {
        // A folyamatosan kapott pénz hozzáírása

        coinspersec = szor.szorzo * (egyszerulakos / 100 + Jomodlakos / 10 + Gazdaglakos * 3);
        coins += coinspersec * Time.deltaTime;

        // Nyelv

        // Magyar
        if (Nyelv == "hun")
        {
            IdleCoins.text = "" + coins.ToString("F0");
            IdleCrypto.text = "" + crypto;
            Coinspersec.text = "" + coinspersec + "Coins per mp";

            // egyszerű lakos

            if (LakosEgyszeruszintvalaszto == 1)
            {
                LakosEgyszeruText.text = "Középosztálybeli lakosok:" + egyszerulakos + "\nA fejlesztes ára:" + egyszerulakosar;
            }
           else if (LakosEgyszeruszintvalaszto == 2)
            {
                LakosEgyszeruText.text = "Középosztálybeli lakosok:" + egyszerulakos + "\nA fejlesztes ára:" + Mathf.Round(egyszerulakosar * Mathf.Pow(10, 1.3F));
            }

            // jó módu lakos

            if (Jomodlakosszintvalaszto == 1)
            {
                LakosJoModText.text = "Jó módu lakosok:" + Jomodlakos + "\nA fejlesztés ára:" + Jomodlakosar;
            }
            else if (Jomodlakosszintvalaszto == 2)
            {
                LakosJoModText.text = "Jó módu lakosok:" + Jomodlakos + "\nA fejlesztés ára:" + Mathf.Round(Jomodlakosar * Mathf.Pow(10, 2F));
            }

            // gazdag lakos

            if (Gazdaglakosszintvalaszto == 1)
            {
                GazdagLakosText.text = "Gazdag lakosok" + Gazdaglakos + "\n A fejlesztés ára:" + Gazdaglakosar;
            }
            else if (Gazdaglakosszintvalaszto == 2)
            {
                GazdagLakosText.text = "Gazdag lakosok" + Gazdaglakos + "\n A fejlesztés ára:" + Mathf.Round(Gazdaglakosar * Mathf.Pow(10, 4F));
            }
            
        }

            // Angol

        if (Nyelv == "eng")
        {
            IdleCoins.text = "" + coins.ToString("F0");
            IdleCrypto.text = "" + crypto;
            Coinspersec.text = "" + coinspersec + "Coins per sec";

            // egyszerű lakos

            if (LakosEgyszeruszintvalaszto == 1)
            {
                LakosEgyszeruText.text = "Middle class residents:" + egyszerulakos + "\n The price of development:" + egyszerulakosar;
            }
            else if (LakosEgyszeruszintvalaszto == 2)
            {
                LakosEgyszeruText.text = "Middle class residents:" + egyszerulakos + "\n The price of development:" + Mathf.Round(egyszerulakosar * Mathf.Pow(10, 1.3F));
            }

            // jó módu lakos

            if (Jomodlakosszintvalaszto == 1)
            {
                LakosJoModText.text = "Good way residents:" + Jomodlakos + "\nThe price of development:" + Jomodlakosar;
            }
            else if (Jomodlakosszintvalaszto == 2)
            {
                LakosJoModText.text = "Good way residents:" + Jomodlakos + "\nThe price of development:" + Mathf.Round(Jomodlakosar * Mathf.Pow(10, 2F));
            }

            // gazdag lakos

            if (Gazdaglakosszintvalaszto == 1)
            {
                GazdagLakosText.text = "Wealthy residents:" + Gazdaglakos + "\n he price of development:" + Gazdaglakosar;
            }
            else if (Gazdaglakosszintvalaszto == 2)
            {
                GazdagLakosText.text = "Wealthy residents:" + Gazdaglakos + "\n he price of development:" + Mathf.Round(Gazdaglakosar * Mathf.Pow(10, 4F));
            }
        }
    }


    // A folyamatosan kapott pénz növelése
        // Egyszerű lakos fejlesztése
    public void Lakosegyszeru()
    {
        LakosEgyszeruszintvalaszto = 1;
    }

    public void Lakosegyszeru10()
    {
        LakosEgyszeruszintvalaszto = 2;
    }

    public void Lakosegyszerufejleszt()
    {
        if (LakosEgyszeruszintvalaszto == 1)
        {
            if (coins >= egyszerulakosar)

            {
                coins -= egyszerulakosar;
                egyszerulakos += 100;
                egyszerulakosar *= 1.3F;
                egyszerulakosar = Mathf.Round(egyszerulakosar);
            }
        }
        if (LakosEgyszeruszintvalaszto == 2)
        {
            if (coins >= egyszerulakosar * Mathf.Pow(10, 1.3F))

            {
                coins -= egyszerulakosar * Mathf.Pow(10, 1.3F);
                egyszerulakos += 1000;
                egyszerulakosar *= Mathf.Pow(10, 1.3F);
                egyszerulakosar = Mathf.Round(egyszerulakosar);
            }
        }
    }
    // Jó módu lakosság fejlesztése

    public void Lakosjomood()
    {
        Jomodlakosszintvalaszto = 1;
    }

    public void Lakosjomod10()
    {
        Jomodlakosszintvalaszto = 2;
    }
    public void Lakosjomodfejleszt()
    {
        if (Jomodlakosszintvalaszto == 1)
        {
            if (coins >= Jomodlakosar)

            {
                coins -= Jomodlakosar;
                Jomodlakos += 30;
                Jomodlakosar *= 2;
                Jomodlakosar = Mathf.Round(Jomodlakosar);
            }
        }
        if (Jomodlakosszintvalaszto == 2)
        {
            if (coins >= Jomodlakosar * Mathf.Pow(10, 2F))

            {
                coins -= Jomodlakosar * Mathf.Pow(10, 2F);
                Jomodlakos += 300;
                Jomodlakosar *= Mathf.Pow(10, 2F);
                Jomodlakosar = Mathf.Round(Jomodlakosar);
            }
        }
    }
    // Gazdag lakosság fejlesztése: 
    
    public void Lakosgazdag()
    {
        Gazdaglakosszintvalaszto = 1;
    }

    public void Lakosgazdagd10()
    {
        Gazdaglakosszintvalaszto = 2;
    }

    public void LakosGazdagfejleszt()
    {
        if (Gazdaglakosszintvalaszto == 1)
        {
            if (coins >= Gazdaglakosar)

            {
                coins -= Gazdaglakosar;
                Gazdaglakos += 10;
                Gazdaglakosar *= 4;
                Gazdaglakosar = Mathf.Round(Gazdaglakosar);
            }
        }
        if (Gazdaglakosszintvalaszto == 2)
        {
            if (coins >= Gazdaglakosar * Mathf.Pow(10, 4F))

            {
                coins -= Gazdaglakosar * Mathf.Pow(10, 4F);
                Gazdaglakos += 100;
                Gazdaglakosar *= Mathf.Pow(10, 4F);
                Gazdaglakosar = Mathf.Round(Gazdaglakosar);
            }
        }
    }

    // Nyelv váéasztó

    public void English()
    {
        Nyelv = "eng";
        LakosEgyszeruEgyszerText.text = "Once";
        LakosEgyszeruTizszerText.text = "Ten times";
        LakosEgyszeruFejlesztText.text = "Upgrade";
        LakosJomodEgyszerText.text = "Once";
        LakosJomodTizszerText.text = "Ten times";
        LakosJomodFejlesztText.text = "Upgrade";
        LakosGazdagEgyszerText.text = "Once";
        LakosGazdagTizszerText.text = "Ten times";
        LakosGazdagFejlesztText.text = "Upgrade";
}

    public void Magyar()
    {
        Nyelv = "hun";
        LakosEgyszeruEgyszerText.text = "Egyszer";
        LakosEgyszeruTizszerText.text = "Tízszer";
        LakosEgyszeruFejlesztText.text = "Fejlesztés";
        LakosJomodEgyszerText.text = "Egyszer";
        LakosJomodTizszerText.text = "Tízszer";
        LakosJomodFejlesztText.text = "Fejlesztés";
        LakosGazdagEgyszerText.text = "Egyszer";
        LakosGazdagTizszerText.text = "Tízszer";
        LakosGazdagFejlesztText.text = "Fejlesztés";
    }
}