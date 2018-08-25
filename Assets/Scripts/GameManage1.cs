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
    private float timeBetween = 5f;

    [SerializeField]
    private Text playersGems;

    [SerializeField]
    private Text armyForce;


    [SerializeField]
    public GameObject CountriesList;


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
   
    IEnumerator TransitionToNextQuestion() {
        
        Debug.Log("time Start");
        yield return new WaitForSeconds(timeBetween);
        Debug.Log("time left");

    }
    public void SetPlayer(){
        if (money > 0) {
            playersMoney.text = money.ToString() + "$";
            playersEarnings.text = "Your earnings per step: " + earningsPerStep.ToString() + "$  ";
            playersGems.text = gems.ToString();
            armyForce.text = "Force: " + force.ToString();
        }else{
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

    }

}
