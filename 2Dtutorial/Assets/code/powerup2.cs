using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup2 : MonoBehaviour
{
    [SerializeField] float speed;
    GameObject p;

    void Start()
    {
        p = GameObject.Find("Player");
    }

    void Update()
    {
        transform.position -= new Vector3(0, speed, 0) * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player" || collision.gameObject.tag == "Laser")
        {
            p.GetComponent<player>().power2();
        }
        Destroy(gameObject);
    }
}
