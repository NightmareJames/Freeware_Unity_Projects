﻿using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour {

    public KeyCode moveUp;
    public KeyCode moveDown;
    public float speed = 10;

	// Update is called once per frame
	void Update () {
        if (Input.GetKey(moveUp))
        {
            rigidbody2D.velocity = new Vector2(0, speed);
        }
        else if (Input.GetKey(moveDown))
        {
            rigidbody2D.velocity = new Vector2(0, (speed * -1));
        }
        else
        {
            rigidbody2D.velocity = new Vector2(0, 0);
        }

        float a_speed = rigidbody2D.velocity.y;
        rigidbody2D.velocity = new Vector2(0, a_speed);
    }
}
