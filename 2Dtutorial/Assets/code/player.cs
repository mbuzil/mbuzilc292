using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField] GameObject laser;
    [SerializeField] GameObject bigLaser;

    public float pow1time;
    public float pow2time;
    public bool timer1 = false;
    public bool timer2 = false;

    public float yPosition;

    public float shoottime = 0.5f;
    public float shoottimespeed;
    public bool shoottimer = false;

    // Start is called before the first frame update
    void Start()
    {
        yPosition = transform.position.y;
        shoottimespeed = 0.5f;
        pow2time = 2.5f;
        pow1time = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 convertedPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(convertedPosition.x, yPosition, 0);

        if(Input.GetButtonDown("Fire1") && !shoottimer)
        {
            shoottimer = true;
            Instantiate(laser, transform.position, Quaternion.identity);
        }

        if(timer1)
        {
            if(pow1time > 0)
            {
                shoottimespeed = 0.01f;
                pow1time -= Time.deltaTime;
            }
            else
            {
                timer1 = false;
                pow1time = 5f;
                shoottimespeed = 0.5f;
            }
        }

        if(timer2)
        {
            if(pow2time > 0)
                pow2time -= Time.deltaTime;
            else
            {
                timer2 = false;
                pow2time = 2.5f;
                bigLaser.SetActive(false);
            }
        }

        if(shoottimer)
        {
            if(shoottime >= 0)
                shoottime -= Time.deltaTime;
            else
            {
                shoottimer = false;
                shoottime = shoottimespeed;
            }
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            power2();
        }


    }

    public void power1()
    {
        shoottimespeed = 0.01f;
        timer1 = true;

    }

    public void power2()
    {
        timer2 = true;
        bigLaser.SetActive(true);
    }
}
