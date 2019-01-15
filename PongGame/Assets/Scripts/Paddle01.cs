using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle01 : MonoBehaviour {

    [SerializeField]

    float speed;
    float height;

    string input;
   public bool isRight;

	// Use this for initialization
	void Start () {
        StartRules();
	}

    void StartRules()
    {
        height = transform.localScale.y;
        speed = 5.0f;
    }

    public void Init(bool isRightPaddle)
    {
        isRight = isRightPaddle;

        Vector2 pos = Vector2.zero;

        if (isRightPaddle){
            //Place paddle on the right side
            pos =new Vector2 (GameManager.topRight.x, 0);
            pos -= Vector2.right * transform.localScale.x;// Move a bit to the left

            input = "PaddleRight";
        }
        else {
            //Place paddle on the left side
            pos = new Vector2(GameManager.bottomLeft.x, 0);
            pos += Vector2.right * transform.localScale.x; // Move a bit to the right

            input = "PaddleLeft";
        }

        transform.position = pos;
           
    }

    // Update is called once per frame
    void Update () {
        PlayerMovement();
	}

    void PlayerMovement (){
        float move = Input.GetAxis(input) * Time.deltaTime * speed;

        //Restrict paddle movement
        if (transform.position.y < GameManager.bottomLeft.y + height / 2 && move < 0) {
            move = 0;
        }

        if (transform.position.y > GameManager.topRight.y - height / 2 && move > 0){
            move = 0;
        }

        transform.Translate(move * Vector2.up);
    }

  
}
