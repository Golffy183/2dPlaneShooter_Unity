using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealItem : MonoBehaviour
{
    public GameObject Heal;
    public Health health;
    private Rigidbody2D rb;
    public GameObject Audio;
    // Start is called before the first frame update
    void Start()
    {
        Heal = GameObject.Find("Player");
        health = Heal.GetComponent<Health>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = -transform.up * 5f;
    }
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log("collision name = " + hitInfo.gameObject.name);
        if (hitInfo.gameObject.name == "Player")
        {
            Instantiate(Audio, transform.position, transform.rotation);
            if (health.currentHealth < 5)
            {
                health.currentHealth += 1;
            }
            Destroy(gameObject);
        }
    }
}
