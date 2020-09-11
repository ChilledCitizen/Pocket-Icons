using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    public int ReputationCost;
    public int Power;
    public bool IsBlessing;
    public string Title;
    public string Body;
    public Image PowerImage;
    
    public Card(int rep, int power, bool blessing, string title, string body)
    {
        ReputationCost = rep;
        Power = power;
        IsBlessing = blessing;
        Title = title;
        Body = body;

        if(IsBlessing)
        {
            PowerImage.color = Color.green;
        }
        else
        {
            PowerImage.color = Color.red;
        }
    }
}
