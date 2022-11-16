using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotalScore : MonoBehaviour
{
    public static string totalScore;

    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        totalScore = GameManager.score.ToString();
        Debug.Log(totalScore);
    }
}
