using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    float RandomNumber = Random.Range(0, 2);
        if (RandomNumber <= 2.0f)
        { 
            rigidbody2D.AddForce(new Vector2(-10.0f, 10.0f));
        }
	}
	
	// Update is called once per frame
    void OnCollisionEnter2D(Collision2D colInfo)
    {
        if ((colInfo.collider.tag == "pongpaddle1") || (colInfo.collider.tag == "pongpaddle2"))
        {
            float velY = rigidbody2D.velocity.y;
            velY = velY / 2.0f + colInfo.collider.rigidbody2D.velocity.y / 3.0f;
            float velX = rigidbody2D.velocity.x;
            rigidbody2D.velocity = new Vector2(velX, velY);
        }
    }
}
