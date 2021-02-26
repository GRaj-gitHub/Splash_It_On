using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    //Canvas for Display 1

    [SerializeField]
    private GameObject p1RemainingLives;
    [SerializeField]
    private GameObject p2RemainingLives;

    public GameObject timer;


    [SerializeField]
    private GameObject paintMeterP2;

    [SerializeField]
    private GameObject paintMeterP1;


    //Canvas for Display 2

    [SerializeField]
    private GameObject p1RemainingLives_disp2;
    [SerializeField]
    private GameObject p2RemainingLives_disp2;

    public GameObject timer_disp2;


    [SerializeField]
    private GameObject paintMeterP2_disp2;

    [SerializeField]
    private GameObject paintMeterP1_disp2;
    void Update()
    {
        
        timer.GetComponent<Text>().text = Timer.timeremaining + "";
        
        timer_disp2.GetComponent<Text>().text = Timer.timeremaining + "";

        paintMeterP1.GetComponent<Text>().text = playermovement.p1Meter + "" + "%";
        paintMeterP2.GetComponent<Text>().text = playermovement.p2Meter + "" + "%";
       
        paintMeterP1_disp2.GetComponent<Text>().text = playermovement.p1Meter + "" + "%";
        paintMeterP2_disp2.GetComponent<Text>().text = playermovement.p2Meter + "" + "%";

        p1RemainingLives.GetComponent<Text>().text = GamePlay.p1Life + "";
        p2RemainingLives.GetComponent<Text>().text = GamePlay.p2Life + "";

        p1RemainingLives_disp2.GetComponent<Text>().text = GamePlay.p1Life + "";
        p2RemainingLives_disp2.GetComponent<Text>().text = GamePlay.p2Life + "";
    }
}
