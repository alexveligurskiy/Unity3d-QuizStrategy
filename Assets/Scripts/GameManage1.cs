using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManage1 : MonoBehaviour {
    public Countries[] countries;
    private static List<Countries> unchosenCountry;
    private Countries currentCountry;

    [SerializeField]
    private Text stepText;

    [SerializeField]
    private Text FinalScore;

    [SerializeField]
    public Text playersMoney;

    [SerializeField]
    public Text playersEarnings;

   

    [SerializeField]
    private Text playersGems;

    [SerializeField]
    private Text armyForce;


    [SerializeField]
    public GameObject CountriesList;
    public ContentmentManager contentmentManager;
    public GameObject endGameMenu;

    public int step = 1;
    public float money = 0;
    public float gems = 10;
    public float earningsPerStep;
    public int force = 0;
    public int forcePerStep = 2;
    public void Start(){
        if (unchosenCountry == null || unchosenCountry.Count == 0){
            unchosenCountry = countries.ToList<Countries>();
        }

        SetPlayer();
    }
   

    public void SetPlayer(){
        if (money > 0) {
            playersMoney.text = money.ToString() + "$";
            playersEarnings.text = "Your earnings per step: " + earningsPerStep.ToString() + "$  ";
            playersGems.text = gems.ToString();
            armyForce.text = "Force: " + force.ToString();
        }else{
            
        }
        if (contentmentManager.ecologyCount == 0 || contentmentManager.scienceCount == 0 || contentmentManager.armyCount == 0 || contentmentManager.peopleCount == 0) {
            PlayerLosed();
        }else if(contentmentManager.ecologyCount == 20 || contentmentManager.scienceCount == 20 || contentmentManager.armyCount == 20 || contentmentManager.peopleCount == 20){
            PlayerLosed();
        }
    }
   
    public void UserPushedButton(){
        CountriesList strana = CountriesList.GetComponent<CountriesList>();
        strana.CountriesForcePlus();



        money += earningsPerStep;
        force += forcePerStep;
        SetPlayer();


        step++;
        stepText.text = step.ToString();

        //set in player losed
        FinalScore.text = "Your score is :" + step;
    }
    public void PlayerLosed(){
        Debug.Log("You Losed!!!");
        endGameMenu.SetActive(true);

    }

}
