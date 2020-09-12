using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour {
    public string Title;
    public string Body;
    public int ReputationCost;
    public int IsBlessing;
    public int Power;
    public Image PowerImage;
    public Image CharacterFace;

    public void SetFace (Sprite face) {
        //CharacterFace.sprite = face;
    }

    public void SetIsBlessing () {
        if (IsBlessing == 1) {
            PowerImage.color = Color.green;
        } else {
            PowerImage.color = Color.red;
        }
    }

}