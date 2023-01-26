using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class AgreeDisagree : MonoBehaviour
{
    public Text Balance;
    

    public void ChangesAgree()
    {
        if(!NextMonth.DescisionStatus){
            if (MainMenu.QuestionNumber == -1)
            {
                NextMonth.DescisionStatus = true;
                return;
            }
            string Changes = NextMonth.Questions[MainMenu.QuestionNumber].Yes_result;
            changeStandings(Changes);
            NextMonth.DescisionStatus = true;
        }
    }

    public void ChangesDisagree()
    {
        if(!NextMonth.DescisionStatus){
            if (MainMenu.QuestionNumber == -1)
            {
                NextMonth.DescisionStatus = true;
                return;
            }
            string Changes = NextMonth.Questions[MainMenu.QuestionNumber].No_result;
            changeStandings(Changes);
            NextMonth.DescisionStatus = true;
        }
    }

    public void changeStandings(string Changes) 
    {
        //Split changes into an array.
        //For each value in array, use if statement to find what it's changing. Then change value by the amount.
        string[] itemsToChange = Changes.Split(new char[] {' '});
        foreach (string item in itemsToChange)
        {
            if(item != "N/A"){
                int length = item.Length - 1;
                string beforeEq = item.Substring(0, item.IndexOf('='));
                string afterEq = item.Substring(item.IndexOf('=')+1);
                // Debug.Log("before: " + beforeEq);
                // Debug.Log("after: " + afterEq);
                
               Question question = NextMonth.Questions[MainMenu.QuestionNumber];

               MainMenu.Course course = MainMenu.Computing;
               MainMenu.Staff staff = MainMenu.Gil;

                if(question.Dept.Trim() == "comp"){
                    course = MainMenu.Computing;
                    staff = MainMenu.Gil;
                }else if(question.Dept.Trim() == "humn"){
                    course = MainMenu.Humanities;
                    staff = MainMenu.Thretta;
                }else if(question.Dept.Trim() == "arts"){
                    course = MainMenu.Arts;
                    staff = MainMenu.Robert;
                }else if(question.Dept.Trim() == "scie"){
                    course = MainMenu.Sciences;
                    staff = MainMenu.Nigel;
                }else if(question.Dept.Trim() == "math"){
                    course = MainMenu.Maths;
                    staff = MainMenu.Shaq;
                }

                if (beforeEq == "M")
                {
                    double afterEqDouble;
                    if (double.TryParse(afterEq, out afterEqDouble))
                    {
                        if (MainMenu.Money + afterEqDouble > 0)
                        {
                            MainMenu.Money = MainMenu.Money + afterEqDouble;
                        }
                        else
                        {
                            GameObject.Find("AgreeButton").GetComponentInChildren<TextMeshProUGUI>().text = "Not enough money!\n Disagree has been chosen instead";
                            ChangesDisagree();
                            return;
                        }
                    }
                }
                if(beforeEq == "CC"){
                    double afterEqDouble;
                    if(double.TryParse(afterEq, out afterEqDouble)){
                        course.Capacity = Convert.ToInt32((afterEqDouble)*course.Capacity);
                    }
                }
                if(beforeEq == "CQ"){
                    double afterEqDouble;
                    if(double.TryParse(afterEq, out afterEqDouble)){
                        double quality =  ((afterEqDouble)*course.Quality);
                        if(quality<4 && quality>1){
                            course.Quality = Math.Round(quality,2);
                        }
                    }
                }
                if(beforeEq == "CH"){
                    double afterEqDouble;
                    if(double.TryParse(afterEq, out afterEqDouble)){
                        double happiness =  ((afterEqDouble)*course.Happiness);
                        if(happiness>0 && happiness<1){
                            course.Happiness = Math.Round(happiness,2);
                        }
                    }
                }
                if(beforeEq == "CU"){
                    double afterEqDouble;
                    if(double.TryParse(afterEq, out afterEqDouble)){
                        course.Upkeep = Convert.ToInt32((afterEqDouble)+course.Upkeep);
                    }
                }

                if(beforeEq == "SW"){
                    double afterEqDouble;
                    if(double.TryParse(afterEq, out afterEqDouble)){
                        staff.Wage = Convert.ToInt32((afterEqDouble)*staff.Wage);
                    }
                }
                if(beforeEq == "SQ"){
                    double afterEqDouble;
                    if(double.TryParse(afterEq, out afterEqDouble)){
                        double quality = (afterEqDouble)*staff.Quality;
                        if(quality<4 && quality>1){
                            staff.Quality = Math.Round(quality,2);
                        }
                    }
                }
                
                if(beforeEq == "ACQ"){
                    double afterEqDouble;
                    if(double.TryParse(afterEq, out afterEqDouble)){
                        double compQual =  ((afterEqDouble)*MainMenu.Computing.Quality);
                        if(compQual<4 && compQual>1){
                            MainMenu.Computing.Quality = Math.Round(compQual,2);
                        }
                        double humnQual =  ((afterEqDouble)*MainMenu.Humanities.Quality);
                        if(humnQual<4 && humnQual>1){
                            MainMenu.Humanities.Quality = Math.Round(humnQual,2);
                        }
                        double artQual =  ((afterEqDouble)*MainMenu.Arts.Quality);
                        if(artQual<4 && artQual>1){
                            MainMenu.Arts.Quality = Math.Round(artQual,2);
                        }
                        double sciQual =  ((afterEqDouble)*MainMenu.Sciences.Quality);
                        if(sciQual<4 && sciQual>1){
                            MainMenu.Sciences.Quality = Math.Round(sciQual,2);
                        }
                        double mathQual =  ((afterEqDouble)*MainMenu.Maths.Quality);
                        if(mathQual<4 && mathQual>1){
                            MainMenu.Maths.Quality = Math.Round(mathQual,2);
                        }
                    }
                }
                if(beforeEq == "AGM"){
                    double afterEqDouble;
                    if(double.TryParse(afterEq, out afterEqDouble)){
                        MainMenu.ComGrant.Modifier = MainMenu.ComGrant.Modifier+afterEqDouble;
                        MainMenu.HumGrant.Modifier = MainMenu.HumGrant.Modifier+afterEqDouble;
                        MainMenu.ArtGrant.Modifier = MainMenu.ArtGrant.Modifier+afterEqDouble;
                        MainMenu.SciGrant.Modifier = MainMenu.SciGrant.Modifier+afterEqDouble;
                        MainMenu.MatGrant.Modifier = MainMenu.MatGrant.Modifier+afterEqDouble;
                    }
                }
                if(beforeEq == "ACU"){
                    int afterEqDouble;
                    if(Int32.TryParse(afterEq, out afterEqDouble)){
                        MainMenu.Computing.Upkeep = MainMenu.Computing.Upkeep+afterEqDouble;
                        MainMenu.Humanities.Upkeep = MainMenu.Humanities.Upkeep+afterEqDouble;
                        MainMenu.Arts.Upkeep = MainMenu.Arts.Upkeep+afterEqDouble;
                        MainMenu.Sciences.Upkeep = MainMenu.Sciences.Upkeep+afterEqDouble;
                        MainMenu.Maths.Upkeep = MainMenu.Maths.Upkeep+afterEqDouble;
                    }
                }
                if(beforeEq == "ACH"){
                    double afterEqDouble;
                    if(double.TryParse(afterEq, out afterEqDouble)){ 
                        double compHap =  ((afterEqDouble)*MainMenu.Computing.Happiness);
                        if(compHap<1 && compHap>0){
                            MainMenu.Computing.Happiness = Math.Round(compHap,2);
                        }
                        double humnHap =  ((afterEqDouble)*MainMenu.Humanities.Happiness);
                        if(humnHap<1 && humnHap>0){
                            MainMenu.Humanities.Happiness = Math.Round(humnHap,2);
                        }
                        double artHap =  ((afterEqDouble)*MainMenu.Arts.Happiness);
                        if(artHap<1 && artHap>0){
                            MainMenu.Arts.Happiness = Math.Round(artHap,2);
                        }
                        double sciHap =  ((afterEqDouble)*MainMenu.Sciences.Happiness);
                        if(sciHap<1 && sciHap>0){
                            MainMenu.Sciences.Happiness = Math.Round(sciHap,2);
                        }
                        double mathHap =  ((afterEqDouble)*MainMenu.Maths.Happiness);
                        if(mathHap<1 && mathHap>0){
                            MainMenu.Maths.Happiness = Math.Round(mathHap,2);
                        }                   
                    }
                }
            }
        }
        Balance.text = "Balance: " + MainMenu.Money.ToString();
    }
}