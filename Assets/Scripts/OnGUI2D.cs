using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnGUI2D : MonoBehaviour
{
    public static OnGUI2D OG2D;
    public static int score;
    int highScore;

    Text scoreText;
    Text highText;



// Start is called before the first frame update
    void Start()
    {
        OG2D = this;
        score = 0;
        highScore = PlayerPrefs.GetInt("HighScore1", 0);

        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
        highText = GameObject.Find("HighText").GetComponent<Text>();


    }

    void Update()
    {
        scoreText.text = "Score:  " + (score * 15 );
        highText.text = "HighScore:  " + highScore;
    }

    void OnGUI()
    {
        //GUI.Label(new Rect(10,10,100,20),"Score: " +(score + 15));
        //GUI.Label(new Rect(10, 10, 5000, 5000), "HighScore: " + highScore);

    }

    public void CheckHighScore()
    {
        if((score *15) > highScore)
        {
            Debug.Log("Saving Score");

            PlayerPrefs.SetInt("HighScore1", (score * 15));
        }
    }


}
