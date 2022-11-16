using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPlayer : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 0.1f;
    private GameObject Player;
    Vector3 TempTranform;

    bool addForce = false;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        TempTranform = Player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (TempTranform != transform.position && addForce == false)
        {
            rb.velocity = (TempTranform - transform.position).normalized * speed;
            addForce = true;
        }
        else
        {
            rb.AddForce(transform.forward);
        }
    }
}
