﻿using UnityEngine;
using System.Collections;

public class GameSetup : MonoBehaviour {

    public Camera mainCam;
    public BoxCollider2D topWall;
    public BoxCollider2D bottomWall;
    public BoxCollider2D leftWall;
    public BoxCollider2D rightWall;

    public Transform Player1;
    public Transform Player2;
	
	// Update is called once per frame
    void Start()
    {
        topWall.size = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width * 2.0f, 0.0f, 0.0f)).x, 1.0f);
        topWall.center = new Vector2(0.0f, mainCam.ScreenToWorldPoint(new Vector3(0.0f, Screen.height, 0.0f)).y + 0.5f);

        bottomWall.size = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width * 2.0f, 0.0f, 0.0f)).x, 1.0f);
        bottomWall.center = new Vector2(0.0f, mainCam.ScreenToWorldPoint(new Vector3(0.0f, 0.0f, 0.0f)).y - 0.5f);

        leftWall.size = new Vector2(1.0f, mainCam.ScreenToWorldPoint(new Vector3(0.0f, Screen.height * 2.0f, 0.0f)).y);
        leftWall.center = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(0.0f, 0.0f, 0.0f)).x - 0.5f, 0.0f);

        rightWall.size = new Vector2(1.0f, mainCam.ScreenToWorldPoint(new Vector3(0.0f, Screen.height * 2.0f, 0.0f)).y);
        rightWall.center = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width, 0.0f, 0.0f)).x + 0.5f, 0.0f);

        Player1.position = new Vector3(mainCam.ScreenToWorldPoint(new Vector3(75.0f, 0.0f, 0.0f)).x, 0.0f, 0.0f);
        Player2.position = new Vector3(mainCam.ScreenToWorldPoint(new Vector3(Screen.width - 75.0f, 0.0f, 0.0f)).x, 0.0f, 0.0f);
    }
}
