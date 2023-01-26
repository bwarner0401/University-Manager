using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question
{
    public string Question_text { get; set; }
    public string Yes_result { get; set; }
    public string No_result { get; set; }
    public string Dept { get; set; }

    public Question(string qt, string yr, string nr, string dept)
    {
        Question_text = qt;
        Yes_result = yr;
        No_result = nr;
        Dept = dept;
    }
}
