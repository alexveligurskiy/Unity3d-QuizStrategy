
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
    public Text playersMoney;

    [SerializeField]
    private Text playersGems;
    [SerializeField]
    private Text firstName;
    [SerializeField]
    private Text secondName;
    [SerializeField]
    private Text thirdName;
    [SerializeField]
    private Text fourthName;
    [SerializeField]
    private Text fifthName;
    [SerializeField]
    private Text sixthName;
    [SerializeField]
    private Text seventhName;
    [SerializeField]
    private Text eighthName;

    private int step = 1;
    public int money = 1000000;
    public int gems = 10;
    public void Start()
    {
        if (unchosenCountry == null || unchosenCountry.Count == 0)
        {
            unchosenCountry = countries.ToList<Countries>();
        }
        SetCountryName();

    }
    public void Update()
    {
        if (money >= 0)
        {
            SetPlayersMoney();

        }else{
            SceneManager.LoadScene("MenuScene");
            Debug.Log("No money, You lose");
        }
        SetPlayersGems();
    }

    void SetPlayersMoney(){
        playersMoney.text = money.ToString() + "$";
    }
    void SetPlayersGems()
    {
        playersGems.text = gems.ToString();
    }
    void SetCountryName()
    {
        firstName.text = unchosenCountry[0].country;
        secondName.text = unchosenCountry[1].country;
        thirdName.text = unchosenCountry[2].country;
        fourthName.text = unchosenCountry[3].country;
        fifthName.text = unchosenCountry[4].country;
        sixthName.text = unchosenCountry[5].country;
        seventhName.text = unchosenCountry[6].country;
        eighthName.text = unchosenCountry[7].country;

    }
    void SetRandomCountryName(){
        int randomQuestionIndex = Random.Range(0, unchosenCountry.Count);
        currentCountry = unchosenCountry[randomQuestionIndex];
    }

    public void UserPushedButton()
    {
        
        step++;
        stepText.text = "Step: " + step;

    }
}
