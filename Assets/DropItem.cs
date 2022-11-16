using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropItem : MonoBehaviour
{
    public GameObject ItemDrop;
    [HideInInspector]
    public int RandomItem;
    private Health health;
    // Start is called before the first frame update
    void Start()
    {
        health = GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        if (health.currentHealth <= 0)
        {
            RandomItem = Random.Range(0, 100);
            Destroy(this.gameObject);
        }
        if (RandomItem >= 1 && RandomItem < 90)
        {
            Instantiate(ItemDrop, transform.position, ItemDrop.transform.rotation);
            RandomItem = 99;
        }
    }
}
