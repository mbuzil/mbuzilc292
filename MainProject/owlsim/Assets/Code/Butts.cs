using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Butts : MonoBehaviour
{
    [SerializeField] Team t1;
    [SerializeField] Team t2;
    [SerializeField] GameObject cs;
    [SerializeField] GameObject standings;



    public void Press()
    {
        cs.GetComponent<Console>().test();
    }

    public void Press2()
    {
        cs.GetComponent<Console>().tourney();
    }

    public void Press3()
    {
        if(standings.activeSelf)
            standings.SetActive(false);
        else
            standings.SetActive(true);
    }

   
}
