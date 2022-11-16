using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalText : MonoBehaviour
{
    public Text ScoreText;

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Total Score: " + TotalScore.totalScore;
    }
}

