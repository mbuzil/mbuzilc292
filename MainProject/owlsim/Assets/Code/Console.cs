using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class Console : MonoBehaviour
{
    [SerializeField] Team t1;
    [SerializeField] Team t2;
    [SerializeField] Team t3;
    [SerializeField] Team t4;
    public Team[] teams;
    public TextMeshProUGUI[] standingsText;
    int maps = 0;

    void Start()
    {
        teams = new Team[4];
        teams[0] = t1;
        teams[1] = t2;
        teams[2] = t3;
        teams[3] = t4;
    }

    public void tourney()
    {
        for (int i = 0; i < teams.Length; i++)
        {
            for (int j = i + 1; j < teams.Length; j++)
            {
                if (i == j)
                    continue;
                match(teams[i], teams[j]);
            }
        }
    }

    public void UpdateStandingsUI()
    {
        System.Array.Sort(teams, (a, b) =>
        {
            int winCompare = b.wins.CompareTo(a.wins);
            if (winCompare != 0)
                return winCompare;

            int mapWinCompare = b.mapwins.CompareTo(a.mapwins);
            if (mapWinCompare != 0)
                return mapWinCompare;

            return a.maploss.CompareTo(b.maploss);
        });

        for (int i = 0; i < standingsText.Length && i < teams.Length; i++)
        {
            Team t = teams[i];
            int rank = i + 1;
            standingsText[i].text = $"{rank}. {t.brand}: {t.wins}W ({t.mapwins}/{t.maploss})";
        }
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
        int mapWins1 = 0;
        int mapWins2 = 0;

        for (int map = 1; map <= 5; map++)
        {
            maps = map;
            int score1 = getTeamScore(o1);
            int score2 = getTeamScore(o2);

            if (score1 == score2)
            {
                score1 = tie(score1);
            }

        
            if (score1 > score2)
            {
                mapWins1++;
                o1.mapwins++;
                o2.maploss++;
                Debug.Log($"Map {map}: {o1.brand} wins ({score1}-{score2})");
            }
            else
            {
                mapWins2++;
                o2.mapwins++;
                o1.maploss++;
                Debug.Log($"Map {map}: {o2.brand} wins ({score2}-{score1})");
            }

            if (mapWins1 == 3 || mapWins2 == 3)
                break;
        }

    
        if (mapWins1 > mapWins2)
        {
            o1.wins++;
            Debug.Log($"{o1.brand} wins the series {mapWins1}-{mapWins2}");
        }
        else
        {
            o2.wins++;
            Debug.Log($"{o2.brand} wins the series {mapWins2}-{mapWins1}");
        }
        UpdateStandingsUI();
        foreach(Player p in o1.players)
        {
            p.ProcessMatchScores();
        }
        foreach(Player p in o2.players)
        {
            p.ProcessMatchScores();
        }
    }
   

    public int getScore(Player p, int currentMap)
    {
        float f;
        int f2;
        float s = p.getSkill();
        int r = UnityEngine.Random.Range(1, 101);
        int r2;
        if (s >= 70)
            r2 = UnityEngine.Random.Range(1, 21);
        else
            r2 = UnityEngine.Random.Range(1, 11);

        int randco;
        if (r <= 35)
            randco = UnityEngine.Random.Range(1, 11);
        else if (r <= 65)
            randco = UnityEngine.Random.Range(11, 21);
        else if (r <= 80)
            randco = UnityEngine.Random.Range(21, 31);
        else if (r <= 90)
            randco = UnityEngine.Random.Range(31, 41);
        else
            randco = UnityEngine.Random.Range(41, 51);

        if (r2 >= 6)
            f = s + s * (randco / 100f);
        else
            f = s - s * (randco / 100f);

        f2 = (int)f;

        
        switch (currentMap)
        {
            case 1:
                p.map1Score = f2;
                break;
            case 2:
                p.map2Score = f2;
                break;
            case 3:
                p.map3Score = f2;
                break;
            case 4:
                p.map4Score = f2;
                break;
            case 5:
                p.map5Score = f2;
                break;
            default:
                Debug.LogWarning("Invalid map number for scoring");
                break;
        }

        Debug.Log($"{p.ign} Map {currentMap}: {f2}");
        return f2;
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
        for (int i = 0; i < t.tanks.Length-1; i++)
        {
            tankScores[i] = getScore(t.tanks[i], maps);
        }

        int topIndex1 = -1, topIndex2 = -1;
        int topScore1 = int.MinValue, topScore2 = int.MinValue;

        for (int i = 0; i < tankScores.Length-1; i++)
        {
            if (tankScores[i] > topScore1)
            {
                topScore2 = topScore1;
                topIndex2 = topIndex1;

                topScore1 = tankScores[i];
                topIndex1 = i;
            }
            else if (tankScores[i] > topScore2)
            {
                topScore2 = tankScores[i];
                topIndex2 = i;
            }
        }

    for (int i = 0; i < t.tanks.Length-1; i++)
    {
        if (i != topIndex1 && i != topIndex2)
        {
            switch (maps)
            {
                case 1: t.tanks[i].map1Score = 0; break;
                case 2: t.tanks[i].map2Score = 0; break;
                case 3: t.tanks[i].map3Score = 0; break;
                case 4: t.tanks[i].map4Score = 0; break;
                case 5: t.tanks[i].map5Score = 0; break;
            }
        }
    }

    return topScore1 + topScore2;
}

    public int getDPSScore(Team t)
    {
        int[] dpsScores = new int[t.dps.Length];
        for (int i = 0; i < t.dps.Length-1; i++)
        {
            dpsScores[i] = getScore(t.dps[i], maps);
        }

        int topIndex1 = -1, topIndex2 = -1;
        int topScore1 = int.MinValue, topScore2 = int.MinValue;

        for (int i = 0; i < dpsScores.Length-1; i++)
        {
            if (dpsScores[i] > topScore1)
            {
                topScore2 = topScore1;
                topIndex2 = topIndex1;

                topScore1 = dpsScores[i];
                topIndex1 = i;
            }
            else if (dpsScores[i] > topScore2)
            {
                topScore2 = dpsScores[i];
                topIndex2 = i;
            }
        }

        for (int i = 0; i < t.dps.Length-1; i++)
        {
            if (i != topIndex1 && i != topIndex2)
            {
                switch (maps)
                {
                    case 1: t.dps[i].map1Score = 0; break;
                    case 2: t.dps[i].map2Score = 0; break;
                    case 3: t.dps[i].map3Score = 0; break;
                    case 4: t.dps[i].map4Score = 0; break;
                    case 5: t.dps[i].map5Score = 0; break;
                }
            }
        }

        return topScore1 + topScore2;
    }
    
    public int getSupportScore(Team t)
    {
       int[] supportScores = new int[t.supports.Length];
        for (int i = 0; i < t.supports.Length-1; i++)
        {
            supportScores[i] = getScore(t.supports[i], maps);
        }

        int topIndex1 = -1, topIndex2 = -1;
        int topScore1 = int.MinValue, topScore2 = int.MinValue;

        for (int i = 0; i < supportScores.Length-1; i++)
        {
            if (supportScores[i] > topScore1)
            {
                topScore2 = topScore1;
                topIndex2 = topIndex1;

                topScore1 = supportScores[i];
                topIndex1 = i;
            }
            else if (supportScores[i] > topScore2)
            {
                topScore2 = supportScores[i];
                topIndex2 = i;
            }
        }

        for (int i = 0; i < t.supports.Length-1; i++)
        {
            if (i != topIndex1 && i != topIndex2)
            {
                switch (maps)
                {
                    case 1: t.supports[i].map1Score = 0; break;
                    case 2: t.supports[i].map2Score = 0; break;
                    case 3: t.supports[i].map3Score = 0; break;
                    case 4: t.supports[i].map4Score = 0; break;
                    case 5: t.supports[i].map5Score = 0; break;
                }
            }
        }

        return topScore1 + topScore2;
    }
}
