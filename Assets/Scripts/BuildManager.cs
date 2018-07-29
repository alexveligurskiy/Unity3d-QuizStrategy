
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class BuildManager : MonoBehaviour {
    public EcologyBuildings[] ecologyBuildings;
    public ProductionBuildings[] productionBuildings;
    public ScienceBuildings[] scienceBuildings;
    public ArmyBuildings[] armyBuildings;

    private static List<EcologyBuildings> ecoBuilds;
    private static List<ProductionBuildings> prodBuilds;
    private static List<ScienceBuildings> sciBuilds;
    private static List<ArmyBuildings> armyBuilds;

    //initializing fields
    //note: good to make a prefab, but now i dont care && just want to make it work
    [SerializeField]
    private Text priceText1;
    [SerializeField]
    private Text buildingText1;
    [SerializeField]
    private Image buildingImage1;

    [SerializeField]
    private Text priceText2;
    [SerializeField]
    private Text buildingText2;
    [SerializeField]
    private Image buildingImage2;

    [SerializeField]
    private Text priceText3;
    [SerializeField]
    private Text buildingText3;
    [SerializeField]
    private Image buildingImage3;

    [SerializeField]
    private Text priceText4;
    [SerializeField]
    private Text buildingText4;
    [SerializeField]
    private Image buildingImage4;

    [SerializeField]
    private Text priceText5;
    [SerializeField]
    private Text buildingText5;
    [SerializeField]
    private Image buildingImage5;

    [SerializeField]
    private Text priceText6;
    [SerializeField]
    private Text buildingText6;
    [SerializeField]
    private Image buildingImage6;

    [SerializeField]
    private Text priceText7;
    [SerializeField]
    private Text buildingText7;
    [SerializeField]
    private Image buildingImage7;

    [SerializeField]
    private Text priceText8;
    [SerializeField]
    private Text buildingText8;
    [SerializeField]
    private Image buildingImage8;

    [SerializeField]
    private Text priceText9;
    [SerializeField]
    private Text buildingText9;
    [SerializeField]
    private Image buildingImage9;

    [SerializeField]
    private Text priceText10;
    [SerializeField]
    private Text buildingText10;
    [SerializeField]
    private Image buildingImage10;
    int buyPrice;
    int buttonChoose;
    int buildingChoose;
    public void Start()
    {
        

    }
    public void Buy1Building()
    {
        if (buttonChoose == 1){
            buyPrice = ecoBuilds[0].cost;
        }else if(buttonChoose == 2){
            buyPrice = prodBuilds[0].cost;
        }else if (buttonChoose == 3){
            buyPrice = armyBuilds[0].cost;
        }else if (buttonChoose == 4){
            buyPrice = sciBuilds[0].cost;
        }
        if(buyPrice <= GameObject.Find("GameManager").GetComponent<GameManage1>().money){
            GameObject.Find("GameManager").GetComponent<GameManage1>().money -= buyPrice;
            Debug.Log("Money - " + buyPrice);
        }else{
            Debug.Log("You cant buy this(no money)");
        }
    }
    public void Buy2Building()
    {
        if (buttonChoose == 1)
        {
            buyPrice = ecoBuilds[1].cost;
        }
        else if (buttonChoose == 2)
        {
            buyPrice = prodBuilds[1].cost;
        }
        else if (buttonChoose == 3)
        {
            buyPrice = armyBuilds[1].cost;
        }
        else if (buttonChoose == 4)
        {
            buyPrice = sciBuilds[1].cost;
        }

        if (buyPrice <= GameObject.Find("GameManager").GetComponent<GameManage1>().money)
        {
            GameObject.Find("GameManager").GetComponent<GameManage1>().money -= buyPrice;
            Debug.Log("Money - " + buyPrice);
        }
        else
        {
            Debug.Log("You cant buy this(no money)");
        }
    }
    public void Buy3Building()
    {
        if (buttonChoose == 1)
        {
            buyPrice = ecoBuilds[2].cost;
        }
        else if (buttonChoose == 2)
        {
            buyPrice = prodBuilds[2].cost;
        }
        else if (buttonChoose == 3)
        {
            buyPrice = armyBuilds[2].cost;
        }
        else if (buttonChoose == 4)
        {
            buyPrice = sciBuilds[2].cost;
        }

        if (buyPrice <= GameObject.Find("GameManager").GetComponent<GameManage1>().money)
        {
            GameObject.Find("GameManager").GetComponent<GameManage1>().money -= buyPrice;
            Debug.Log("Money - " + buyPrice);
        }
        else
        {
            Debug.Log("You cant buy this(no money)");
        }
    }
    public void Buy4Building()
    {
        if (buttonChoose == 1)
        {
            buyPrice = ecoBuilds[3].cost;
        }
        else if (buttonChoose == 2)
        {
            buyPrice = prodBuilds[3].cost;
        }
        else if (buttonChoose == 3)
        {
            buyPrice = armyBuilds[3].cost;
        }
        else if (buttonChoose == 4)
        {
            buyPrice = sciBuilds[3].cost;
        }

        if (buyPrice <= GameObject.Find("GameManager").GetComponent<GameManage1>().money)
        {
            GameObject.Find("GameManager").GetComponent<GameManage1>().money -= buyPrice;
            Debug.Log("Money - " + buyPrice);
        }
        else
        {
            Debug.Log("You cant buy this(no money)");
        }
    }
    public void Buy5Building()
    {
        if (buttonChoose == 1)
        {
            buyPrice = ecoBuilds[4].cost;
        }
        else if (buttonChoose == 2)
        {
            buyPrice = prodBuilds[4].cost;
        }
        else if (buttonChoose == 3)
        {
            buyPrice = armyBuilds[4].cost;
        }
        else if (buttonChoose == 4)
        {
            buyPrice = sciBuilds[4].cost;
        }

        if (buyPrice <= GameObject.Find("GameManager").GetComponent<GameManage1>().money)
        {
            GameObject.Find("GameManager").GetComponent<GameManage1>().money -= buyPrice;
            Debug.Log("Money - " + buyPrice);
        }
        else
        {
            Debug.Log("You cant buy this(no money)");
        }
    }
    public void Buy6Building()
    {
        if (buttonChoose == 1)
        {
            buyPrice = ecoBuilds[5].cost;
        }
        else if (buttonChoose == 2)
        {
            buyPrice = prodBuilds[5].cost;
        }
        else if (buttonChoose == 3)
        {
            buyPrice = armyBuilds[5].cost;
        }
        else if (buttonChoose == 4)
        {
            buyPrice = sciBuilds[5].cost;
        }

        if (buyPrice <= GameObject.Find("GameManager").GetComponent<GameManage1>().money)
        {
            GameObject.Find("GameManager").GetComponent<GameManage1>().money -= buyPrice;
            Debug.Log("Money - " + buyPrice);
        }
        else
        {
            Debug.Log("You cant buy this(no money)");
        }
    }
    public void Buy7Building()
    {
        if (buttonChoose == 1)
        {
            buyPrice = ecoBuilds[6].cost;
        }
        else if (buttonChoose == 2)
        {
            buyPrice = prodBuilds[6].cost;
        }
        else if (buttonChoose == 3)
        {
            buyPrice = armyBuilds[6].cost;
        }
        else if (buttonChoose == 4)
        {
            buyPrice = sciBuilds[6].cost;
        }

        if (buyPrice <= GameObject.Find("GameManager").GetComponent<GameManage1>().money)
        {
            GameObject.Find("GameManager").GetComponent<GameManage1>().money -= buyPrice;
            Debug.Log("Money - " + buyPrice);
        }
        else
        {
            Debug.Log("You cant buy this(no money)");
        }
    }
    public void Buy8Building()
    {
        if (buttonChoose == 1)
        {
            buyPrice = ecoBuilds[7].cost;
        }
        else if (buttonChoose == 2)
        {
            buyPrice = prodBuilds[7].cost;
        }
        else if (buttonChoose == 3)
        {
            buyPrice = armyBuilds[7].cost;
        }
        else if (buttonChoose == 4)
        {
            buyPrice = sciBuilds[7].cost;
        }

        if (buyPrice <= GameObject.Find("GameManager").GetComponent<GameManage1>().money)
        {
            GameObject.Find("GameManager").GetComponent<GameManage1>().money -= buyPrice;
            Debug.Log("Money - " + buyPrice);
        }
        else
        {
            Debug.Log("You cant buy this(no money)");
        }
    }
    public void Buy9Building()
    {
        if (buttonChoose == 1)
        {
            buyPrice = ecoBuilds[8].cost;
        }
        else if (buttonChoose == 2)
        {
            buyPrice = prodBuilds[8].cost;
        }
        else if (buttonChoose == 3)
        {
            buyPrice = armyBuilds[8].cost;
        }
        else if (buttonChoose == 4)
        {
            buyPrice = sciBuilds[8].cost;
        }

        if (buyPrice <= GameObject.Find("GameManager").GetComponent<GameManage1>().money)
        {
            GameObject.Find("GameManager").GetComponent<GameManage1>().money -= buyPrice;
            Debug.Log("Money - " + buyPrice);
        }
        else
        {
            Debug.Log("You cant buy this(no money)");
        }
    }
    public void Buy10Building()
    {
        if (buttonChoose == 1)
        {
            buyPrice = ecoBuilds[9].cost;
        }
        else if (buttonChoose == 2)
        {
            buyPrice = prodBuilds[9].cost;
        }
        else if (buttonChoose == 3)
        {
            buyPrice = armyBuilds[9].cost;
        }
        else if (buttonChoose == 4)
        {
            buyPrice = sciBuilds[9].cost;
        }

        if (buyPrice <= GameObject.Find("GameManager").GetComponent<GameManage1>().money)
        {
            GameObject.Find("GameManager").GetComponent<GameManage1>().money -= buyPrice;
            Debug.Log("Money - " + buyPrice);
        }
        else
        {
            Debug.Log("You cant buy this(no money)");
        }
    }
    public void EcologyPressed(){
        buttonChoose = 1;
        Debug.Log(buttonChoose);
        if (ecoBuilds == null || ecoBuilds.Count == 0)
        {
            ecoBuilds = ecologyBuildings.ToList<EcologyBuildings>();
        }
        priceText1.text = "Cost: " + ecoBuilds[0].cost;
        buildingText1.text = ecoBuilds[0].name;
        buildingImage1.sprite = ecoBuilds[0].picture;

        priceText2.text = "Cost: " + ecoBuilds[1].cost;
        buildingText2.text = ecoBuilds[1].name;
        buildingImage2.sprite = ecoBuilds[1].picture;

        priceText3.text = "Cost: " + ecoBuilds[2].cost;
        buildingText3.text = ecoBuilds[2].name;
        buildingImage3.sprite = ecoBuilds[2].picture;

        priceText4.text = "Cost: " + ecoBuilds[3].cost;
        buildingText4.text = ecoBuilds[3].name;
        buildingImage4.sprite = ecoBuilds[3].picture;

        priceText5.text = "Cost: " + ecoBuilds[4].cost;
        buildingText5.text = ecoBuilds[4].name;
        buildingImage5.sprite = ecoBuilds[4].picture;

        priceText6.text = "Cost: " + ecoBuilds[5].cost;
        buildingText6.text = ecoBuilds[5].name;
        buildingImage6.sprite = ecoBuilds[5].picture;

        priceText7.text = "Cost: " + ecoBuilds[6].cost;
        buildingText7.text = ecoBuilds[6].name;
        buildingImage7.sprite = ecoBuilds[6].picture;

        priceText8.text = "Cost: " + ecoBuilds[7].cost;
        buildingText8.text = ecoBuilds[7].name;
        buildingImage8.sprite = ecoBuilds[7].picture;

        priceText9.text = "Cost: " + ecoBuilds[8].cost;
        buildingText9.text = ecoBuilds[8].name;
        buildingImage9.sprite = ecoBuilds[8].picture;

        priceText10.text = "Cost: " + ecoBuilds[9].cost;
        buildingText10.text = ecoBuilds[9].name;
        buildingImage10.sprite = ecoBuilds[9].picture;
    }
    public void ProductionPressed()
    {
        
        buttonChoose = 2;
        Debug.Log(buttonChoose);
        if (prodBuilds == null || prodBuilds.Count == 0)
        {
            prodBuilds = productionBuildings.ToList<ProductionBuildings>();
        }
        priceText1.text = "Cost: " + prodBuilds[0].cost;
        buildingText1.text = prodBuilds[0].name;
        buildingImage1.sprite = prodBuilds[0].picture;

        priceText2.text = "Cost: " + prodBuilds[1].cost;
        buildingText2.text = prodBuilds[1].name;
        buildingImage2.sprite = prodBuilds[1].picture;

        priceText3.text = "Cost: " + prodBuilds[2].cost;
        buildingText3.text = prodBuilds[2].name;
        buildingImage3.sprite = prodBuilds[2].picture;

        priceText4.text = "Cost: " + prodBuilds[3].cost;
        buildingText4.text = prodBuilds[3].name;
        buildingImage4.sprite = prodBuilds[3].picture;

        priceText5.text = "Cost: " + prodBuilds[4].cost;
        buildingText5.text = prodBuilds[4].name;
        buildingImage5.sprite = prodBuilds[4].picture;

        priceText6.text = "Cost: " + prodBuilds[5].cost;
        buildingText6.text = prodBuilds[5].name;
        buildingImage6.sprite = prodBuilds[5].picture;

        priceText7.text = "Cost: " + prodBuilds[6].cost;
        buildingText7.text = prodBuilds[6].name;
        buildingImage7.sprite = prodBuilds[6].picture;

        priceText8.text = "Cost: " + prodBuilds[7].cost;
        buildingText8.text = prodBuilds[7].name;
        buildingImage8.sprite = prodBuilds[7].picture;

        priceText9.text = "Cost: " + prodBuilds[8].cost;
        buildingText9.text = prodBuilds[8].name;
        buildingImage9.sprite = prodBuilds[8].picture;

        priceText10.text = "Cost: " + prodBuilds[9].cost;
        buildingText10.text = prodBuilds[9].name;
        buildingImage10.sprite = prodBuilds[9].picture;


    }
    public void ArmyPressed()
    {
        
        buttonChoose = 3;
        Debug.Log(buttonChoose);
        if (armyBuilds == null || armyBuilds.Count == 0)
        {
            armyBuilds = armyBuildings.ToList<ArmyBuildings>();
        }
        priceText1.text = "Cost: " + armyBuilds[0].cost;
        buildingText1.text = armyBuilds[0].name;
        buildingImage1.sprite = armyBuilds[0].picture;

        priceText2.text = "Cost: " + armyBuilds[1].cost;
        buildingText2.text = armyBuilds[1].name;
        buildingImage2.sprite = armyBuilds[1].picture;

        priceText3.text = "Cost: " + armyBuilds[2].cost;
        buildingText3.text = armyBuilds[2].name;
        buildingImage3.sprite = armyBuilds[2].picture;

        priceText4.text = "Cost: " + armyBuilds[3].cost;
        buildingText4.text = armyBuilds[3].name;
        buildingImage4.sprite = armyBuilds[3].picture;

        priceText5.text = "Cost: " + armyBuilds[4].cost;
        buildingText5.text = armyBuilds[4].name;
        buildingImage5.sprite = armyBuilds[4].picture;

        priceText6.text = "Cost: " + armyBuilds[5].cost;
        buildingText6.text = armyBuilds[5].name;
        buildingImage6.sprite = armyBuilds[5].picture;

        priceText7.text = "Cost: " + armyBuilds[6].cost;
        buildingText7.text = armyBuilds[6].name;
        buildingImage7.sprite = armyBuilds[6].picture;

        priceText8.text = "Cost: " + armyBuilds[7].cost;
        buildingText8.text = armyBuilds[7].name;
        buildingImage8.sprite = armyBuilds[7].picture;

        priceText9.text = "Cost: " + armyBuilds[8].cost;
        buildingText9.text = armyBuilds[8].name;
        buildingImage9.sprite = armyBuilds[8].picture;

        priceText10.text = "Cost: " + armyBuilds[9].cost;
        buildingText10.text = armyBuilds[9].name;
        buildingImage10.sprite = armyBuilds[9].picture;
    }
    public void SciencePressed()
    {
        
        buttonChoose = 4;
        Debug.Log(buttonChoose);
        if (sciBuilds == null || sciBuilds.Count == 0)
        {
            sciBuilds = scienceBuildings.ToList<ScienceBuildings>();
        }
        priceText1.text = "Cost: " + sciBuilds[0].cost;
        buildingText1.text = sciBuilds[0].name;
        buildingImage1.sprite = sciBuilds[0].picture;

        priceText2.text = "Cost: " + sciBuilds[1].cost;
        buildingText2.text = sciBuilds[1].name;
        buildingImage2.sprite = sciBuilds[1].picture;

        priceText3.text = "Cost: " + sciBuilds[2].cost;
        buildingText3.text = sciBuilds[2].name;
        buildingImage3.sprite = sciBuilds[2].picture;

        priceText4.text = "Cost: " + sciBuilds[3].cost;
        buildingText4.text = sciBuilds[3].name;
        buildingImage4.sprite = sciBuilds[3].picture;

        priceText5.text = "Cost: " + sciBuilds[4].cost;
        buildingText5.text = sciBuilds[4].name;
        buildingImage5.sprite = sciBuilds[4].picture;

        priceText6.text = "Cost: " + sciBuilds[5].cost;
        buildingText6.text = sciBuilds[5].name;
        buildingImage6.sprite = sciBuilds[5].picture;

        priceText7.text = "Cost: " + sciBuilds[6].cost;
        buildingText7.text = sciBuilds[6].name;
        buildingImage7.sprite = sciBuilds[6].picture;

        priceText8.text = "Cost: " + sciBuilds[7].cost;
        buildingText8.text = sciBuilds[7].name;
        buildingImage8.sprite = sciBuilds[7].picture;

        priceText9.text = "Cost: " + sciBuilds[8].cost;
        buildingText9.text = sciBuilds[8].name;
        buildingImage9.sprite = sciBuilds[8].picture;

        priceText10.text = "Cost: " + sciBuilds[9].cost;
        buildingText10.text = sciBuilds[9].name;
        buildingImage10.sprite = sciBuilds[9].picture;
    }
}
