using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Countries : MonoBehaviour {


    public Text nameText;


    public Text armyForceText;
    public Text focusedOnText;

    public Text relationshipText;
    public Text behaviorText;

    private Country item;


    public void Setup(Country currentItem) {
        item = currentItem;
        nameText.text = item.name;


        armyForceText.text = "Army force: " + item.armyForce.ToString();
        focusedOnText.text = "Focused on: " +item.focusedOn;

        relationshipText.text = "Relation: " + item.relationship.ToString() + "/10";
        behaviorText.text = "Behavior: " + item.behavior;




    }
}