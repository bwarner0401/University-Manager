using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Table : MonoBehaviour
{
    public Text Compname;
    public Text Compupkeep;
    public Text Compquality;
    public Text Comphappiness;
    public Text Compenrolled;
    public Text Compcapacity;
    public Text Compwage;
    public Text Compsquality;
    public Text Compgrant;
    public Text Humname;
    public Text Humupkeep;
    public Text Humquality;
    public Text Humhappiness;
    public Text Humenrolled;
    public Text Humcapacity;
    public Text Humwage;
    public Text Humsquality;
    public Text Humgrant;
    public Text Artname;
    public Text Artupkeep;
    public Text Artquality;
    public Text Arthappiness;
    public Text Artenrolled;
    public Text Artcapacity;
    public Text Artwage;
    public Text Artsquality;
    public Text Artgrant;
    public Text Sciname;
    public Text Sciupkeep;
    public Text Sciquality;
    public Text Scihappiness;
    public Text Scienrolled;
    public Text Scicapacity;
    public Text Sciwage;
    public Text Scisquality;
    public Text Scigrant;
    public Text Matname;
    public Text Matupkeep;
    public Text Matquality;
    public Text Mathappiness;
    public Text Matenrolled;
    public Text Matcapacity;
    public Text Matwage;
    public Text Matsquality;
    public Text Matgrant;
    public Text Qualrange;
    public Text Happinessrange;

    // Start is called before the first frame update
    public void SetText()
    {
        Compname.text = MainMenu.Computing.Name;
        Compupkeep.text = MainMenu.Computing.Upkeep.ToString();
        Compquality.text = MainMenu.Computing.Quality.ToString();
        Comphappiness.text = MainMenu.Computing.Happiness.ToString();
        Compenrolled.text = MainMenu.Computing.CurrentEnrole.ToString();
        Compcapacity.text = MainMenu.Computing.Capacity.ToString();
        Compwage.text = MainMenu.Gil.Wage.ToString();
        Compsquality.text = MainMenu.Gil.Quality.ToString();
        Compgrant.text = MainMenu.ComGrant.Amount.ToString();
        Humname.text = MainMenu.Humanities.Name;
        Humupkeep.text = MainMenu.Humanities.Upkeep.ToString();
        Humquality.text = MainMenu.Humanities.Quality.ToString();
        Humhappiness.text = MainMenu.Humanities.Happiness.ToString();
        Humenrolled.text = MainMenu.Humanities.CurrentEnrole.ToString();
        Humcapacity.text = MainMenu.Humanities.Capacity.ToString();
        Humwage.text = MainMenu.Thretta.Wage.ToString();
        Humsquality.text = MainMenu.Thretta.Quality.ToString();
        Humgrant.text = MainMenu.HumGrant.Amount.ToString();
        Artname.text = MainMenu.Arts.Name;
        Artupkeep.text = MainMenu.Arts.Upkeep.ToString();
        Artquality.text = MainMenu.Arts.Quality.ToString();
        Arthappiness.text = MainMenu.Arts.Happiness.ToString();
        Artenrolled.text = MainMenu.Arts.CurrentEnrole.ToString();
        Artcapacity.text = MainMenu.Arts.Capacity.ToString();
        Artwage.text = MainMenu.Robert.Wage.ToString();
        Artsquality.text = MainMenu.Robert.Quality.ToString();
        Artgrant.text = MainMenu.ArtGrant.Amount.ToString();
        Sciname.text = MainMenu.Sciences.Name;
        Sciupkeep.text = MainMenu.Sciences.Upkeep.ToString();
        Sciquality.text = MainMenu.Sciences.Quality.ToString();
        Scihappiness.text = MainMenu.Sciences.Happiness.ToString();
        Scienrolled.text = MainMenu.Sciences.CurrentEnrole.ToString();
        Scicapacity.text = MainMenu.Sciences.Capacity.ToString();
        Sciwage.text = MainMenu.Nigel.Wage.ToString();
        Scisquality.text = MainMenu.Nigel.Quality.ToString();
        Scigrant.text = MainMenu.SciGrant.Amount.ToString();
        Matname.text = MainMenu.Maths.Name;
        Matupkeep.text = MainMenu.Maths.Upkeep.ToString();
        Matquality.text = MainMenu.Maths.Quality.ToString();
        Mathappiness.text = MainMenu.Maths.Happiness.ToString();
        Matenrolled.text = MainMenu.Maths.CurrentEnrole.ToString();
        Matcapacity.text = MainMenu.Maths.Capacity.ToString();
        Matwage.text = MainMenu.Shaq.Wage.ToString();
        Matsquality.text = MainMenu.Shaq.Quality.ToString();
        Matgrant.text = MainMenu.MatGrant.Amount.ToString();
        Qualrange.text = "1-4";
        Happinessrange.text = "0-1";
    }
    void start()
    {
        SetText();
    }

    // Update is called once per frame
    void Update() {
    }
}
