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

    [SerializeField] GameObject Franchising;
    [SerializeField] TextMeshProUGUI Welcome;
    [SerializeField] TextMeshProUGUI draftPlayer;
    
    int maps = 0;
    public int sNumber = 0;
    public bool postSeason;
    public bool drafting;
    public int keepnums = 0;
    public int playerCount = 0;
    public List<Player> ogPlayers = new List<Player>();
    public bool ogs = true;

    public Team[] teamList;
    public Team[] teamList2;
    public Team LunaticHai;
    public Team GCBusan;
    public Team KongdooPanthera;
    public Team Cloud9;
    public Team Envy;
    public Team Rogue;

    public Team NewYorkExcelsior;
    public Team SanFranciscoShock;
    public Team HoustonOutlaws;
    public Team BostonUprising;

    public Team[] teamsCopy;
    public Team[] teamsCopy2;
    public Team[] teamsCopy3;
    public Team[] teamsCopy4;
    public Team[] teamsCopy5;
    public Team[] teamsCopy6;
    public Team[] teamsCopy7;
    public Team[] teamsCopy8;

    [SerializeField] GameObject tankEmblem;
    [SerializeField] GameObject supportEmblem;
    [SerializeField] GameObject dpsEmblem;

    

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

        NewYorkExcelsior = gameObject.AddComponent<Team>();
        NewYorkExcelsior.brand = "New York Excelsior";

        SanFranciscoShock = gameObject.AddComponent<Team>();
        SanFranciscoShock.brand = "San Francisco Shock";

        HoustonOutlaws = gameObject.AddComponent<Team>();
        HoustonOutlaws.brand = "Houston Outlaws";

        BostonUprising = gameObject.AddComponent<Team>();
        BostonUprising.brand = "Boston Uprising";

        teamList[0] = LunaticHai;
        teamList[1] = GCBusan;
        teamList[2] = KongdooPanthera;
        teamList[3] = Cloud9;
        teamList[4] = Envy;
        teamList[5] = Rogue;

        teamList2[0] = LunaticHai;
        teamList2[1] = GCBusan;
        teamList2[2] = KongdooPanthera;
        teamList2[3] = Cloud9;
        teamList2[4] = Envy;
        teamList2[5] = Rogue;
        teamList2[6] = NewYorkExcelsior;
        teamList2[7] = SanFranciscoShock;
        teamList2[8] = HoustonOutlaws;
        teamList2[9] = BostonUprising;

        tankPlayers = tanksPlayer;

        teamsCopy[0] = LunaticHai;
        teamsCopy[1] = GCBusan;
        teamsCopy[2] = KongdooPanthera;
        teamsCopy[3] = Cloud9;
        teamsCopy[4] = Envy;
        teamsCopy[5] = Rogue;

        teamsCopy2[0] = LunaticHai;
        teamsCopy2[1] = GCBusan;
        teamsCopy2[2] = KongdooPanthera;
        teamsCopy2[3] = Cloud9;
        teamsCopy2[4] = Envy;
        teamsCopy2[5] = Rogue;

        teamsCopy3[0] = LunaticHai;
        teamsCopy3[1] = GCBusan;
        teamsCopy3[2] = KongdooPanthera;
        teamsCopy3[3] = Cloud9;
        teamsCopy3[4] = Envy;
        teamsCopy3[5] = Rogue;

        teamsCopy4[0] = LunaticHai;
        teamsCopy4[1] = GCBusan;
        teamsCopy4[2] = KongdooPanthera;
        teamsCopy4[3] = Cloud9;
        teamsCopy4[4] = Envy;
        teamsCopy4[5] = Rogue;
        teamsCopy4[6] = NewYorkExcelsior;
        teamsCopy4[7] = SanFranciscoShock;
        teamsCopy4[8] = HoustonOutlaws;
        teamsCopy4[9] = BostonUprising;

        teamsCopy5[0] = LunaticHai;
        teamsCopy5[1] = GCBusan;
        teamsCopy5[2] = KongdooPanthera;
        teamsCopy5[3] = Cloud9;
        teamsCopy5[4] = Envy;
        teamsCopy5[5] = Rogue;
        teamsCopy5[6] = NewYorkExcelsior;
        teamsCopy5[7] = SanFranciscoShock;
        teamsCopy5[8] = HoustonOutlaws;
        teamsCopy5[9] = BostonUprising;

        teamsCopy6[0] = LunaticHai;
        teamsCopy6[1] = GCBusan;
        teamsCopy6[2] = KongdooPanthera;
        teamsCopy6[3] = Cloud9;
        teamsCopy6[4] = Envy;
        teamsCopy6[5] = Rogue;
        teamsCopy6[6] = NewYorkExcelsior;
        teamsCopy6[7] = SanFranciscoShock;
        teamsCopy6[8] = HoustonOutlaws;
        teamsCopy6[9] = BostonUprising;

        teamsCopy7[0] = LunaticHai;
        teamsCopy7[1] = GCBusan;
        teamsCopy7[2] = KongdooPanthera;
        teamsCopy7[3] = Cloud9;
        teamsCopy7[4] = Envy;
        teamsCopy7[5] = Rogue;
        teamsCopy7[6] = NewYorkExcelsior;
        teamsCopy7[7] = SanFranciscoShock;
        teamsCopy7[8] = HoustonOutlaws;
        teamsCopy7[9] = BostonUprising;

        teamsCopy8[0] = LunaticHai;
        teamsCopy8[1] = GCBusan;
        teamsCopy8[2] = KongdooPanthera;
        teamsCopy8[3] = Cloud9;
        teamsCopy8[4] = Envy;
        teamsCopy8[5] = Rogue;
        teamsCopy8[6] = NewYorkExcelsior;
        teamsCopy8[7] = SanFranciscoShock;
        teamsCopy8[8] = HoustonOutlaws;
        teamsCopy8[9] = BostonUprising;

        scouting.SetActive(false);
        Franchising.SetActive(false);

        teamSheet.text = teamSheetText;
        fillTeams();
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

        if(drafting)
        {
            if(ogs)
                draftPlayer.text = $"Name: {ogPlayers[keepnums].ign}\nSkill: {ogPlayers[keepnums].skill+ogPlayers[keepnums].effectiveSkill}\nTotalScore: {ogPlayers[keepnums].seasonScore}";
            else
                draftPlayer.text = $"Name: {currentPlayer.ign}\nSkill: {currentPlayer.skill+currentPlayer.effectiveSkill}\nTotalScore: {currentPlayer.seasonScore}";
        }
    }

    public void AcceptPlayer()
    {
        Player pSelect = null;
        if(ogs)
            pSelect = ogPlayers[keepnums];
        else
        {
            pSelect = currentPlayer;
        }
        LunaticHai.players[playerCount] = pSelect;
        LunaticHai.setPlayer(playerCount, LunaticHai.players[playerCount]);
        if(playerCount == 0)
        {
            LunaticHai.p1 = pSelect;
        }
        else if(playerCount == 1)
        {
            LunaticHai.p2 = pSelect;
        }
        else if(playerCount == 2)
        {
            LunaticHai.p3 = pSelect;
        }
        else if(playerCount == 3)
        {
            LunaticHai.p4 = pSelect;
        }
        else if(playerCount == 4)
        {
            LunaticHai.p5 = pSelect;
        }
        else if(playerCount == 5)
        {
            LunaticHai.p6 = pSelect;
        }
        else if(playerCount == 6)
        {
            LunaticHai.p7 = pSelect;
        }
        else if(playerCount == 7)
        {
            LunaticHai.p8 = pSelect;
        }
        else if(playerCount == 8)
        {
            LunaticHai.p9 = pSelect;
        }
        keepnums++;
        playerCount++;
        LunaticHai.fillRoles();

        if(!ogs)
            NextPlayer();

        if(keepnums >= ogPlayers.Count)
        {
            ogs = false;
            Welcome.text = "Welcome to the OWL Draft";
            NextPlayer();
        }

        if(pSelect.role == "Tank")
        {
            for(int i = 0; i < tanksPlayer.Count; i++)
            {
                if(tanksPlayer[i].ign == pSelect.ign)
                    tanksPlayer.Remove(tanksPlayer[i]);
            }
        }
        else if(pSelect.role == "DPS")
        {
            for(int i = 0; i < dpsPlayers.Count; i++)
            {
                if(dpsPlayers[i].ign == pSelect.ign)
                    dpsPlayers.Remove(dpsPlayers[i]);
            }
        }
        else
        {
            for(int i = 0; i < supportPlayers.Count; i++)
            {
                if(supportPlayers[i].ign == pSelect.ign)
                    supportPlayers.Remove(supportPlayers[i]);
            }
        }
        if(playerCount >= 9)
        {
            drafting = false;
            supportEmblem.SetActive(false);
            Franchising.SetActive(false);
            fillTeams();

            LunaticHai.setBrand("Seoul Dynasty");
            GCBusan.setBrand("Florida Mayhem");
            KongdooPanthera.setBrand("Las Angeles Gladiators");
            Cloud9.setBrand("London Spitfire");
            Envy.setBrand("Dallas Fuel");
            Rogue.setBrand("Las Angeles Valiant");

        }
    }

    public void SkipPlayer()
    {
        if(ogs)
        {
            keepnums++;
            if(ogPlayers.Count == keepnums)
            {
                ogs = false;
                Welcome.text = "Welcome to the OWL Draft";
            }
        }
        else
            NextPlayer();
    }

    public void NextPlayer()
    {
        LunaticHai.fillRoles();
        int r = 0;
        if(LunaticHai.getTankCount() < 3)
        {
            r = Random.Range(0, tanksPlayer.Count-1);
            currentPlayer = tanksPlayer[r];
            tankEmblem.SetActive(true);
        }
        else if(LunaticHai.getDPSCount() < 3)
        {
            r = Random.Range(0, dpsPlayers.Count-1);
            currentPlayer = dpsPlayers[r];
            tankEmblem.SetActive(false);
            dpsEmblem.SetActive(true);
        }
        else
        {
            r = Random.Range(0, supportPlayers.Count-1);
            currentPlayer = supportPlayers[r];
            tankEmblem.SetActive(false);
            dpsEmblem.SetActive(false);
            supportEmblem.SetActive(true);
        }
    }

    public void fillTeams()
    {

        int rand = 0;
        int rand2 = 0;
        if(sNumber < 2)
        {
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
        else
        {
            for(int i = 1; i < teamsCopy4.Length; i++)
        {
            if (tankPlayers.Count < 2 || dpsPlayers.Count < 2 || supportPlayers.Count < 2)
            {
                return;
            }

            rand = (int)Random.Range(0, tankPlayers.Count);

            Player tank1 = tankPlayers[rand];
            teamsCopy4[i].p1 = tank1;
            tankPlayers.Remove(tankPlayers[rand]);

            rand = (int)Random.Range(0, tankPlayers.Count);

            Player tank2 = tankPlayers[Random.Range(0,tankPlayers.Count)];
            teamsCopy4[i].p2 = tank2;
            tankPlayers.Remove(tankPlayers[rand]);


            rand = (int)Random.Range(0, dpsPlayers.Count);

            Player dps1 = dpsPlayers[rand];
            teamsCopy4[i].p3 = dps1;
            dpsPlayers.Remove(dpsPlayers[rand]);

            rand = (int)Random.Range(0, dpsPlayers.Count);

            Player dps2 = dpsPlayers[Random.Range(0,dpsPlayers.Count)];
            teamsCopy4[i].p4 = dps2;
            dpsPlayers.Remove(dpsPlayers[rand]);


            rand = (int)Random.Range(0, supportPlayers.Count);

            Player support1 = supportPlayers[rand];
            teamsCopy4[i].p5 = support1;
            supportPlayers.Remove(supportPlayers[rand]);

            rand = (int)Random.Range(0, supportPlayers.Count);

            Player support2 = supportPlayers[Random.Range(0,supportPlayers.Count)];
            teamsCopy4[i].p6 = support2;
            supportPlayers.Remove(supportPlayers[rand]);

            rand = (int)Random.Range(1,4);
            if(rand == 1){
                rand2 = Random.Range(0, tankPlayers.Count);
                Player sub = tankPlayers[rand2];
                teamsCopy4[i].p7 = sub;
                tankPlayers.Remove(tankPlayers[rand2]);
            }
            else if(rand == 2)
            {
                rand2 = Random.Range(0, dpsPlayers.Count);
                Player sub = dpsPlayers[rand2];
                teamsCopy4[i].p7 = sub;
                dpsPlayers.Remove(dpsPlayers[rand2]);
            }
            else
            {
                rand2 = Random.Range(0, supportPlayers.Count);
                Player sub = supportPlayers[rand2];
                teamsCopy4[i].p7 = sub;
                supportPlayers.Remove(supportPlayers[rand2]);
            }

            rand = (int)Random.Range(1,4);
            if(rand == 1){
                rand2 = Random.Range(0, tankPlayers.Count);
                Player sub = tankPlayers[rand2];
                teamsCopy4[i].p8 = sub;
                tankPlayers.Remove(tankPlayers[rand2]);
            }
            else if(rand == 2)
            {
                rand2 = Random.Range(0, dpsPlayers.Count);
                Player sub = dpsPlayers[rand2];
                teamsCopy4[i].p8 = sub;
                dpsPlayers.Remove(dpsPlayers[rand2]);
            }
            else
            {
                rand2 = Random.Range(0, supportPlayers.Count);
                Player sub = supportPlayers[rand2];
                teamsCopy4[i].p8 = sub;
                supportPlayers.Remove(supportPlayers[rand2]);
            }

            rand = (int)Random.Range(1,4);
            if(rand == 1){
                rand2 = Random.Range(0, tankPlayers.Count);
                Player sub = tankPlayers[rand2];
                teamsCopy4[i].p9 = sub;
                tankPlayers.Remove(tankPlayers[rand2]);
            }
            else if(rand == 2)
            {
                rand2 = Random.Range(0, dpsPlayers.Count);
                Player sub = dpsPlayers[rand2];
                teamsCopy4[i].p9 = sub;
                dpsPlayers.Remove(dpsPlayers[rand2]);
            }
            else
            {
                rand2 = Random.Range(0, supportPlayers.Count);
                Player sub = supportPlayers[rand2];
                teamsCopy4[i].p9 = sub;
                supportPlayers.Remove(supportPlayers[rand2]);
            }
            teamsCopy4[i].p10 = nullPlayer;
            teamsCopy4[i].p11 = nullPlayer;
            teamsCopy4[i].p12 = nullPlayer;
        }
        for(int i = 0; i < teamsCopy4.Length; i++)
        {
            teamsCopy4[i].fillRoles();
        }
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
                        o2.mapwins++;
                        o1.maploss++;
                    }
                }
                else if(sNumber == 2)
                {
                    mapWins1++;
                    if(!postSeason){
                        o2.mapwins2++;
                        o1.maploss2++;
                    }
                }
                else if(sNumber == 3)
                {
                    mapWins1++;
                    if(!postSeason){
                        o2.mapwins3++;
                        o1.maploss3++;
                    }
                }
                else if(sNumber == 4)
                {
                    mapWins1++;
                    if(!postSeason){
                        o2.mapwins4++;
                        o1.maploss4++;
                    }
                }
                else if(sNumber == 5)
                {
                    mapWins1++;
                    if(!postSeason){
                        o2.mapwins5++;
                        o1.maploss5++;
                    }
                }
                else if(sNumber == 6)
                {
                    mapWins1++;
                    if(!postSeason){
                        o2.mapwins6++;
                        o1.maploss6++;
                    }
                }
                else if(sNumber == 7)
                {
                    mapWins1++;
                    if(!postSeason){
                        o2.mapwins7++;
                        o1.maploss7++;
                    }
                }
                else if(sNumber == 8)
                {
                    mapWins1++;
                    if(!postSeason){
                        o2.mapwins8++;
                        o1.maploss8++;
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
                else if(sNumber == 4)
                {
                    mapWins2++;
                    if(!postSeason){
                        o2.mapwins4++;
                        o1.maploss4++;
                    }
                }
                else if(sNumber == 5)
                {
                    mapWins2++;
                    if(!postSeason){
                        o2.mapwins5++;
                        o1.maploss5++;
                    }
                }
                else if(sNumber == 6)
                {
                    mapWins2++;
                    if(!postSeason){
                        o2.mapwins6++;
                        o1.maploss6++;
                    }
                }
                else if(sNumber == 7)
                {
                    mapWins2++;
                    if(!postSeason){
                        o2.mapwins7++;
                        o1.maploss7++;
                    }
                }
                else if(sNumber == 8)
                {
                    mapWins2++;
                    if(!postSeason){
                        o2.mapwins8++;
                        o1.maploss8++;
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
            else if(sNumber == 3)
            {
                if(!postSeason){
                o1.wins3++;
                }
            }
            else if(sNumber == 4)
            {
                if(!postSeason){
                o1.wins4++;
                }
            }
            else if(sNumber == 5)
            {
                if(!postSeason){
                o1.wins5++;
                }
            }
            else if(sNumber == 6)
            {
                if(!postSeason){
                o1.wins6++;
                }
            }
            else if(sNumber == 7)
            {
                if(!postSeason){
                o1.wins7++;
                }
            }
            else if(sNumber == 8)
            {
                if(!postSeason){
                o1.wins8++;
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
            else if(sNumber == 3)
            {
                if(!postSeason){
                o2.wins3++;
                }
            }
            else if(sNumber == 4)
            {
                if(!postSeason){
                o2.wins4++;
                }
            }
            else if(sNumber == 5)
            {
                if(!postSeason){
                o2.wins5++;
                }
            }
            else if(sNumber == 6)
            {
                if(!postSeason){
                o2.wins6++;
                }
            }
            else if(sNumber == 7)
            {
                if(!postSeason){
                o2.wins7++;
                }
            }
            else if(sNumber == 8)
            {
                if(!postSeason){
                o2.wins8++;
                }
            }
            Debug.Log($"{o2.brand} wins the series {mapWins2}-{mapWins1}");
            return(o2);
        }
        
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

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < teamsCopy.Length; i++)
            {
                Team t = teamsCopy[i];
                int rank = i + 1;
                sb.AppendLine($"{rank}. {t.brand}: {t.wins}W ({t.mapwins}/{t.maploss})");
            }
            standings.text = sb.ToString();
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

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < teamsCopy2.Length; i++)
            {
                Team t = teamsCopy2[i];
                int rank = i + 1;
                sb.AppendLine($"{rank}. {t.brand}: {t.wins2}W ({t.mapwins2}/{t.maploss2})");
            }
            standings.text = sb.ToString();
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

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < teamsCopy3.Length; i++)
            {
                Team t = teamsCopy3[i];
                int rank = i + 1;
                sb.AppendLine($"{rank}. {t.brand}: {t.wins3}W ({t.mapwins3}/{t.maploss3})");
            }
            standings.text = sb.ToString();
        }
        else if(sNumber == 4)
        {
            System.Array.Sort(teamsCopy4, (a, b) =>
            {
                int winCompare = b.wins4.CompareTo(a.wins4);
                if (winCompare != 0)
                    return winCompare;

                int mapWinCompare = b.mapwins4.CompareTo(a.mapwins4);
                if (mapWinCompare != 0)
                    return mapWinCompare;

                return a.maploss4.CompareTo(b.maploss4);
            });

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < teamsCopy4.Length; i++)
            {
                Team t = teamsCopy4[i];
                int rank = i + 1;
                sb.AppendLine($"{rank}. {t.brand}: {t.wins4}W ({t.mapwins4}/{t.maploss4})");
            }
            standings.text = sb.ToString();
        }
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
        if(sNumber <= 3)
        {
        for (int i = 0; i < teamList.Length; i++)
        {
            for (int j = i + 1; j < teamList.Length; j++)
            {
                if (i == j)
                    continue;
                match(teamList[i], teamList[j]);
            }
        }
        }
        else
        {
            for (int i = 0; i < teamList2.Length; i++)
        {
            for (int j = i + 1; j < teamList2.Length; j++)
            {
                if (i == j)
                    continue;
                match(teamList2[i], teamList2[j]);
            }
        }
        }
        postSeason = true;
        bracket();
        
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
        NPCScouting();
    }

    public void AddPlayerNPC(Team t)
    {
        for(int i = 0; i < t.players.Length; i++)
        {
            if(t.players[i] == nullPlayer)
            {
                if(i == 7)
                {
                    t.setPlayer(i, currentPlayer);
                    t.p8 = currentPlayer;
                }
                else if(i == 8)
                {
                    t.setPlayer(i, currentPlayer);
                    t.p9 = currentPlayer;
                }
                else if(i == 9)
                {
                    t.setPlayer(i, currentPlayer);
                    t.p10 = currentPlayer;
                }
                else if(i == 10)
                {
                    t.setPlayer(i, currentPlayer);
                    t.p11 = currentPlayer;
                }
                else
                {
                    t.setPlayer(i, currentPlayer);
                    t.p12 = currentPlayer;
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
        String S1Winner = "";
        String secondP1 = "";
        String S2Winner = "";
        String secondP2 = "";
        String S3Winner = "";
        String secondP3 = "";
        String S4Winner = "";
        String secondP4 = "";
        String S5Winner = "";
        String secondP5 = "";
        String S6Winner = "";
        String secondP6 = "";
        String S7Winner = "";
        String secondP7 = "";
        String S8Winner = "";
        String secondP8 = "";



        if(sNumber == 1)
        {
            Team t1 = match(teamsCopy[0],teamsCopy[3]);
            Team t2 = match(teamsCopy[1],teamsCopy[2]);
            S1Winner = match(t1,t2).brand;
            Debug.Log(S1Winner + "Has won Season 1");
            if(S1Winner == t1.brand)
                secondP1 = t2.brand;
            else
                secondP1 = t1.brand;

            //winner.text = "Champions: " + firstP;
            //runnerUp.text = "Runner Ups: " + secondP;
            postSeason = false;
        }
        
        else if(sNumber == 2)
        {
            Team t1 = match(teamsCopy2[0],teamsCopy2[3]);
            Team t2 = match(teamsCopy2[1],teamsCopy2[2]);
            S2Winner = match(t1,t2).brand;
            Debug.Log(S2Winner + "Has won Season 2");
            if(S2Winner == t1.brand)
                secondP2 = t2.brand;
            else
                secondP2 = t1.brand;

            //winner.text = "Champions: " + firstP;
            //runnerUp.text = "Runner Ups: " + secondP;
            postSeason = false;
        }
        else if(sNumber == 3)
        {
            Team t1 = match(teamsCopy3[0],teamsCopy3[3]);
            Team t2 = match(teamsCopy3[1],teamsCopy3[2]);
            S3Winner = match(t1,t2).brand;
            Debug.Log(S3Winner + "Has won Season 3");
            if(S3Winner == t1.brand)
                secondP3 = t2.brand;
            else
                secondP3 = t1.brand;

            //winner.text = "Champions: " + firstP;
            //runnerUp.text = "Runner Ups: " + secondP;
            postSeason = false;
            Franchise();
        }

        else if(sNumber == 4)
        {
            Team t1 = match(teamsCopy4[0],teamsCopy4[3]);
            Team t2 = match(teamsCopy4[1],teamsCopy4[2]);
            S4Winner = match(t1,t2).brand;
            Debug.Log(S3Winner + "Has won OWL Season 1");
            if(S4Winner == t1.brand)
                secondP4 = t2.brand;
            else
                secondP4 = t1.brand;

            //winner.text = "Champions: " + firstP;
            //runnerUp.text = "Runner Ups: " + secondP;
            postSeason = false;
        }

        else if(sNumber == 5)
        {
            Team t1 = match(teamsCopy5[0],teamsCopy5[3]);
            Team t2 = match(teamsCopy5[1],teamsCopy5[2]);
            S5Winner = match(t1,t2).brand;
            Debug.Log(S3Winner + "Has won OWL Season 2");
            if(S5Winner == t1.brand)
                secondP5 = t2.brand;
            else
                secondP5 = t1.brand;

            //winner.text = "Champions: " + firstP;
            //runnerUp.text = "Runner Ups: " + secondP;
            postSeason = false;
        }

        else if(sNumber == 6)
        {
            Team t1 = match(teamsCopy6[0],teamsCopy6[3]);
            Team t2 = match(teamsCopy6[1],teamsCopy6[2]);
            S6Winner = match(t1,t2).brand;
            Debug.Log(S6Winner + "Has won OWL Season 3");
            if(S6Winner == t1.brand)
                secondP6 = t2.brand;
            else
                secondP6 = t1.brand;

            //winner.text = "Champions: " + firstP;
            //runnerUp.text = "Runner Ups: " + secondP;
            postSeason = false;
        }

        else if(sNumber == 7)
        {
            Team t1 = match(teamsCopy7[0],teamsCopy7[3]);
            Team t2 = match(teamsCopy7[1],teamsCopy7[2]);
            S7Winner = match(t1,t2).brand;
            Debug.Log(S7Winner + "Has won OWL Season 4");
            if(S7Winner == t1.brand)
                secondP7 = t2.brand;
            else
                secondP7 = t1.brand;

            //winner.text = "Champions: " + firstP;
            //runnerUp.text = "Runner Ups: " + secondP;
            postSeason = false;
        }

        else if(sNumber == 8)
        {
            Team t1 = match(teamsCopy8[0],teamsCopy8[3]);
            Team t2 = match(teamsCopy8[1],teamsCopy8[2]);
            S8Winner = match(t1,t2).brand;
            Debug.Log(S8Winner + "Has won OWL Season 5");
            if(S8Winner == t1.brand)
                secondP8 = t2.brand;
            else
                secondP8 = t1.brand;

            //winner.text = "Champions: " + firstP;
            //runnerUp.text = "Runner Ups: " + secondP;
            postSeason = false;
        }
    }

    public void NPCScouting()
    {
        for(int i = 1; i < teamList.Length; i++)
        {
            if(teamList[i].p12 != nullPlayer)
                break;
            int pnum = (int)Random.Range(0, 3);
            if(pnum == 0)
                ScoutingTank();
            else if(pnum == 1)
                ScoutingDPS();
            else
                ScoutingSupport();
            AddPlayerNPC(teamList[i]);
        }
    }

    public void ClearTeam(Team t)
    {
        for(int i = 0; i < 12; i++)
        {
            if(t.players[i] != nullPlayer)
            {
                if(t.players[i].role == "Tank")
                {
                    tanksPlayer.Add(t.players[i]);
                }
                else if(t.players[i].role == "Support")
                {
                    supportPlayers.Add(t.players[i]);
                }
                else
                {
                    dpsPlayers.Add(t.players[i]);
                }
                t.players[i] = nullPlayer;
                t.setPlayer(i, nullPlayer);
                Debug.Log(t.players[i]);
            }
        }
        t.p1 = nullPlayer;
        t.p2 = nullPlayer;
        t.p3 = nullPlayer;
        t.p4 = nullPlayer;
        t.p5 = nullPlayer;
        t.p6 = nullPlayer;
        t.p7 = nullPlayer;
        t.p8 = nullPlayer;
        t.p9 = nullPlayer;
        t.p10 = nullPlayer;
        t.p11 = nullPlayer;
        t.p12 = nullPlayer;
    }

    public void Franchise()
    {
        for(int i = 1; i < teamList.Length; i++)
        {
            ClearTeam(teamList[i]);
        }

        for(int i = 0; i < 12; i++)
        {
            if(LunaticHai.players[i] != nullPlayer)
            {
                ogPlayers.Add(LunaticHai.players[i]);
                LunaticHai.players[i] = nullPlayer;
                LunaticHai.setPlayer(i, nullPlayer);
            }
        }
        LunaticHai.p1 = nullPlayer;
        LunaticHai.p2 = nullPlayer;
        LunaticHai.p3 = nullPlayer;
        LunaticHai.p4 = nullPlayer;
        LunaticHai.p5 = nullPlayer;
        LunaticHai.p6 = nullPlayer;
        LunaticHai.p7 = nullPlayer;
        LunaticHai.p8 = nullPlayer;
        LunaticHai.p9 = nullPlayer;
        LunaticHai.p10 = nullPlayer;
        LunaticHai.p11 = nullPlayer;
        LunaticHai.p12 = nullPlayer;
        Franchising.SetActive(true);
        Welcome.text = "Who do you want to re-sign?";
        drafting = true;
    }
}