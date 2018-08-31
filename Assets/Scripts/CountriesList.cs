using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;

[System.Serializable]
public class Country {
    public string name;

    public string focusedOn;
    public int focus;
    public int relationship;
    public string behavior;
    public int armyForce;
    public int forcePerStep;
    public Text nameText;
    public Text relationText;
    public List<Questions> countryQuestion;
    public List<Questions> unansweredQuestions;
}
[System.Serializable]
public class Questions {
    public string question;
    public string yesAnswer;
    public string noAnswer;
    //public bool isYes;
    public int spendMoney;

}

public class CountriesList : MonoBehaviour {

    public Button country1;
    public Button country2;
    public Button country3;
    public Button country4;
    public Button country5;
    public Button country6;

    public GameObject objectC;
    public GameObject objectGm;

    public List<Country> countries;
 

    //private static List<Questions> unansweredQuestions;

    private Questions currentQuestion;

    [SerializeField]
    private float timeBetweenQuestions = 2f;

    [SerializeField]
    private Text questionText;

    [SerializeField]
    private Text buttonYes;
    [SerializeField]
    private Text buttonNo;
    private int currentCountry;
    void Start() {
        
        AddCountries();
        AddCountryName();

    }
    /// 
    /// Questions section
    /// 
    public void SetQuestion(Country item) {
        if (item.unansweredQuestions == null || item.unansweredQuestions.Count == 0) {
            item.unansweredQuestions = item.countryQuestion.ToList<Questions>();
        }
        SetCurrentQuestion(item);
    }
    void SetCurrentQuestion(Country item) {
        int randomQuestionIndex = Random.Range(0, item.unansweredQuestions.Count);
        currentQuestion = item.unansweredQuestions[randomQuestionIndex];

        questionText.text = currentQuestion.question;
        buttonYes.text = currentQuestion.yesAnswer;
        buttonNo.text = currentQuestion.noAnswer;
    }
    public void UserSelectYes() {
        if (currentCountry == 1){
            Country item = countries[0];
            item.relationship += 1;
        }else if(currentCountry == 2) {
            Country item = countries[1];
            item.relationship += 1;
        }else if(currentCountry == 3){
            Country item = countries[2];
            item.relationship += 1;
        }else if (currentCountry == 4) {
            Country item = countries[3];
            item.relationship += 1;
        } else if(currentCountry == 5){
            Country item = countries[4];
            item.relationship += 1;
        }else if (currentCountry == 6) {
            Country item = countries[5];
            item.relationship += 1;
        } 
            
            

        
        AddCountryName();
        int randomCountries = Random.Range(0, countries.Count);

        objectGm.GetComponent<GameManage1>().money += currentQuestion.spendMoney;
        objectGm.GetComponent<GameManage1>().SetPlayer();
        RemoveQuestion();
    }
    public void UserSelectNo() {
        
        if (currentCountry == 1){
            Country item = countries[0];
            item.relationship -= 1;
        }else if(currentCountry == 2) {
            Country item = countries[1];
            item.relationship -= 1;
        }else if(currentCountry == 3){
            Country item = countries[2];
            item.relationship -= 1;
        }else if (currentCountry == 4) {
            Country item = countries[3];
            item.relationship -= 1;
        } else if(currentCountry == 5){
            Country item = countries[4];
            item.relationship -= 1;
        }else if (currentCountry == 6) {
            Country item = countries[5];
            item.relationship -= 1;
        }
        AddCountryName();
        Debug.Log("relation --");

        objectGm.GetComponent<GameManage1>().SetPlayer();
        RemoveQuestion();
    }
    public void RemoveQuestion() {
        for (int i = 0; i < countries.Count; i++) {
            Country item = countries[i];
            item.unansweredQuestions.Remove(currentQuestion);
            if (item.unansweredQuestions == null || item.unansweredQuestions.Count == 0) {
                item.unansweredQuestions = item.countryQuestion.ToList<Questions>();
            }
        }
    }

    /// 
    /// Countries section
    /// 

    private void AddCountries() {

        country1.onClick.AddListener(delegate { TaskWithParameters1(countries[0]); });
        country2.onClick.AddListener(delegate { TaskWithParameters2(countries[1]); });
        country3.onClick.AddListener(delegate { TaskWithParameters3(countries[2]); });
        country4.onClick.AddListener(delegate { TaskWithParameters4(countries[3]); });
        country5.onClick.AddListener(delegate { TaskWithParameters5(countries[4]); });
        country6.onClick.AddListener(delegate { TaskWithParameters6(countries[5]); });


    }
    public void CountriesForcePlus(){
        for (int i = 0; i < countries.Count; i++) {
            Country item = countries[i];
            item.armyForce += item.forcePerStep;
        }
    }
    public void AddCountryName(){
        for (int i = 0; i < countries.Count;i++){
            Country item = countries[i];
            item.nameText.text = item.name;
            item.relationText.text = "Rel - " + item.relationship + "/10";
        }

    }


    void TaskWithParameters1(Country item) {
        currentCountry = 1;
        item = countries[0];

        SetQuestion(item);

        Countries strana = objectC.GetComponent<Countries>();
        strana.Setup(item);

    }
    void TaskWithParameters2(Country item) {
        currentCountry = 2;
        item = countries[1];

        SetQuestion(item);

        Countries strana = objectC.GetComponent<Countries>();
        strana.Setup(item);

    }
    void TaskWithParameters3(Country item) {
        currentCountry = 3;
        item = countries[2];
        SetQuestion(item);
        Countries strana = objectC.GetComponent<Countries>();
        strana.Setup(item);

    }
    void TaskWithParameters4(Country item) {
        currentCountry = 4;
        item = countries[3];
        SetQuestion(item);
        Countries strana = objectC.GetComponent<Countries>();
        strana.Setup(item);

    }
    void TaskWithParameters5(Country item) {
        currentCountry = 5;
        item = countries[4];
        SetQuestion(item);
        Countries strana = objectC.GetComponent<Countries>();
        strana.Setup(item);

    }
    void TaskWithParameters6(Country item) {
        currentCountry = 6;
        item = countries[5];
        SetQuestion(item);
        Countries strana = objectC.GetComponent<Countries>();
        strana.Setup(item);

    }

}
/*
 * Behaviors: Hostile(Враждебный), Aggrassive (Агрессивный) ,Kind(Добрый), Friendly(Дружеский)
 * FocusedOn: Army(Армия), Science(Наука), Ecology(Экология), People(Народ)
 * 
 * 
 * 
 */