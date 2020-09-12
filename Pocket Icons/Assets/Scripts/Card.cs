using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card {
    public string Title;
    public string Body;
    public int ReputationCost;
    public int IsBlessing;
    public int Power;
    // public Image PowerImage;
    // public Image CharacterFace;

    // private void Start () {
    //     if (IsBlessing) {
    //         PowerImage.color = Color.green;
    //     } else {
    //         PowerImage.color = Color.red;
    //     }

    //     try {
    //         CharacterFace.sprite = Resources.Load<Sprite> ("Faces/" + Title);
    //     } catch {
    //         Debug.LogError("Failed loading face");
    //     }

    // }

}