using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fielder : Player
{
    public Fielder()
    {
        ign = "Fielder";
        skill = 99;
        map1Score = 0;
        map2Score = 0;
        map3Score = 0;
        map4Score = 0;
        map5Score = 0;
        seasonScore = 0;
        role = "Support";
        effectiveSkill = 0;
    }
}
