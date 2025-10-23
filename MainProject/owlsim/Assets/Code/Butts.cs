using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Butts : MonoBehaviour
{
    [SerializeField] Team t1;
    [SerializeField] Team t2;
    [SerializeField] GameObject cs;

    public void Press()
    {
        cs.GetComponent<Console>().test();
    }

    public void Press2()
    {
        cs.GetComponent<Console>().tourney();
    }
}
