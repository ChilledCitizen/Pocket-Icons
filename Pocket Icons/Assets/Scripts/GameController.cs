using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public int TurnTimelimit = 60;
    public bool PlayerTurn;

    public Cardpack PlayerPack;
    public Cardpack AIPack;
    public UIController UIControl;
    public CardInitializer Initializer;
    public List<Card> AllCards;
    // Start is called before the first frame update
    void Start()
    {
        AllCards = Initializer.GetCardsFromJson();
        Debug.Log(AllCards.Count);
        AllCards.Shuffle();
        foreach(var card in AllCards)
        {
            Debug.Log(card.Title);
        }

        for(int i = 0; i <= 20; i++)
        {
            PlayerPack.CardList.Add(AllCards[i]);
            AIPack.CardList.Add(AllCards[i]);
        }

        PlayerPack.CardList.Shuffle();
        AIPack.CardList.Shuffle();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
