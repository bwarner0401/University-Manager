using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update

    //Global Variables
    //Money
        static public double Money = 100000;
        static public double MonthlyRevenue;

        //Time
        public static int Month = 0;
        public static int Year = 2021;
        public static int QuestionNumber = -1;
        public static bool IntroDone;

    //Student
    static public double MonthlyFees = 770;
        static public int Intake = 4000;
        static public double AverageResult;
        static public double AverageHappiness;
        static public double Satisfaction;
    
    //Objects
    public class Course
    {
        public string Name { get; set; }
        public int Cost { get; set; }
        public double Quality { get; set; }
        public int Capacity { get; set; }
        public int CurrentEnrole { get; set; }
        public double Happiness { get; set; }
        public double Results { get; set; }
        public int Upkeep { get; set; }
        
        public Course(string name, int cost, double quality, int capacity, int currentEnrole, double happiness, double results, int upkeep)
        {
            Name = name;
            Cost = cost;
            Quality = quality;
            Capacity = capacity;
            CurrentEnrole = currentEnrole;
            Happiness = happiness;
            Results = results;
            Upkeep = upkeep;
        }
    }

    //public static Course Computing = new Course("Computing", 10000, 2.0, 2000, 1000, 0.8, 0.5, 10000);
    //static Course Arts = new Course(Arts, 10000, 2, 2000, 1000, 0.8, 0.5, 10000);

    public class Staff
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public int Wage { get; set; }
        public double Quality { get; set; }

        public Staff(string name, string department, int wage, double quality)
        {
            Name = name;
            Department = department;
            Wage = wage;
            Quality = quality;
        }
    }

    public class Grant
    {
        public string Department { get; set; }
        public double Amount { get; set; }
        public double Modifier { get; set; }

        public Grant(string department, double amount, double modifier )
        {
            Department = department;
            Amount = amount;
            Modifier = modifier;
        }
    }


        public static Course Computing = new Course("Computing", 0, 2, 2000, 1000, 0.7, 2, 200000);
        public static Course Humanities = new Course("Humanities", 0, 2, 2000, 1000, 0.7, 2, 140000);
        public static Course Arts = new Course("Arts", 0, 2, 2000, 1000, 0.7, 2, 170000);
        public static Course Sciences = new Course("Sciences", 0, 2, 2000, 1000, 0.7, 2, 170000);
        public static Course Maths = new Course("Maths", 0, 2, 2000, 1000, 0.7, 2, 160000);
        public static Staff Gil = new Staff("Gil Bates", "Computing", 650000, 2);
        public static Staff Thretta = new Staff("Thretta Grumberg", "Humanities", 550000, 2);
        public static Staff Robert = new Staff("Robert Boss", "Arts", 500000, 2);
        public static Staff Nigel = new Staff("Nigel Buy", "Sciences", 600000, 2);
        public static Staff Shaq = new Staff("Large Shaquille", "Maths", 600000, 2);
        public static Grant ComGrant = new Grant("Computing", 0, 1.4);
        public static Grant HumGrant = new Grant("Humanities", 0, 1.1);
        public static Grant ArtGrant = new Grant("Arts", 0, 1.0);
        public static Grant SciGrant = new Grant("Sciences", 0, 1.3);
        public static Grant MatGrant = new Grant("Maths", 0, 1.2);
        
    public void PlayGame()
    {
        Computing.Cost = Gil.Wage + Computing.Upkeep;
        Humanities.Cost = Thretta.Wage + Humanities.Upkeep;
        Arts.Cost = Robert.Wage + Arts.Upkeep;
        Sciences.Cost = Nigel.Wage + Sciences.Upkeep;
        Maths.Cost = Shaq.Wage + Maths.Upkeep;
        ComGrant.Amount = ComGrant.Modifier * 1000 * Computing.Quality * Gil.Quality;
        HumGrant.Amount = HumGrant.Modifier *1000 * Humanities.Quality * Thretta.Quality;
        ArtGrant.Amount = ArtGrant.Modifier * 1000 * Arts.Quality * Robert.Quality;
        SciGrant.Amount = SciGrant.Modifier * 1000 * Sciences.Quality * Nigel.Quality;
        MatGrant.Amount = MatGrant.Modifier * 1000 * Maths.Quality * Shaq.Quality;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    public void QuitGame()
{
    Application.Quit();
}
}
