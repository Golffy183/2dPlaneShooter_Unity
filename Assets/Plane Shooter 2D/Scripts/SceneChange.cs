using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    private Health health;
    void Start()
    {
        health = GetComponent<Health>();
    }
    void Update()
    {
        if (health.currentHealth <= 0)
        {
            SceneManager.LoadScene("StartScene");
        }
    }
}
