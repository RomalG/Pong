using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Count_Score : MonoBehaviour
{
    public Text Scoreboard;
    public GameObject ball;
    private int Bat_1_Score = 0;
    private int Bat_2_Score = 0;
    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("Ball");
    }

    // Update is called once per frame
    void Update()
    {
        if (ball.transform.position.x >= 23f)
        {
            Bat_1_Score ++;
        }
        if (ball.transform.position.x <= -23f)
        {
            Bat_2_Score ++;
        }
        Scoreboard.text = Bat_1_Score.ToString() + " - " + Bat_2_Score.ToString();
        print(Bat_1_Score + " , " + Bat_2_Score);
    }
}
