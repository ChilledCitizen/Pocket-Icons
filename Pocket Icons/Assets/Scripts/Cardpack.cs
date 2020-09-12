using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cardpack : MonoBehaviour
{

    public List<Card> CardList;
    private int _cardIndex = 0;
    
    public Card DrawCard()
    {
        Card card = CardList[_cardIndex];
        _cardIndex++;
        return card;
    }
}
