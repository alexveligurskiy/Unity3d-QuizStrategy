using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

[System.Serializable]
public class Building {
    
    public string name;
    public float price;
    public Sprite icon;

    public float earnings;
    public bool isBuild;
    public bool isDestroyed;
    public int kindOfBuilding;
    public int armyForce;
    public int armyForcePerStep;
    public int ecologyCont;
    public int peopleCont;
    public int armyCont;
    public int scienceCont;
}
//kindOfBuilding
//1 - Ecology
//2 - Production
//3 - Army
//4 - Science
//5 - Specials


public class ShopScrollList : MonoBehaviour {
    



    public GameObject objectB;

    public List<Building> buildings;


    public Transform contentPanel;

    public Text moneyDisplay;
    public SimpleObjectPool buttonObjectPool;



    int counter = 0;
    // Use this for initialization
    void Start() {


        RefreshDisplay();

    }

    void RefreshDisplay() {
        objectB.GetComponent<GameManage1>().SetPlayer();
        RemoveButtons();
        AddBuildings();

    }

    private void RemoveButtons() {
        while (contentPanel.childCount > 0) {
            GameObject toRemove = transform.GetChild(0).gameObject;
            buttonObjectPool.ReturnObject(toRemove);
        }
    }

    private void AddBuildings() {
        for (int i = 0; i < buildings.Count; i++) {
            Building item = buildings[i];
            if (item.isBuild == false) {
                if (buildings[i].kindOfBuilding == 1 && counter == 1) {
                    GameObject newButton = buttonObjectPool.GetObject();
                    newButton.transform.SetParent(contentPanel);

                    Buildings sampleButton = newButton.GetComponent<Buildings>();
                    sampleButton.Setup(item, this);
                }
                if (buildings[i].kindOfBuilding == 2 && counter == 2) {
                    GameObject newButton = buttonObjectPool.GetObject();
                    newButton.transform.SetParent(contentPanel);

                    Buildings sampleButton = newButton.GetComponent<Buildings>();
                    sampleButton.Setup(item, this);
                }
                if (buildings[i].kindOfBuilding == 3 && counter == 3) {
                    GameObject newButton = buttonObjectPool.GetObject();
                    newButton.transform.SetParent(contentPanel);

                    Buildings sampleButton = newButton.GetComponent<Buildings>();
                    sampleButton.Setup(item, this);
                }
                if (buildings[i].kindOfBuilding == 4 && counter == 4) {
                    GameObject newButton = buttonObjectPool.GetObject();
                    newButton.transform.SetParent(contentPanel);

                    Buildings sampleButton = newButton.GetComponent<Buildings>();
                    sampleButton.Setup(item, this);
                }
                if (buildings[i].kindOfBuilding == 5 && counter == 5) {
                    GameObject newButton = buttonObjectPool.GetObject();
                    newButton.transform.SetParent(contentPanel);

                    Buildings sampleButton = newButton.GetComponent<Buildings>();
                    sampleButton.Setup(item, this);
                }
            }else{
                if (buildings[i].kindOfBuilding == 1 && counter == 1) {
                    GameObject newButton = buttonObjectPool.GetObject();
                    newButton.transform.SetParent(contentPanel);

                    Buildings sampleButton = newButton.GetComponent<Buildings>();
                    sampleButton.SetupBuilded(item, this);
                }
                if (buildings[i].kindOfBuilding == 2 && counter == 2) {
                    GameObject newButton = buttonObjectPool.GetObject();
                    newButton.transform.SetParent(contentPanel);

                    Buildings sampleButton = newButton.GetComponent<Buildings>();
                    sampleButton.SetupBuilded(item, this);
                }
                if (buildings[i].kindOfBuilding == 3 && counter == 3) {
                    GameObject newButton = buttonObjectPool.GetObject();
                    newButton.transform.SetParent(contentPanel);

                    Buildings sampleButton = newButton.GetComponent<Buildings>();
                    sampleButton.SetupBuilded(item, this);
                }
                if (buildings[i].kindOfBuilding == 4 && counter == 4) {
                    GameObject newButton = buttonObjectPool.GetObject();
                    newButton.transform.SetParent(contentPanel);

                    Buildings sampleButton = newButton.GetComponent<Buildings>();
                    sampleButton.SetupBuilded(item, this);
                }
                if (buildings[i].kindOfBuilding == 5 && counter == 5) {
                    GameObject newButton = buttonObjectPool.GetObject();
                    newButton.transform.SetParent(contentPanel);

                    Buildings sampleButton = newButton.GetComponent<Buildings>();
                    sampleButton.SetupBuilded(item, this);
                }
            }
        }
    }


    public void BuyBuilding(Building item) {
        if (objectB.GetComponent<GameManage1>().money >= item.price && item.isBuild == false) {
            
            if(item.kindOfBuilding == 5){
                objectB.GetComponent<GameManage1>().gems -= item.price;
            }else{
                
                objectB.GetComponent<GameManage1>().money -= item.price;
            }
            item.isBuild = true;
           
            objectB.GetComponent<GameManage1>().earningsPerStep += item.earnings;
            objectB.GetComponent<GameManage1>().force += item.armyForce;
            objectB.GetComponent<GameManage1>().forcePerStep += item.armyForcePerStep;

            GameObject.Find("ContentmentManager").GetComponent<ContentmentManager>().ecologyCount += item.ecologyCont;
            GameObject.Find("ContentmentManager").GetComponent<ContentmentManager>().peopleCount += item.peopleCont;
            GameObject.Find("ContentmentManager").GetComponent<ContentmentManager>().armyCount += item.armyCont;
            GameObject.Find("ContentmentManager").GetComponent<ContentmentManager>().scienceCount += item.scienceCont;
            //RemoveItem(item, this); //to delete bought building from the list
            Debug.Log("Building '" + item.name + "' was bought.");
            RefreshDisplay();


           
            GameObject.FindWithTag("PlayerCountryMenu").SetActive(false);
        }else{
            Debug.Log("No money, no honey!");
        }

    }

    void AddItem(Building itemToAdd, ShopScrollList shopList) {
        shopList.buildings.Add(itemToAdd);
    }


    private void RemoveItem(Building itemToRemove, ShopScrollList shopList) {
        for (int i = shopList.buildings.Count - 1; i >= 0; i--) {
            if (shopList.buildings[i] == itemToRemove) {
                shopList.buildings.RemoveAt(i);

            }
        }
    }

   



    public void EcologyPressed(){
        counter = 1;
        //buildings.Sort((x, y) => y.price.CompareTo(x.price));
        RefreshDisplay();

    }
    public void ProductionPressed() {
        counter = 2;
        RefreshDisplay();

    }
    public void ArmyPressed() {
        counter = 3;
        RefreshDisplay();
    }
    public void SciencePressed() {
        counter = 4;
        RefreshDisplay();
    }
    public void SpecialsPressed() {
        counter = 5;
        RefreshDisplay();
    }

}