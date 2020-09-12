using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandController : MonoBehaviour
{
    public int CardsInHand;
    public GameObject HandContainer;

    public void AddCard(Card card, GameObject cardprefab)
    {
        GameObject g = Instantiate(cardprefab);
        var tmpCard = g.GetComponent<Card>();
        tmpCard = card;
        g.transform.parent = HandContainer.transform;
    }

    public void PlayCard()
    {

    }

}
