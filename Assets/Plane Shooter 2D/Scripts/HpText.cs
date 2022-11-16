using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpText : MonoBehaviour
{

    public Text textElementScore;

    void Start()
    {

    }

    void Update()
    {
        textElementScore.text = GameManager.score.ToString();
    }
}
