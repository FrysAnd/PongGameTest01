using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public Ball01 ball;
    public Paddle01 paddle;
    public Score01 score;

    public static Vector2 bottomLeft;
    public static Vector2 topRight;

	// Use this for initialization
	void Start () {
        InstantianteStart();
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    void InstantianteStart (){

        Score01 score1 = Instantiate(score) as Score01;

        bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
        topRight = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

        InstantiateBall();
      

        Paddle01 paddle1 = Instantiate (paddle) as Paddle01;
        Paddle01 paddle2 = Instantiate(paddle) as Paddle01;

        paddle1.Init(true); //Right Paddle
        paddle2.Init(false);//Left Paddle
    }
   public void InstantiateBall(){
        Instantiate(ball, transform.position, transform.rotation);
    }
}
