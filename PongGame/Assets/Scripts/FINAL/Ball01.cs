using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball01 : MonoBehaviour {

   

    [SerializeField]
    public static float speed;

    float radius;
    Vector2 direction;


	// Use this for initiali    zation
	void Start () {
        OnStartUp();
	}
	
	// Update is called once per frame
	public void Update () {
        Movement();
	}
   public void OnStartUp(){
      
        direction = Vector2.one.normalized; // direction is (1,1) normalized
        radius = transform.localScale.x / 2; // half the width
    }

    public void Movement(){
        transform.Translate(direction * speed * Time.deltaTime);

        speed = speed + 0.01f;

        if (transform.position.y < GameManager.bottomLeft.y + radius && direction.y < 0) {
            direction.y = -direction.y;
        }
        if (transform.position.y > GameManager.topRight.y - radius && direction.y > 0){
            direction.y = -direction.y; // Mattias åk2.
        }

        // Game over
        if (transform.position.x < GameManager.bottomLeft.x + radius && direction.x < 0){
            //Right Player Wins!
            Score01.scoreP2 += 1;

            transform.position = new Vector2(0, 0);
            speed = 4;

        }
        if (transform.position.x > GameManager.topRight.x - radius && direction.x > 0){
            //"Left Player Wins!
            Score01.scoreP1 += 1;
            transform.position = new Vector2(0, 0);
            speed = 4;
          
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Paddle") {
            bool isRight = other.GetComponent<Paddle01>().isRight;

            if (isRight == true && direction.x > 0) {
                direction.x = -direction.x;

            }
            if (isRight == false && direction.x < 0) {
                direction.x = -direction.x;

            }
        }
    }
} // Mattias klar men felmeddelanden
