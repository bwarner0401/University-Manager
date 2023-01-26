using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using Random=UnityEngine.Random;

public class NextMonth : MonoBehaviour
{
    public Text BalField;
    public Text DateField;
    public Text StoryInfoText;
    public Image StaffPicture;
    public Sprite Shaq;
    public Sprite Gil;
    public Sprite Thretta;
    public Sprite Bill;
    public Sprite Rob;
    public Sprite Dis;
    public static List<Question> Questions = new List<Question>();
    public static bool DescisionStatus = false;
    public Text DeptText;
    public Text Balance;
    public static List<String> Months = new List<string>(new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });


    // Start is called before the first frame update
    void Start()
    {
        if (!MainMenu.IntroDone)
        {
            TextAsset questionsAsset = Resources.Load<TextAsset>("questions");
            string[] questions = questionsAsset.text.Split(new char[] { '\n' });
            for (int i = 0; i < questions.Length - 1; i++)
            {
                string[] quest = questions[i].Split(new char[] { ',' });
                Question q = new Question(quest[0], quest[1], quest[2], quest[3]);
                Questions.Add(q);
            }
            MainMenu.IntroDone = true;
        } else
        {
            QuestionUpdate();
            string SMonth = Months[MainMenu.Month];
            DateField.text = "Date: " + SMonth + " " + MainMenu.Year.ToString();
            Balance.text = "Balance: " + MainMenu.Money;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DateUpdate()
    {
        MainMenu.Month += 1;
        if (MainMenu.Month == 12)
        {
            MainMenu.Month = 0;
            MainMenu.Year += 1;
            if(MainMenu.Year == 2026){
                SceneManager.LoadScene("WinScreen");
            }
        }
        string SMonth = "";
        SMonth = Months[MainMenu.Month];

        DateField.text = "Date: " + SMonth + " " + MainMenu.Year.ToString();
        if (SMonth == "December") {
            int newComp = (int)Math.Round(MainMenu.Computing.CurrentEnrole * (0.65 + MainMenu.Satisfaction));
            if (newComp < MainMenu.Computing.Capacity)
            {
                MainMenu.Computing.CurrentEnrole = newComp;
            }
            else { MainMenu.Computing.CurrentEnrole = MainMenu.Computing.Capacity; }
            
            int newHum = (int)Math.Round(MainMenu.Humanities.CurrentEnrole * (0.65 + MainMenu.Satisfaction));
            if (newHum < MainMenu.Humanities.Capacity)
            {
                MainMenu.Humanities.CurrentEnrole = newHum;
            }
            else { MainMenu.Humanities.CurrentEnrole = MainMenu.Humanities.Capacity; }
            
            int newArt = (int)Math.Round(MainMenu.Arts.CurrentEnrole * (0.65 + MainMenu.Satisfaction));
            if (newArt < MainMenu.Arts.Capacity)
            {
                MainMenu.Arts.CurrentEnrole = newArt;
            }
            else { MainMenu.Arts.CurrentEnrole = MainMenu.Arts.Capacity; }
            
            int newSci = (int)Math.Round(MainMenu.Sciences.CurrentEnrole * (0.65 + MainMenu.Satisfaction));
            if (newSci < MainMenu.Sciences.Capacity)
            {
                MainMenu.Sciences.CurrentEnrole = newSci;
            }
            else { MainMenu.Sciences.CurrentEnrole = MainMenu.Sciences.Capacity; }
            
            int newMat = (int)Math.Round(MainMenu.Maths.CurrentEnrole * (0.65 + MainMenu.Satisfaction));
            if (newMat < MainMenu.Maths.Capacity)
            {
                MainMenu.Maths.CurrentEnrole = newMat;
            }
            else { MainMenu.Maths.CurrentEnrole = MainMenu.Maths.Capacity; }
        }
        SMonth = "";
    }

    public void BalUpdate()
    {
        BalField.text = "Balance: " + MainMenu.Money.ToString();
    }

    public void ButtonChanges(string[] itemsToChange, string WhichButton)
    {
        var OutPutString = new System.Text.StringBuilder();
        if (WhichButton == "AgreeButton")
        {
            OutPutString.AppendLine("Agree Effects :\n");
        }
        else
        {
            OutPutString.AppendLine("Disagree Effects :\n");
        }
        foreach (string item in itemsToChange)
        {
            if (item != "N/A")
            {
                string beforeEq = item.Substring(0, item.IndexOf('='));
                string afterEq = item.Substring(item.IndexOf('=') + 1);
                double num = 0;
                double.TryParse(afterEq, out num);
                string dispVal = "temp";
                if(2<num || num<-2){
                    dispVal = afterEq;
                }                
                if(1<num && num<2){
                    string change = num.ToString().Substring(num.ToString().IndexOf('.'));
                    double decimalNum = 0;
                    double.TryParse(afterEq, out decimalNum);
                    double percent = (decimalNum-1)*100;
                    dispVal = Convert.ToString(percent) + "% Increase";
                }
                if(0<num && num<1){
                    string change = num.ToString().Substring(num.ToString().IndexOf('.'));
                    double decimalNum = 0;
                    double.TryParse(afterEq, out decimalNum);
                    double percent = (1-decimalNum)*100;
                    dispVal = Convert.ToString(percent) + "% Decrease";
                }

                if (beforeEq == "M")
                {
                    OutPutString.AppendLine("Money: " + dispVal + "\n");
                }
                if (beforeEq == "CC")
                {
                    OutPutString.AppendLine("Course Capacity: " + dispVal + "\n");
                }
                if (beforeEq == "CQ")
                {
                    OutPutString.AppendLine("Course Quality: " + dispVal + "\n");
                }
                if (beforeEq == "CH")
                {
                    OutPutString.AppendLine("Course Happiness: " + dispVal + "\n");
                }
                if (beforeEq == "CU")
                {
                    OutPutString.AppendLine("Course Upkeep: " + dispVal + "\n");
                }
                if (beforeEq == "SW")
                {
                    OutPutString.AppendLine("Staff Wage: " + dispVal + "\n");
                }
                if (beforeEq == "SQ")
                {
                    OutPutString.AppendLine("Staff Quality: " + dispVal + "\n");
                }
                if (beforeEq == "ACQ")
                {
                    OutPutString.AppendLine("All Course Qualities: " + dispVal + "\n");
                }
                if (beforeEq == "AGM")
                {
                    OutPutString.AppendLine("All Grant Modifiers: " + dispVal + "\n");
                }
                if (beforeEq == "ACU")
                {
                    OutPutString.AppendLine("All Course Upkeeps: " + dispVal + "\n");
                }
                if (beforeEq == "ACH")
                {
                    OutPutString.AppendLine("All Course Happiness: " + dispVal + "\n");
                }
                GameObject.Find(WhichButton).GetComponentInChildren<TextMeshProUGUI>().text = OutPutString.ToString();
            } else
            {
                GameObject.Find(WhichButton).GetComponentInChildren<TextMeshProUGUI>().text = "No effects";
            }
        }
    }

    public void QuestionUpdate()
    {
        if (MainMenu.QuestionNumber < Questions.Count)
        {
            string departmentTemp = Questions[MainMenu.QuestionNumber].Dept.Trim();
            if (String.Equals(departmentTemp, "comp"))
            {
                StaffPicture.sprite = Gil;
                DeptText.text = "Department: Computing";

            }
            if (departmentTemp == "humn")
            {
                StaffPicture.sprite = Thretta;
                DeptText.text = "Department: Humanities";
            }
            if (departmentTemp == "arts")
            {
                StaffPicture.sprite = Rob;
                DeptText.text = "Department: Arts";
            }
            if (departmentTemp == "scie")
            {
                StaffPicture.sprite = Bill;
                DeptText.text = "Department: Sciences";
            }
            if (departmentTemp == "math")
            {
                StaffPicture.sprite = Shaq;
                DeptText.text = "Department: Mathematics";
            }
            if (departmentTemp == "all")
            {
                StaffPicture.sprite = Dis;
                DeptText.text = "Department: Uni Wide";
            }
            StoryInfoText.text = Questions[MainMenu.QuestionNumber].Question_text;

            //
            string Changes = NextMonth.Questions[MainMenu.QuestionNumber].Yes_result;
            string[] itemsToChange = Changes.Split(new char[] { ' ' });;
            ButtonChanges(itemsToChange, "AgreeButton");
            Changes = NextMonth.Questions[MainMenu.QuestionNumber].No_result;
            itemsToChange = Changes.Split(new char[] { ' ' }); ;
            ButtonChanges(itemsToChange, "DisagreeButton");
        }
    }

    public void updateData()
    {
        if(DescisionStatus){
            MainMenu.QuestionNumber += 1;
            DateUpdate();
            updateValues();
            BalUpdate();
            QuestionUpdate();
            NextMonth.DescisionStatus = false;
            Balance.text = "Balance: " + MainMenu.Money;
        }else{
            //do pop up
        }
    }

    public void updateValues()
    {
        MainMenu.Computing.Cost = (MainMenu.Gil.Wage + MainMenu.Computing.Upkeep);
        MainMenu.Humanities.Cost = (MainMenu.Thretta.Wage + MainMenu.Humanities.Upkeep);
        MainMenu.Arts.Cost = (MainMenu.Robert.Wage + MainMenu.Arts.Upkeep);
        MainMenu.Sciences.Cost = (MainMenu.Nigel.Wage + MainMenu.Sciences.Upkeep);
        MainMenu.Maths.Cost = (MainMenu.Shaq.Wage + MainMenu.Maths.Upkeep);
        MainMenu.ComGrant.Amount = Math.Round(MainMenu.ComGrant.Modifier * 1000 * MainMenu.Computing.Quality * MainMenu.Gil.Quality, 2);
        MainMenu.HumGrant.Amount = Math.Round(MainMenu.HumGrant.Modifier * 1000 * MainMenu.Humanities.Quality * MainMenu.Thretta.Quality, 2);
        MainMenu.ArtGrant.Amount = Math.Round(MainMenu.ArtGrant.Modifier * 1000 * MainMenu.Arts.Quality * MainMenu.Robert.Quality, 2);
        MainMenu.SciGrant.Amount = Math.Round(MainMenu.SciGrant.Modifier * 1000 * MainMenu.Sciences.Quality * MainMenu.Nigel.Quality, 2);
        MainMenu.MatGrant.Amount = Math.Round(MainMenu.MatGrant.Modifier * 1000 * MainMenu.Maths.Quality * MainMenu.Shaq.Quality, 2);
        MainMenu.Computing.Results = MainMenu.Computing.Quality * MainMenu.Gil.Quality / 2;
        MainMenu.Humanities.Results = MainMenu.Humanities.Quality * MainMenu.Thretta.Quality / 2;
        MainMenu.Arts.Results = MainMenu.Arts.Quality * MainMenu.Robert.Quality / 2;
        MainMenu.Sciences.Results = MainMenu.Sciences.Quality * MainMenu.Nigel.Quality / 2;
        MainMenu.Maths.Results = MainMenu.Maths.Quality * MainMenu.Shaq.Quality / 2;
        int TotalStudents = MainMenu.Computing.CurrentEnrole + MainMenu.Humanities.CurrentEnrole + MainMenu.Arts.CurrentEnrole + MainMenu.Sciences.CurrentEnrole + MainMenu.Maths.CurrentEnrole;
        MainMenu.MonthlyRevenue = (MainMenu.MonthlyFees * TotalStudents) + (MainMenu.ComGrant.Amount + MainMenu.HumGrant.Amount + MainMenu.ArtGrant.Amount + MainMenu.SciGrant.Amount + MainMenu.MatGrant.Amount) - (MainMenu.Computing.Cost + MainMenu.Humanities.Cost + MainMenu.Arts.Cost + MainMenu.Sciences.Cost + MainMenu.Maths.Cost);
        MainMenu.Money = Math.Round(MainMenu.Money + MainMenu.MonthlyRevenue, 2);
        if (MainMenu.Money < 0)
        {
            NavToGameOver.Navigate();
        }
        MainMenu.AverageHappiness = (MainMenu.Computing.Happiness + MainMenu.Humanities.Happiness + MainMenu.Arts.Happiness + MainMenu.Sciences.Happiness + MainMenu.Maths.Happiness) / 5;
        MainMenu.AverageResult = (MainMenu.Computing.Results + MainMenu.Humanities.Results + MainMenu.Arts.Results + MainMenu.Sciences.Results + MainMenu.Maths.Results)/5;
        MainMenu.Satisfaction = MainMenu.AverageHappiness * (MainMenu.AverageResult / 4);
        if(MainMenu.Satisfaction < 0.2)
        {
            int compMod = (int)Math.Round(MainMenu.Computing.CurrentEnrole * (0.79 + MainMenu.Satisfaction));
            MainMenu.Computing.CurrentEnrole = compMod;
            int humMod = (int)Math.Round(MainMenu.Humanities.CurrentEnrole * (0.79 + MainMenu.Satisfaction));
            MainMenu.Humanities.CurrentEnrole = humMod;
            int artMod = (int)Math.Round(MainMenu.Arts.CurrentEnrole * (0.79 + MainMenu.Satisfaction));
            MainMenu.Arts.CurrentEnrole = artMod;
            int sciMod = (int)Math.Round(MainMenu.Sciences.CurrentEnrole * (0.79 + MainMenu.Satisfaction));
            MainMenu.Sciences.CurrentEnrole = sciMod;
            int matMod = (int)Math.Round(MainMenu.Maths.CurrentEnrole * (0.79 + MainMenu.Satisfaction));
            MainMenu.Maths.CurrentEnrole = matMod;
        }
    }
}
