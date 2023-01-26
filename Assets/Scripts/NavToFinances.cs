using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavToFinances : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Navigate()
    {
        if (MainMenu.QuestionNumber == -1)
        {
            return;
        }
        else
        {
            SceneManager.LoadScene("Finances");
        }
    }
}
