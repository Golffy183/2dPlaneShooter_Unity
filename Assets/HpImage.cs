using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpImage : MonoBehaviour
{
    Image timerBar;
    [HideInInspector]
    public float maxHP;
    [HideInInspector]
    public float HpLeft;
    public Health health;
    // Start is called before the first frame update
    void Start()
    {
        timerBar = GetComponent<Image>();
        maxHP = health.maximumHealth;
        HpLeft = maxHP;
    }

    // Update is called once per frame
    void Update()
    {
        if (HpLeft > 0)
        {
            HpLeft = health.currentHealth;
            timerBar.fillAmount = HpLeft / maxHP;
        }
    }
}
