using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, speed, 0) * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            gameManager.instance.InstantiateGameOver();
        }
        else if(collision.gameObject.tag == "Laser" || collision.gameObject.tag == "BigLaser")
        {
            gameManager.instance.IncreaseScore(10);
        }
        Destroy(gameObject);
        if(collision.gameObject.tag != "BigLaser")
            Destroy(collision.gameObject);
    }
}
