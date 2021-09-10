using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class szor : MonoBehaviour
{
    // Szöveg

    public Text hatralevoidoText;

    // Változók

    public static int szorzo = 1;
    public static float szamlalo = 0f;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (szamlalo >= 1)
        {

            szorzo = 2;
            szamlalo = szamlalo - 1 * Time.deltaTime;
        }
        else
        {
            szorzo = 1;
            szamlalo = 0;
        }

        if (Base.Nyelv == "eng")
        {
            hatralevoidoText.text = "" + Mathf.Round(szamlalo) + "sec";
        }
        else if (Base.Nyelv == "hun")
        {
            hatralevoidoText.text = "" + Mathf.Round(szamlalo) + "másodperc";
        }
    }
}
