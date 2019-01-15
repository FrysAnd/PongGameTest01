using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score01 : MonoBehaviour {

    public static int scoreP1;
    public static int scoreP2;

    public Text P1Score;
    public Text P2Score;

	// Use this for initialization
	void Start () {
        StartScore();
	}
	
	// Update is called once per frame
	void Update () {
        SetScoreText();
	}

    void StartScore (){
        scoreP1 = 0;
        scoreP2 = 0;
    }

    void SetScoreText(){
        P1Score.text = ("P1: ") + scoreP1.ToString();
        P2Score.text = ("P2: ") + scoreP2.ToString();
    }
}
