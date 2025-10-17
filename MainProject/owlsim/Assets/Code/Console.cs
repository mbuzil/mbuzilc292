using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Console : MonoBehaviour
{
    [SerializeField] Team t1;
    [SerializeField] Team t2;
    public Team[] teams;

    void Start()
    {
        teams = new Team[2];
        teams[0] = t1;
        teams[1] = t2;
    }

    public void test()
    {
        match(t1,t2);
    }

    public int tie(int s1)
    {
        int r = UnityEngine.Random.Range(1,3);
        if(r < 2)
            return s1+1;
        else
        return s1-1;
    }

    public void match(Team o1, Team o2)
    {
        int score1 = getTeamScore(o1);
        int score2 = getTeamScore(o2);
        if(score1 == score2)
        {
            score1 = tie(score1);
        }
        if(score1 > score2)
        {
            Debug.Log(o1.brand + " has won");
        }
        else
        {
            Debug.Log(o2.brand + " has won");
        }
        Debug.Log(o1.brand + ": " + score1);
        Debug.Log(o2.brand + ": " + score2);
    }

   

    public int getScore(Player p)
    {
        float f;
        int f2;
        int s = p.getSkill();
        int r = UnityEngine.Random.Range(1,101);
        int r2;
        if(s >= 70)
            r2 = UnityEngine.Random.Range(1,21);
        else
            r2 = UnityEngine.Random.Range(1,11);
        int randco;
        if(r <= 35)
            randco = UnityEngine.Random.Range(1,11);
        else if(r <= 65)
            randco = UnityEngine.Random.Range(11,21);
        else if(r <= 80)
            randco = UnityEngine.Random.Range(21,31);
        else if(r <= 90)
            randco = UnityEngine.Random.Range(31,41);
        else
            randco = UnityEngine.Random.Range(41,51);
        if(r2 >= 6)
            f = s+s*(randco/100f);
        else
            f = s-s*(randco/100f);
        f2 = (int)f;
        Debug.Log(p.ign + ": " + f2);
        return(f2);
    }

    public int getTeamScore(Team t)
    {
        t.fillRoles();
        int score = 0;
        score += getTankScore(t);
        score += getDPSScore(t);
        score += getSupportScore(t);
        return score;
    }

    public int getTankScore(Team t)
    {
        int[] tankScores = new int[t.tanks.Length];
        int tankScore = 0;
        for(int i = 0; i < t.tanks.Length-1; i++)
        {
            tankScores[i] = getScore(t.tanks[i]);
        }
        Array.Sort(tankScores);
        Array.Reverse(tankScores);
        tankScore = tankScores[0]+tankScores[1];
        return(tankScore);
    }

    public int getDPSScore(Team t)
    {
        int[] dpsScores = new int[t.dps.Length];
        int dpsScore = 0;
        for(int i = 0; i < t.dps.Length-1; i++)
        {
            dpsScores[i] = getScore(t.dps[i]);
        }
        Array.Sort(dpsScores);
        Array.Reverse(dpsScores);
        dpsScore = dpsScores[0]+dpsScores[1];
        return(dpsScore);
    }

    public int getSupportScore(Team t)
    {
        int[] supportScores = new int[t.supports.Length];
        int supportScore = 0;
        for(int i = 0; i < t.supports.Length-1; i++)
        {
            supportScores[i] = getScore(t.supports[i]);
        }
        Array.Sort(supportScores);
        Array.Reverse(supportScores);
        supportScore = supportScores[0]+supportScores[1];
        return(supportScore);
    }
}
