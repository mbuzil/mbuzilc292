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
    public float effectiveSkill;

    public float getSkill()
    {
        float fskill = (float)skill;
        return fskill+effectiveSkill;
    }

    public string getRole()
    {
        return role;
    }

    public void ProcessMatchScores()
    {
        int mapTotal = map1Score + map2Score + map3Score + map4Score + map5Score;

        seasonScore += mapTotal;

        int mapsPlayed = 0;
        if (map1Score > 0) mapsPlayed++;
        if (map2Score > 0) mapsPlayed++;
        if (map3Score > 0) mapsPlayed++;
        if (map4Score > 0) mapsPlayed++;
        if (map5Score > 0) mapsPlayed++;

        if (mapsPlayed > 0)
        {
            float avgMapScore = (float)mapTotal / mapsPlayed;

            if (avgMapScore > effectiveSkill+skill)
            {
                effectiveSkill += 0.1f;
            }
            else
            {
                effectiveSkill -= 0.1f;
            }
        }

        map1Score = 0;
        map2Score = 0;
        map3Score = 0;
        map4Score = 0;
        map5Score = 0;
    }
}
