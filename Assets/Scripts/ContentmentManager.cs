
using UnityEngine;
using UnityEngine.UI;
public class ContentmentManager : MonoBehaviour {
    
    [SerializeField]
    private Text EcologyCont;
    [SerializeField]
    private Text PeopleCont;
    [SerializeField]
    private Text ArmyCont;
    [SerializeField]
    private Text ScienceCont;

    public int ecologyCount = 8;
    public int peopleCount = 8;
    public int armyCount = 8;
    public int scienceCount = 8;
    public void Start() {
        //SetContentments();

    }
    public void Update() {
        SetContentments();

    }
    void SetContentments(){
        EcologyCont.text = ecologyCount + "/20";
        PeopleCont.text = peopleCount + "/20";
        ArmyCont.text = armyCount + "/20";
        ScienceCont.text = scienceCount + "/20";
    }
}
