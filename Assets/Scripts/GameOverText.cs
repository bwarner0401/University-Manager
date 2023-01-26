using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameOverText : MonoBehaviour
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

    public void EndTextbox()
    {
        int randomNum = UnityEngine.Random.Range(1, 5);
        //Debug.Log(randomNum.ToString());
        if (randomNum == 1)
        {
            textbox.text = "Your university ran out of money due to poor spending. The university has now been bought by " +
                "Mike Ashley and turned into a Sports Direct warehouse. You made it to : " + NextMonth.Months[MainMenu.Month] +
                " " + MainMenu.Year.ToString();
        } else if (randomNum == 2)
        {
            textbox.text = "Your university ran out of money due to poor spending. Be careful when taking options that increase staff wages and course upkeep." +
                " You made it to : " + NextMonth.Months[MainMenu.Month] +
                " " + MainMenu.Year.ToString();
        }
        else if (randomNum == 3)
        {
            textbox.text = "Your university ran out of money due to poor spending. Next time don't take financial advice from r/wallstreetbets." +
                " You made it to : " + NextMonth.Months[MainMenu.Month] +
                " " + MainMenu.Year.ToString();
        }
        else if (randomNum == 4)
        {
            textbox.text = "Your university ran out of money due to poor spending. The university was bought by a wealthy American businessman, who turned it into a golf course after his retirement from being US president." +
                " You made it to : " + NextMonth.Months[MainMenu.Month] +
                " " + MainMenu.Year.ToString();
        }
    }
}
