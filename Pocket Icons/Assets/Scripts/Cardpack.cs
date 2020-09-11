using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cardpack : MonoBehaviour
{

    public int CardsInDeck;
    List<Card> CardList;
    
    public Cardpack()
    {
        CardList.Shuffle();
    }
}
