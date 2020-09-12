using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInitializer : MonoBehaviour {
    public List<Card> GetCardsFromJson () {
        List<Card> cardList = new List<Card> ();
        TextAsset file = Resources.Load<TextAsset> ("Cards");
        string jsonString = file.text;
        Debug.Log(jsonString);
        Card[] cards = FromJson<Card>(jsonString);

        if (cards.Length > 0) {
            foreach (Card card in cards) {
                cardList.Add (card);
            }
        } else {
            Debug.Log("Failed reading json");
        }

        return cardList;
    }

    public static T[] FromJson<T> (string json) {
        Wrapper<T> wrapper = JsonUtility.FromJson<Wrapper<T>> (json);
        return wrapper.Items;
    }

    [System.Serializable]
    private class Wrapper<T> {
        public T[] Items;
    }

}