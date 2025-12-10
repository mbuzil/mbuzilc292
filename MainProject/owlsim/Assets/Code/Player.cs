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
    public int age;

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
                if(effectiveSkill+skill < 120)
                    effectiveSkill += 0.1f;
                if(effectiveSkill+skill < 110)
                    effectiveSkill += 0.1f;
                if(effectiveSkill+skill < 105)
                    effectiveSkill += 0.1f;
                if(effectiveSkill+skill < 100)
                    effectiveSkill += 0.1f;
                if(effectiveSkill+skill < 95)
                    effectiveSkill += 0.1f;
                if(effectiveSkill+skill < 90)
                    effectiveSkill += 0.1f;
                if(effectiveSkill+skill < 85)
                    effectiveSkill += 0.1f;
                if(effectiveSkill+skill < 80)
                    effectiveSkill += 0.1f;
                if(effectiveSkill+skill < 75)
                    effectiveSkill += 0.1f;
            }
            else
            {
                effectiveSkill -= 0.1f;
                if(age >= 1)
                    effectiveSkill -= 0.2f;
                if(age >= 2)
                    effectiveSkill -= 0.3f;
                if(age >= 3)
                    effectiveSkill -= 0.4f;
                if(age >= 4)
                    effectiveSkill -= 0.5f;
                if(age >= 5)
                    effectiveSkill -= 0.6f;
                if(age >= 6)
                    effectiveSkill -= 0.7f;
                if(age >= 7)
                    effectiveSkill -= 0.8f;
                if(age >= 8)
                    effectiveSkill -= 1f;
            }
            if(age >= 4)
                effectiveSkill -= 0.2f;
            if(age >= 5)
                effectiveSkill -= 0.2f;
            if(age >= 6)
                effectiveSkill -= 0.2f;
            if(age >= 7)
                effectiveSkill -= 0.2f;
            if(age >= 8)
                effectiveSkill -= 0.2f;
        }

        map1Score = 0;
        map2Score = 0;
        map3Score = 0;
        map4Score = 0;
        map5Score = 0;
    }
}
