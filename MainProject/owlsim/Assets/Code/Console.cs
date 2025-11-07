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
    [SerializeField] TextMeshProUGUI seasonNumber;
    public Team[] teams;
    public Team[] teamsCopy;
    public Team[] teamsCopy2;
    public Team[] teamsCopy3;
    public TextMeshProUGUI[] standingsText;
    public TextMeshProUGUI[] standingsTempText;
    int maps = 0;
    int sNumber = 0;
    [SerializeField] TextMeshProUGUI winner;
    [SerializeField] TextMeshProUGUI runnerUp;
    string firstP;
    string secondP;
    string firstP2;
    string secondP2;
    string firstP3;
    string secondP3;
    public bool postSeason;
    public String winnerT;

    void Start()
    {
        teams = new Team[4];
        teams[0] = t1;
        teams[1] = t2;
        teams[2] = t3;
        teams[3] = t4;
        teamsCopy = new Team[4];
        teamsCopy[0] = t1;
        teamsCopy[1] = t2;
        teamsCopy[2] = t3;
        teamsCopy[3] = t4;
        teamsCopy2 = new Team[4];
        teamsCopy2[0] = t1;
        teamsCopy2[1] = t2;
        teamsCopy2[2] = t3;
        teamsCopy2[3] = t4;
        teamsCopy3 = new Team[4];
        teamsCopy3[0] = t1;
        teamsCopy3[1] = t2;
        teamsCopy3[2] = t3;
        teamsCopy3[3] = t4;
        firstP = "";
        secondP = "";
        firstP2 = "";
        secondP2 = "";
        firstP3 = "";
        secondP3 = "";
        seasonNumber.text = "Season: " + sNumber;
        postSeason = false;
        winnerT = "";
        standingsTempText = standingsText;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            for (int i = 0; i < standingsText.Length && i < teamsCopy.Length; i++)
            {
                Team t = teamsCopy[i];
                int rank = i + 1;
                standingsText[i].text = $"{rank}. {t.brand}: {t.wins}W ({t.mapwins}/{t.maploss})";
            }
            winner.text = "Champions: " + firstP;
            runnerUp.text = "Runner Ups: " + secondP;
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            for (int i = 0; i < standingsText.Length && i < teamsCopy2.Length; i++)
            {
                Team t = teamsCopy2[i];
                int rank = i + 1;
                standingsText[i].text = $"{rank}. {t.brand}: {t.wins2}W ({t.mapwins2}/{t.maploss2})";
            }
            winner.text = "Champions: " + firstP2;
            runnerUp.text = "Runner Ups: " + secondP2;
        }
        else if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            for (int i = 0; i < standingsText.Length && i < teamsCopy3.Length; i++)
            {
                Team t = teamsCopy3[i];
                int rank = i + 1;
                standingsText[i].text = $"{rank}. {t.brand}: {t.wins3}W ({t.mapwins3}/{t.maploss3})";
            }
            winner.text = "Champions: " + firstP3;
            runnerUp.text = "Runner Ups: " + secondP3;
        }
    }

    public void tourney()
    {   
        sNumber++;
        for (int i = 0; i < teams.Length; i++)
        {
            for (int j = i + 1; j < teams.Length; j++)
            {
                if (i == j)
                    continue;
                match(teams[i], teams[j]);
            }
        }
        postSeason = true;
        bracket();
        
        seasonNumber.text = "Season: " + sNumber;
    }

    public void UpdateStandingsUI()
    {
        
        if(sNumber == 1)
        {
            System.Array.Sort(teamsCopy, (a, b) =>
            {
                int winCompare = b.wins.CompareTo(a.wins);
                if (winCompare != 0)
                    return winCompare;

                int mapWinCompare = b.mapwins.CompareTo(a.mapwins);
                if (mapWinCompare != 0)
                    return mapWinCompare;

                return a.maploss.CompareTo(b.maploss);
            });
            for (int i = 0; i < standingsText.Length && i < teamsCopy.Length; i++)
            {
                Team t = teamsCopy[i];
                int rank = i + 1;
                standingsText[i].text = $"{rank}. {t.brand}: {t.wins}W ({t.mapwins}/{t.maploss})";
            }
        }
        else if(sNumber == 2)
        {
            System.Array.Sort(teamsCopy2, (a, b) =>
            {
                int winCompare = b.wins2.CompareTo(a.wins2);
                if (winCompare != 0)
                    return winCompare;

                int mapWinCompare = b.mapwins2.CompareTo(a.mapwins2);
                if (mapWinCompare != 0)
                    return mapWinCompare;

                return a.maploss2.CompareTo(b.maploss2);
            });
            for (int i = 0; i < standingsText.Length && i < teamsCopy2.Length; i++)
            {
                Team t = teamsCopy2[i];
                int rank = i + 1;
                standingsText[i].text = $"{rank}. {t.brand}: {t.wins2}W ({t.mapwins2}/{t.maploss2})";
            }
        }
        else if(sNumber == 3)
        {
            System.Array.Sort(teamsCopy3, (a, b) =>
            {
                int winCompare = b.wins3.CompareTo(a.wins3);
                if (winCompare != 0)
                    return winCompare;

                int mapWinCompare = b.mapwins3.CompareTo(a.mapwins3);
                if (mapWinCompare != 0)
                    return mapWinCompare;

                return a.maploss3.CompareTo(b.maploss3);
            });
            for (int i = 0; i < standingsText.Length && i < teamsCopy3.Length; i++)
            {
                Team t = teamsCopy3[i];
                int rank = i + 1;
                standingsText[i].text = $"{rank}. {t.brand}: {t.wins3}W ({t.mapwins3}/{t.maploss3})";
            }
        }
    }

    public void bracket()
    {
        if(sNumber == 1)
        {
            Team t1 = match(teamsCopy[0],teamsCopy[3]);
            Team t2 = match(teamsCopy[1],teamsCopy[2]);
            winnerT = match(t1,t2).brand;
            Debug.Log(winnerT);
            firstP = winnerT;
            if(winnerT == t1.brand)
                secondP = t2.brand;
            else
                secondP = t1.brand;

            winner.text = "Champions: " + firstP;
            runnerUp.text = "Runner Ups: " + secondP;
            postSeason = false;
        }
        else if(sNumber == 2)
        {
            Team t1 = match(teamsCopy2[0],teamsCopy2[3]);
            Team t2 = match(teamsCopy2[1],teamsCopy2[2]);
            winnerT = match(t1,t2).brand;
            Debug.Log(winnerT);
            firstP2 = winnerT;
            if(winnerT == t1.brand)
                secondP2 = t2.brand;
            else
                secondP2 = t1.brand;

            winner.text = "Champions: " + firstP;
            runnerUp.text = "Runner Ups: " + secondP2;
            postSeason = false;
        }
        else if(sNumber == 3)
        {
            Team t1 = match(teamsCopy3[0],teamsCopy3[3]);
            Team t2 = match(teamsCopy3[1],teamsCopy3[2]);
            winnerT = match(t1,t2).brand;
            Debug.Log(winnerT);
            firstP3 = winnerT;
            if(winnerT == t1.brand)
                secondP3 = t2.brand;
            else
                secondP3 = t1.brand;

            winner.text = "Champions: " + firstP3;
            runnerUp.text = "Runner Ups: " + secondP3;
            postSeason = false;
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

    public Team match(Team o1, Team o2)
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
                if(sNumber == 1)
                {
                    mapWins1++;
                    if(!postSeason){
                        o1.mapwins++;
                        o2.maploss++;
                    }
                }
                else if(sNumber == 2)
                {
                    mapWins1++;
                    if(!postSeason){
                        o1.mapwins2++;
                        o2.maploss2++;
                    }
                }
                else if(sNumber == 3)
                {
                    mapWins1++;
                    if(!postSeason){
                        o1.mapwins3++;
                        o2.maploss3++;
                    }
                }
                Debug.Log($"Map {map}: {o1.brand} wins ({score1}-{score2})");
            }
            else
            {
                if(sNumber == 1)
                {
                    mapWins2++;
                    if(!postSeason){
                        o2.mapwins++;
                        o1.maploss++;
                    }
                }
                else if(sNumber == 2)
                {
                    mapWins2++;
                    if(!postSeason){
                        o2.mapwins2++;
                        o1.maploss2++;
                    }
                }
                else if(sNumber == 3)
                {
                    mapWins2++;
                    if(!postSeason){
                        o2.mapwins3++;
                        o1.maploss3++;
                    }
                }
                Debug.Log($"Map {map}: {o2.brand} wins ({score2}-{score1})");
            }

            if (mapWins1 == 3 || mapWins2 == 3)
                break;
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
    
        if (mapWins1 > mapWins2)
        {
            if(sNumber == 1)
            {
                if(!postSeason){
                o1.wins++;
                }
            }
            else if(sNumber == 2)
            {
                if(!postSeason){
                o1.wins2++;
                }
            }
            if(sNumber == 3)
            {
                if(!postSeason){
                o1.wins3++;
                }
            }
            Debug.Log($"{o1.brand} wins the series {mapWins1}-{mapWins2}");
            return(o1);
        }
        else
        {
            if(sNumber == 1)
            {
                if(!postSeason){
                o2.wins++;
                }
            }
            else if(sNumber == 2)
            {
                if(!postSeason){
                o2.wins2++;
                }
            }
            if(sNumber == 3)
            {
                if(!postSeason){
                o2.wins3++;
                }
            }
            Debug.Log($"{o2.brand} wins the series {mapWins2}-{mapWins1}");
            return(o2);
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