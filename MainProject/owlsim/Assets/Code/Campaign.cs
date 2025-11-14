using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = UnityEngine.Random;
using TMPro;
using System.Text;

public class Campaign : MonoBehaviour
{
    public List<Player> tankPlayers = new List<Player>();
    public List<Player> tanksPlayer = new List<Player>();
    public List<Player> dpsPlayers = new List<Player>();
    public List<Player> supportPlayers = new List<Player>();

    [SerializeField] Player nullPlayer;
    [SerializeField] TextMeshProUGUI standings;
    [SerializeField] GameObject scouting;
    [SerializeField] TextMeshProUGUI scouting2;
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] TextMeshProUGUI teamSheet;


    public Team[] teamList;
    public Team LunaticHai;
    public Team GCBusan;
    public Team KongdooPanthera;
    public Team Cloud9;
    public Team Envy;
    public Team Rogue;

    public Team[] teamsCopy;

    int maps = 0;
    int sNumber = 0;
    public bool postSeason;

    float timer = 0f;
    bool timing = false;

    Player currentPlayer;
    bool teamShown = true;
    String teamSheetText = "";
    



    void Start()
    {
        
        LunaticHai = gameObject.AddComponent<Team>();
        LunaticHai.brand = "Lunatic Hai";

        GCBusan = gameObject.AddComponent<Team>();
        GCBusan.brand = "GC Busan";

        KongdooPanthera = gameObject.AddComponent<Team>();
        KongdooPanthera.brand = "Kongdoo Panthera";

        Cloud9 = gameObject.AddComponent<Team>();
        Cloud9.brand = "Cloud9";

        Envy = gameObject.AddComponent<Team>();
        Envy.brand = "Envy";

        Rogue = gameObject.AddComponent<Team>();
        Rogue.brand = "Rogue";

        teamList[0] = LunaticHai;
        teamList[1] = GCBusan;
        teamList[2] = KongdooPanthera;
        teamList[3] = Cloud9;
        teamList[4] = Envy;
        teamList[5] = Rogue;

        tankPlayers = tanksPlayer;

        teamsCopy[0] = LunaticHai;
        teamsCopy[1] = GCBusan;
        teamsCopy[2] = KongdooPanthera;
        teamsCopy[3] = Cloud9;
        teamsCopy[4] = Envy;
        teamsCopy[5] = Rogue;

        scouting.SetActive(false);

        teamSheet.text = teamSheetText;
    }
    
    void Update()
    {
        if(timing)
        {
            timerText.text = $"Timer: {(int)timer}";
            timer+=Time.deltaTime;
            if(timer >= 5)
            {
                timing = false;
                timer = 0;
                scouting.SetActive(false);
            }
        }
    }

    public void fillTeams()
    {

        int rand = 0;
        int rand2 = 0;
        for(int i = 0; i < teamList.Length; i++)
        {
            if (tankPlayers.Count < 2 || dpsPlayers.Count < 2 || supportPlayers.Count < 2)
            {
                return;
            }

            rand = (int)Random.Range(0, tankPlayers.Count);

            Player tank1 = tankPlayers[rand];
            teamList[i].p1 = tank1;
            tankPlayers.Remove(tankPlayers[rand]);

            rand = (int)Random.Range(0, tankPlayers.Count);

            Player tank2 = tankPlayers[Random.Range(0,tankPlayers.Count)];
            teamList[i].p2 = tank2;
            tankPlayers.Remove(tankPlayers[rand]);


            rand = (int)Random.Range(0, dpsPlayers.Count);

            Player dps1 = dpsPlayers[rand];
            teamList[i].p3 = dps1;
            dpsPlayers.Remove(dpsPlayers[rand]);

            rand = (int)Random.Range(0, dpsPlayers.Count);

            Player dps2 = dpsPlayers[Random.Range(0,dpsPlayers.Count)];
            teamList[i].p4 = dps2;
            dpsPlayers.Remove(dpsPlayers[rand]);


            rand = (int)Random.Range(0, supportPlayers.Count);

            Player support1 = supportPlayers[rand];
            teamList[i].p5 = support1;
            supportPlayers.Remove(supportPlayers[rand]);

            rand = (int)Random.Range(0, supportPlayers.Count);

            Player support2 = supportPlayers[Random.Range(0,supportPlayers.Count)];
            teamList[i].p6 = support2;
            supportPlayers.Remove(supportPlayers[rand]);

            rand = (int)Random.Range(1,4);
            if(rand == 1){
                rand2 = Random.Range(0, tankPlayers.Count);
                Player sub = tankPlayers[rand2];
                teamList[i].p7 = sub;
                tankPlayers.Remove(tankPlayers[rand2]);
            }
            else if(rand == 2)
            {
                rand2 = Random.Range(0, dpsPlayers.Count);
                Player sub = dpsPlayers[rand2];
                teamList[i].p7 = sub;
                dpsPlayers.Remove(dpsPlayers[rand2]);
            }
            else
            {
                rand2 = Random.Range(0, supportPlayers.Count);
                Player sub = supportPlayers[rand2];
                teamList[i].p7 = sub;
                supportPlayers.Remove(supportPlayers[rand2]);
            }
            teamList[i].p8 = nullPlayer;
            teamList[i].p9 = nullPlayer;
            teamList[i].p10 = nullPlayer;
            teamList[i].p11 = nullPlayer;
            teamList[i].p12 = nullPlayer;
            


        }
    }

    public int getScore(Player p, int currentMap)
    {
        if(p != nullPlayer){
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
        else
            return 0;
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
        for (int i = 0; i < t.tanks.Length; i++)
        {
            tankScores[i] = getScore(t.tanks[i], maps);
        }

        int topIndex1 = -1, topIndex2 = -1;
        int topScore1 = int.MinValue, topScore2 = int.MinValue;

        for (int i = 0; i < tankScores.Length; i++)
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

    for (int i = 0; i < t.tanks.Length; i++)
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
        for (int i = 0; i < t.dps.Length; i++)
        {
            dpsScores[i] = getScore(t.dps[i], maps);
        }

        int topIndex1 = -1, topIndex2 = -1;
        int topScore1 = int.MinValue, topScore2 = int.MinValue;

        for (int i = 0; i < dpsScores.Length; i++)
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

        for (int i = 0; i < t.dps.Length; i++)
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
        for (int i = 0; i < t.supports.Length; i++)
        {
            supportScores[i] = getScore(t.supports[i], maps);
        }

        int topIndex1 = -1, topIndex2 = -1;
        int topScore1 = int.MinValue, topScore2 = int.MinValue;

        for (int i = 0; i < supportScores.Length; i++)
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

        for (int i = 0; i < t.supports.Length; i++)
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


    public void UpdateStandingsUI()
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

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < teamsCopy.Length; i++)
        {
            Team t = teamsCopy[i];
            int rank = i + 1;
            sb.AppendLine($"{rank}. {t.brand}: {t.wins}W ({t.mapwins}/{t.maploss})");
        }

        standings.text = sb.ToString();
        }

    public int tie(int s1)
    {
        int r = UnityEngine.Random.Range(1,3);
        if(r < 2)
            return s1+1;
        else
        return s1-1;
    }


        public void pressButt()
        {
            match(GCBusan, LunaticHai);
        }

        public void tourney()
    {   
        sNumber++;
        for (int i = 0; i < teamList.Length; i++)
        {
            for (int j = i + 1; j < teamList.Length; j++)
            {
                if (i == j)
                    continue;
                match(teamList[i], teamList[j]);
            }
        }
        postSeason = true;
        //bracket();
        
        //seasonNumber.text = "Season: " + sNumber;

        scouting.SetActive(true);
        timing = true;
    }

    public void ScoutingTank()
    {
        int tank = (int)Random.Range(0,tankPlayers.Count);
        String name = tankPlayers[tank].ign;
        String skill = tankPlayers[tank].skill.ToString();
        scouting2.text = $"{name}\n{skill}";
        currentPlayer = tankPlayers[tank];
    }

    public void ScoutingDPS()
    {
        int dps = (int)Random.Range(0,dpsPlayers.Count);
        String name = dpsPlayers[dps].ign;
        String skill = dpsPlayers[dps].skill.ToString();
        scouting2.text = $"{name}\n{skill}";
        currentPlayer = dpsPlayers[dps];
    }

    public void ScoutingSupport()
    {
        int support = (int)Random.Range(0,supportPlayers.Count);
        String name = supportPlayers[support].ign;
        String skill = supportPlayers[support].skill.ToString();
        scouting2.text = $"{name}\n{skill}";
        currentPlayer = supportPlayers[support];
    }

    public void AddPlayer()
    {
        for(int i = 0; i < LunaticHai.players.Length; i++)
        {
            if(LunaticHai.players[i] == nullPlayer)
            {
                if(i == 7)
                {
                    LunaticHai.setPlayer(i, currentPlayer);
                    LunaticHai.p8 = currentPlayer;
                }
                else if(i == 8)
                {
                    LunaticHai.setPlayer(i, currentPlayer);
                    LunaticHai.p9 = currentPlayer;
                }
                else if(i == 9)
                {
                    LunaticHai.setPlayer(i, currentPlayer);
                    LunaticHai.p10 = currentPlayer;
                }
                else if(i == 10)
                {
                    LunaticHai.setPlayer(i, currentPlayer);
                    LunaticHai.p11 = currentPlayer;
                }
                else
                {
                    LunaticHai.setPlayer(i, currentPlayer);
                    LunaticHai.p12 = currentPlayer;
                }
                break;
            }
            if(currentPlayer.role == "Tank")
            {
                tankPlayers.Remove(currentPlayer);
            }
            else if(currentPlayer.role == "DPS")
            {
                dpsPlayers.Remove(currentPlayer);
            }
            else
            {
                supportPlayers.Remove(currentPlayer);
            }
        }
        
        timer = 6;
        
    }

    public void showTeam()
    {
        if(teamShown == false)
        {
            teamSheetText = "";
            teamSheet.text = teamSheetText;
            teamShown = true;
        }
        else
        {
            for(int i = 0; i < LunaticHai.players.Length; i++)
            {
                if(LunaticHai.players[i] != nullPlayer)
                {
                    teamSheetText += LunaticHai.players[i].ign + "\n";
                }
            }
            teamSheet.text = teamSheetText;
            teamShown = false;
        }

    }

    public void bracket()
    {
        
    }






}
