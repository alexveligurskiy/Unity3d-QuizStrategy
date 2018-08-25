using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Buildings : MonoBehaviour {

    public Button buttonComponent;
    public Text nameText;
    public Text priceText;
    public Image iconImage;
    public Text earningsText;

    public Text armyForceText;
    public Text armyForcePerStepText;

    public Text ecoContText;
    public Text peopContText;
    public Text armyContText;
    public Text sciContText;


    private Building item;
    private ShopScrollList scrollList;

    // Use this for initialization
    void Start() {
        buttonComponent.onClick.AddListener(HandleClick);

    }

    public void Setup(Building currentItem, ShopScrollList currentScrollList) {
        item = currentItem;
        nameText.text = item.name;
        iconImage.sprite = item.icon;

        priceText.text = "Cost: " + item.price.ToString();
        if(item.earnings >= 0){
            earningsText.text = "+" + item.earnings.ToString() + "/Step";
        }else{
            earningsText.text = item.earnings.ToString() + "/Step";
        }
        if(item.armyForce > 0 ){
            armyForceText.text = "Army: +" + item.armyForce.ToString();
        }else{
            armyForceText.text = "";
        }

        if (item.armyForcePerStep > 0) {
            armyForcePerStepText.text = "+" + item.armyForcePerStep.ToString() + "/step";
        } else {
            armyForcePerStepText.text = "";
        }
       
        if (item.ecologyCont >= 0) {
            ecoContText.text = "+" + item.ecologyCont.ToString();
        } else {
            ecoContText.text = item.ecologyCont.ToString();
        }
        if (item.peopleCont >= 0) {
            peopContText.text = "+" + item.peopleCont.ToString();
        } else {
            peopContText.text = item.peopleCont.ToString();
        }
        if (item.armyCont >= 0) {
            armyContText.text = "+" + item.armyCont.ToString();
        } else {
            armyContText.text = item.armyCont.ToString();
        }
        if (item.scienceCont >= 0) {
            sciContText.text = "+" + item.scienceCont.ToString();
        }else {
            sciContText.text = item.scienceCont.ToString();
        }


        scrollList = currentScrollList;

    }
    public void SetupBuilded(Building currentItem, ShopScrollList currentScrollList) {
        item = currentItem;
        nameText.text = item.name;
        iconImage.sprite = item.icon;
       
        priceText.text = "Builded";
        if (item.earnings >= 0) {
            earningsText.text = "+" + item.earnings.ToString() + "/Step";
        } else {
            earningsText.text = item.earnings.ToString() + "/Step";
        }
        if (item.armyForce > 0) {
            armyForceText.text = "Army: +" + item.armyForce.ToString();
        } else {
            armyForceText.text = "";
        }

        if (item.armyForcePerStep > 0) {
            armyForcePerStepText.text = "+" + item.armyForcePerStep.ToString() + "/step";
        } else {
            armyForcePerStepText.text = "";
        }

        if (item.ecologyCont >= 0) {
            ecoContText.text = "+" + item.ecologyCont.ToString();
        } else {
            ecoContText.text = item.ecologyCont.ToString();
        }
        if (item.peopleCont >= 0) {
            peopContText.text = "+" + item.peopleCont.ToString();
        } else {
            peopContText.text = item.peopleCont.ToString();
        }
        if (item.armyCont >= 0) {
            armyContText.text = "+" + item.armyCont.ToString();
        } else {
            armyContText.text = item.armyCont.ToString();
        }
        if (item.scienceCont >= 0) {
            sciContText.text = "+" + item.scienceCont.ToString();
        } else {
            sciContText.text = item.scienceCont.ToString();
        }


        scrollList = currentScrollList;

    }
    public void HandleClick() {
        scrollList.BuyBuilding(item);
        GameObject.FindWithTag("PlayerCountryButton").GetComponent<Button>().enabled = false;

    }
 
}