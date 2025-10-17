using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string ign;
    public int skill;
    public int map1Score;
    public int map2Score;
    public int map3Score;
    public int map4Score;
    public int map5Score;
    public int seasonScore;
    public string role;

    public int getSkill()
    {
        return skill;
    }

    public string getRole()
    {
        return role;
    }
}
