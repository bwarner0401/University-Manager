using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UniversityRanking : MonoBehaviour
{
    public Text textbox;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Ranking()
    {
        double ranking = MainMenu.Satisfaction; // Replace with value we want
        if (ranking > 0.9)
        {
            textbox.text = "Your university ranked first in the country!";
            return;
        } else if (ranking > 0.8)
        {
            textbox.text = "Your university ranked third in the country!";
            return;
        }
        else if (ranking > 0.7)
        {
            textbox.text = "Your university ranked eighth in the country!";
            return;
        }
        else if (ranking > 0.6)
        {
            textbox.text = "Your university ranked twenty-third in the country.";
            return;
        }
        else if (ranking > 0.5)
        {
            textbox.text = "Your university ranked fourty-second in the country.";
            return;
        }
        else if (ranking > 0.4)
        {
            textbox.text = "Your university ranked fifty-ninth in the country.";
            return;
        }
        else if (ranking > 0.3)
        {
            textbox.text = "Your university ranked ninety-first in the country.";
            return;
        }
        else if (ranking > 0.2)
        {
            textbox.text = "Your university ranked one hundred and second in the country.";
            return;
        }
        else
        {
            textbox.text = "Your university ranked worst in the country. At least you didn't go bankrupt!";
            return;
        }
    }
}
