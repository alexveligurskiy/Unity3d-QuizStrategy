using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndStepManager : MonoBehaviour {

    [SerializeField]
    private Text ForcePerStepText;
    [SerializeField]
    private Text ForceText;
    [SerializeField]
    private Text EarningsPerStepText;
    [SerializeField]
    private Text Ecology;
    [SerializeField]
    private Text People;
    [SerializeField]
    private Text Army;
    [SerializeField]
    private Text Science;
    [SerializeField]
    private Text Enemy1;
    [SerializeField]
    private Text Enemy2;
    [SerializeField]
    private Text Enemy3;
    [SerializeField]
    private Text Enemy4;
    [SerializeField]
    private Text Enemy5;
    [SerializeField]
    private Text Enemy6;
    [SerializeField]
    private Text Enemy7;

    public void EndStepButtonPressed(){

        //Destroy finds and make through addding a gameobject
        ForcePerStepText.text = "Army Force: " + GameObject.Find("GameManager").GetComponent<GameManage1>().forcePerStep + "/step.";
        ForceText.text = "Total Army Force: " + GameObject.Find("GameManager").GetComponent<GameManage1>().force;
        EarningsPerStepText.text = "Earnings: " + GameObject.Find("GameManager").GetComponent<GameManage1>().earningsPerStep + "/step.";

        Ecology.text = GameObject.Find("ContentmentManager").GetComponent<ContentmentManager>().ecologyCount + "/20";
        People.text = GameObject.Find("ContentmentManager").GetComponent<ContentmentManager>().peopleCount + "/20";
        Army.text = GameObject.Find("ContentmentManager").GetComponent<ContentmentManager>().armyCount + "/20";
        Science.text = GameObject.Find("ContentmentManager").GetComponent<ContentmentManager>().scienceCount + "/20";


        //Here should be enemies also!




    }
}
