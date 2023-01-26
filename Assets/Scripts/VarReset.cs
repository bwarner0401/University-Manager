using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VarReset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Reset()
    {
        MainMenu.Money = 100000;
        MainMenu.Month = 0;
        MainMenu.Year = 2021;
        MainMenu.QuestionNumber = -1;
        MainMenu.MonthlyFees = 770;
        MainMenu.Intake = 4000;

    MainMenu.Computing = new MainMenu.Course("Computing", 0, 2, 2000, 1000, 0.7, 2, 200000);
    MainMenu.Humanities = new MainMenu.Course("Humanities", 0, 2, 2000, 1000, 0.7, 2, 140000);
    MainMenu.Arts = new MainMenu.Course("Arts", 0, 2, 2000, 1000, 0.7, 2, 170000);
    MainMenu.Sciences = new MainMenu.Course("Sciences", 0, 2, 2000, 1000, 0.7, 2, 170000);
    MainMenu.Maths = new MainMenu.Course("Maths", 0, 2, 2000, 1000, 0.7, 2, 160000);
    MainMenu.Gil = new MainMenu.Staff("Gil Bates", "Computing", 650000, 2);
    MainMenu.Thretta = new MainMenu.Staff("Thretta Grumberg", "Humanities", 550000, 2);
    MainMenu.Robert = new MainMenu.Staff("Robert Boss", "Arts", 500000, 2);
    MainMenu.Nigel = new MainMenu.Staff("Nigel Buy", "Sciences", 600000, 2);
    MainMenu.Shaq = new MainMenu.Staff("Large Shaquille", "Maths", 600000, 2);
    MainMenu.ComGrant = new MainMenu.Grant("Computing", 0, 1.4);
    MainMenu.HumGrant = new MainMenu.Grant("Humanities", 0, 1.1);
    MainMenu.ArtGrant = new MainMenu.Grant("Arts", 0, 1.0);
    MainMenu.SciGrant = new MainMenu.Grant("Sciences", 0, 1.3);
    MainMenu.MatGrant = new MainMenu.Grant("Maths", 0, 1.2);
}
}
