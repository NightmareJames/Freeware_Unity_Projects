using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    static int Player1Score = 0;
    static int Player2Score = 0;
	// Use this for initialization

    public GUISkin theSkin;

    void Start () {
	}
	
	// Update is called once per frame
	public static void Score (string wallName) {
        if (wallName == "rightWall")
        {
            Player2Score += 1;
        }
        else if (wallName == "leftWall")
        {
            Player1Score += 1;
        }
        Debug.Log("Player 1 Score = " + Player1Score);
        Debug.Log("Player 2 Score = " + Player2Score);
	}

    void OnGUI()
    {
        GUI.skin = theSkin;
        GUI.Label(new Rect(Screen.width / 2 - 150.0f, 20.0f, 100.0f, 100.0f), "" + Player1Score);
        GUI.Label(new Rect(Screen.width / 2 + 150.0f, 20.0f, 100.0f, 100.0f), "" + Player2Score);
    }
    

}
