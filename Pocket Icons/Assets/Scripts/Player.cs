using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Cardpack pack;
    public int Shade = 0;
    public int RepAmount;
    public int RepMax = 5;
    public void StartTurn()
    {

    }

    public void Battle()
    {

    }

    public void EndTurn()
    {

    }

    public void ReceiveShade(int amount)
    {
        Shade += amount;
    }

      public void AddRep()
    {
        RepMax++;
    }
}
