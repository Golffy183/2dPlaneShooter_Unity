using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RestartGame : MonoBehaviour
{
    private GameObject Player;
    private Health health;
    public GameObject Fail;
    public RectTransform TransformMove;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        health = Player.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        if (health == null)
        {
            Fail.transform.position = new Vector3(0f, 3.7f, -4f);
            TransformMove.localPosition = new Vector3(0f, -130f, -4f);
        }
    }
}
