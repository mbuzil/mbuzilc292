using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = UnityEngine.Random;
using TMPro;
using System.Text;

public class Campaign : MonoBehaviour
{
    public List<Player> realTankPlayers = new List<Player>();
    public List<Player> dpsPlayers = new List<Player>();
    public List<Player> supportPlayers = new List<Player>();

    public List<Player> tankCopy = new List<Player>();
    public List<Player> dpsCopy = new List<Player>();
    public List<Player> supportCopy = new List<Player>();

    [SerializeField] Player nullPlayer;
    [SerializeField] TextMeshProUGUI standings;
    [SerializeField] GameObject ScoutButton;
    [SerializeField] GameObject scouting;
    [SerializeField] TextMeshProUGUI scouting2;
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] TextMeshProUGUI teamSheet;
    [SerializeField] GameObject nextButton;

    [SerializeField] GameObject Franchising;
    [SerializeField] TextMeshProUGUI Welcome;
    [SerializeField] TextMeshProUGUI draftPlayer;
    
    [SerializeField] TextMeshProUGUI score1;
    [SerializeField] TextMeshProUGUI score2;
    [SerializeField] TextMeshProUGUI score3;
    [SerializeField] TextMeshProUGUI score4;
    [SerializeField] TextMeshProUGUI score5;
    [SerializeField] TextMeshProUGUI score6;
    [SerializeField] TextMeshProUGUI score7;
    [SerializeField] TextMeshProUGUI score8;
    [SerializeField] TextMeshProUGUI score9;
    [SerializeField] TextMeshProUGUI score10;
    [SerializeField] TextMeshProUGUI score11;
    [SerializeField] TextMeshProUGUI score12;
    [SerializeField] TextMeshProUGUI score13;
    [SerializeField] TextMeshProUGUI score14;
    [SerializeField] TextMeshProUGUI score15;

    [SerializeField] TextMeshProUGUI score16;
    [SerializeField] TextMeshProUGUI score17;
    [SerializeField] TextMeshProUGUI score18;
    [SerializeField] TextMeshProUGUI score19;
    [SerializeField] TextMeshProUGUI score20;
    [SerializeField] TextMeshProUGUI score21;
    [SerializeField] TextMeshProUGUI score22;
    [SerializeField] TextMeshProUGUI score23;
    [SerializeField] TextMeshProUGUI score24;
    [SerializeField] TextMeshProUGUI score25;
    [SerializeField] TextMeshProUGUI score26;
    [SerializeField] TextMeshProUGUI score27;
    [SerializeField] TextMeshProUGUI score28;
    [SerializeField] TextMeshProUGUI score29;
    [SerializeField] TextMeshProUGUI score30;
    [SerializeField] TextMeshProUGUI score31;
    [SerializeField] TextMeshProUGUI score32;
    [SerializeField] TextMeshProUGUI score33;
    [SerializeField] TextMeshProUGUI score34;
    [SerializeField] TextMeshProUGUI score35;
    [SerializeField] TextMeshProUGUI score36;
    [SerializeField] TextMeshProUGUI score37;
    [SerializeField] TextMeshProUGUI score38;
    [SerializeField] TextMeshProUGUI score39;
    [SerializeField] TextMeshProUGUI score40;
    [SerializeField] TextMeshProUGUI score41;
    [SerializeField] TextMeshProUGUI score42;
    [SerializeField] TextMeshProUGUI score43;
    [SerializeField] TextMeshProUGUI score44;
    [SerializeField] TextMeshProUGUI score45;
    [SerializeField] TextMeshProUGUI score46;
    [SerializeField] TextMeshProUGUI score47;
    [SerializeField] TextMeshProUGUI score48;
    [SerializeField] TextMeshProUGUI score49;
    [SerializeField] TextMeshProUGUI score50;
    [SerializeField] TextMeshProUGUI score51;
    [SerializeField] TextMeshProUGUI score52;
    [SerializeField] TextMeshProUGUI score53;
    [SerializeField] TextMeshProUGUI score54;
    [SerializeField] TextMeshProUGUI score55;
    [SerializeField] TextMeshProUGUI score56;
    [SerializeField] TextMeshProUGUI score57;
    [SerializeField] TextMeshProUGUI score58;
    [SerializeField] TextMeshProUGUI score59;
    [SerializeField] TextMeshProUGUI score60;

    public String Score1 = "";
    public String Score2 = "";
    public String Score3 = "";
    public String Score4 = "";
    public String Score5 = "";
    public String Score6 = "";
    public String Score7 = "";
    public String Score8 = "";
    public String Score9 = "";
    public String Score10 = "";
    public String Score11 = "";
    public String Score12 = "";
    public String Score13 = "";
    public String Score14 = "";
    public String Score15 = "";

    public String s2Score1 = "";
    public String s2Score2 = "";
    public String s2Score3 = "";
    public String s2Score4 = "";
    public String s2Score5 = "";
    public String s2Score6 = "";
    public String s2Score7 = "";
    public String s2Score8 = "";
    public String s2Score9 = "";
    public String s2Score10 = "";
    public String s2Score11 = "";
    public String s2Score12 = "";
    public String s2Score13 = "";
    public String s2Score14 = "";
    public String s2Score15 = "";

    public String s3Score1 = "";
    public String s3Score2 = "";
    public String s3Score3 = "";
    public String s3Score4 = "";
    public String s3Score5 = "";
    public String s3Score6 = "";
    public String s3Score7 = "";
    public String s3Score8 = "";
    public String s3Score9 = "";
    public String s3Score10 = "";
    public String s3Score11 = "";
    public String s3Score12 = "";
    public String s3Score13 = "";
    public String s3Score14 = "";
    public String s3Score15 = "";


    public String Score16 = "";
    public String Score17 = "";
    public String Score18 = "";
    public String Score19 = "";
    public String Score20 = "";
    public String Score21 = "";
    public String Score22 = "";
    public String Score23 = "";
    public String Score24 = "";
    public String Score25 = "";
    public String Score26 = "";
    public String Score27 = "";
    public String Score28 = "";
    public String Score29 = "";
    public String Score30 = "";
    public String Score31 = "";
    public String Score32 = "";
    public String Score33 = "";
    public String Score34 = "";
    public String Score35 = "";
    public String Score36 = "";
    public String Score37 = "";
    public String Score38 = "";
    public String Score39 = "";
    public String Score40 = "";
    public String Score41 = "";
    public String Score42 = "";
    public String Score43 = "";
    public String Score44 = "";
    public String Score45 = "";
    public String Score46 = "";
    public String Score47 = "";
    public String Score48 = "";
    public String Score49 = "";
    public String Score50 = "";
    public String Score51 = "";
    public String Score52 = "";
    public String Score53 = "";
    public String Score54 = "";
    public String Score55 = "";
    public String Score56 = "";
    public String Score57 = "";
    public String Score58 = "";
    public String Score59 = "";
    public String Score60 = "";

    public String s5Score16 = "";
    public String s5Score17 = "";
    public String s5Score18 = "";
    public String s5Score19 = "";
    public String s5Score20 = "";
    public String s5Score21 = "";
    public String s5Score22 = "";
    public String s5Score23 = "";
    public String s5Score24 = "";
    public String s5Score25 = "";
    public String s5Score26 = "";
    public String s5Score27 = "";
    public String s5Score28 = "";
    public String s5Score29 = "";
    public String s5Score30 = "";
    public String s5Score31 = "";
    public String s5Score32 = "";
    public String s5Score33 = "";
    public String s5Score34 = "";
    public String s5Score35 = "";
    public String s5Score36 = "";
    public String s5Score37 = "";
    public String s5Score38 = "";
    public String s5Score39 = "";
    public String s5Score40 = "";
    public String s5Score41 = "";
    public String s5Score42 = "";
    public String s5Score43 = "";
    public String s5Score44 = "";
    public String s5Score45 = "";
    public String s5Score46 = "";
    public String s5Score47 = "";
    public String s5Score48 = "";
    public String s5Score49 = "";
    public String s5Score50 = "";
    public String s5Score51 = "";
    public String s5Score52 = "";
    public String s5Score53 = "";
    public String s5Score54 = "";
    public String s5Score55 = "";
    public String s5Score56 = "";
    public String s5Score57 = "";
    public String s5Score58 = "";
    public String s5Score59 = "";
    public String s5Score60 = "";

    public String s6Score16 = "";
    public String s6Score17 = "";
    public String s6Score18 = "";
    public String s6Score19 = "";
    public String s6Score20 = "";
    public String s6Score21 = "";
    public String s6Score22 = "";
    public String s6Score23 = "";
    public String s6Score24 = "";
    public String s6Score25 = "";
    public String s6Score26 = "";
    public String s6Score27 = "";
    public String s6Score28 = "";
    public String s6Score29 = "";
    public String s6Score30 = "";
    public String s6Score31 = "";
    public String s6Score32 = "";
    public String s6Score33 = "";
    public String s6Score34 = "";
    public String s6Score35 = "";
    public String s6Score36 = "";
    public String s6Score37 = "";
    public String s6Score38 = "";
    public String s6Score39 = "";
    public String s6Score40 = "";
    public String s6Score41 = "";
    public String s6Score42 = "";
    public String s6Score43 = "";
    public String s6Score44 = "";
    public String s6Score45 = "";
    public String s6Score46 = "";
    public String s6Score47 = "";
    public String s6Score48 = "";
    public String s6Score49 = "";
    public String s6Score50 = "";
    public String s6Score51 = "";
    public String s6Score52 = "";
    public String s6Score53 = "";
    public String s6Score54 = "";
    public String s6Score55 = "";
    public String s6Score56 = "";
    public String s6Score57 = "";
    public String s6Score58 = "";
    public String s6Score59 = "";
    public String s6Score60 = "";

    public String s7Score16 = "";
    public String s7Score17 = "";
    public String s7Score18 = "";
    public String s7Score19 = "";
    public String s7Score20 = "";
    public String s7Score21 = "";
    public String s7Score22 = "";
    public String s7Score23 = "";
    public String s7Score24 = "";
    public String s7Score25 = "";
    public String s7Score26 = "";
    public String s7Score27 = "";
    public String s7Score28 = "";
    public String s7Score29 = "";
    public String s7Score30 = "";
    public String s7Score31 = "";
    public String s7Score32 = "";
    public String s7Score33 = "";
    public String s7Score34 = "";
    public String s7Score35 = "";
    public String s7Score36 = "";
    public String s7Score37 = "";
    public String s7Score38 = "";
    public String s7Score39 = "";
    public String s7Score40 = "";
    public String s7Score41 = "";
    public String s7Score42 = "";
    public String s7Score43 = "";
    public String s7Score44 = "";
    public String s7Score45 = "";
    public String s7Score46 = "";
    public String s7Score47 = "";
    public String s7Score48 = "";
    public String s7Score49 = "";
    public String s7Score50 = "";
    public String s7Score51 = "";
    public String s7Score52 = "";
    public String s7Score53 = "";
    public String s7Score54 = "";
    public String s7Score55 = "";
    public String s7Score56 = "";
    public String s7Score57 = "";
    public String s7Score58 = "";
    public String s7Score59 = "";
    public String s7Score60 = "";

    public String s8Score16 = "";
    public String s8Score17 = "";
    public String s8Score18 = "";
    public String s8Score19 = "";
    public String s8Score20 = "";
    public String s8Score21 = "";
    public String s8Score22 = "";
    public String s8Score23 = "";
    public String s8Score24 = "";
    public String s8Score25 = "";
    public String s8Score26 = "";
    public String s8Score27 = "";
    public String s8Score28 = "";
    public String s8Score29 = "";
    public String s8Score30 = "";
    public String s8Score31 = "";
    public String s8Score32 = "";
    public String s8Score33 = "";
    public String s8Score34 = "";
    public String s8Score35 = "";
    public String s8Score36 = "";
    public String s8Score37 = "";
    public String s8Score38 = "";
    public String s8Score39 = "";
    public String s8Score40 = "";
    public String s8Score41 = "";
    public String s8Score42 = "";
    public String s8Score43 = "";
    public String s8Score44 = "";
    public String s8Score45 = "";
    public String s8Score46 = "";
    public String s8Score47 = "";
    public String s8Score48 = "";
    public String s8Score49 = "";
    public String s8Score50 = "";
    public String s8Score51 = "";
    public String s8Score52 = "";
    public String s8Score53 = "";
    public String s8Score54 = "";
    public String s8Score55 = "";
    public String s8Score56 = "";
    public String s8Score57 = "";
    public String s8Score58 = "";
    public String s8Score59 = "";
    public String s8Score60 = "";

    [SerializeField] TextMeshProUGUI BWinner;

    public String WinnerString1;
    public String WinnerString2;
    public String WinnerString3;
    public String WinnerString4;
    public String WinnerString5;
    public String WinnerString6;
    public String WinnerString7;
    public String WinnerString8;

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

        for(int i = 0; i < realTankPlayers.Count; i++)
        {
            tankCopy.Add(realTankPlayers[i]);
        }
        for(int i = 0; i < dpsPlayers.Count; i++)
        {
            dpsCopy.Add(dpsPlayers[i]);
        }
        for(int i = 0; i < supportPlayers.Count; i++)
        {
            supportCopy.Add(supportPlayers[i]);
        }
        
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
        nextButton.SetActive(true);
        Franchising.SetActive(false);

        teamSheet.text = teamSheetText;
        fillTeams();
    }
    
    void Update()
    {
        if(timing)
        {
            timerText.text = $"Timer: {(int)timer+1}";
            timer+=Time.deltaTime;
            if(timer >= 5)
            {
                timing = false;
                timer = 0;
                scouting.SetActive(false);
                nextButton.SetActive(true);
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
            for(int i = 0; i < realTankPlayers.Count; i++)
            {
                if(realTankPlayers[i].ign == pSelect.ign)
                    realTankPlayers.Remove(realTankPlayers[i]);
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
            showTeam();
            showTeam();
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
            r = Random.Range(0, realTankPlayers.Count-1);
            currentPlayer = realTankPlayers[r];
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
            if (realTankPlayers.Count < 2 || dpsPlayers.Count < 2 || supportPlayers.Count < 2)
            {
                return;
            }

            rand = (int)Random.Range(0, realTankPlayers.Count);

            Player tank1 = realTankPlayers[rand];
            teamList[i].p1 = tank1;
            realTankPlayers.Remove(realTankPlayers[rand]);

            rand = (int)Random.Range(0, realTankPlayers.Count);

            Player tank2 = realTankPlayers[Random.Range(0,realTankPlayers.Count)];
            teamList[i].p2 = tank2;
            realTankPlayers.Remove(realTankPlayers[rand]);


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
                rand2 = Random.Range(0, realTankPlayers.Count);
                Player sub = realTankPlayers[rand2];
                teamList[i].p7 = sub;
                realTankPlayers.Remove(realTankPlayers[rand2]);
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
            if (realTankPlayers.Count < 2 || dpsPlayers.Count < 2 || supportPlayers.Count < 2)
            {
                return;
            }
            rand = (int)Random.Range(0, realTankPlayers.Count);

            Player tank1 = realTankPlayers[rand];
            teamsCopy4[i].p1 = tank1;
            realTankPlayers.Remove(realTankPlayers[rand]);

            rand = (int)Random.Range(0, realTankPlayers.Count);

            Player tank2 = realTankPlayers[Random.Range(0,realTankPlayers.Count)];
            teamsCopy4[i].p2 = tank2;
            realTankPlayers.Remove(realTankPlayers[rand]);


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
                rand2 = Random.Range(0, realTankPlayers.Count);
                Player sub = realTankPlayers[rand2];
                teamsCopy4[i].p7 = sub;
                realTankPlayers.Remove(realTankPlayers[rand2]);
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
                rand2 = Random.Range(0, realTankPlayers.Count);
                Player sub = realTankPlayers[rand2];
                teamsCopy4[i].p8 = sub;
                realTankPlayers.Remove(realTankPlayers[rand2]);
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
                rand2 = Random.Range(0, realTankPlayers.Count);
                Player sub = realTankPlayers[rand2];
                teamsCopy4[i].p9 = sub;
                realTankPlayers.Remove(realTankPlayers[rand2]);
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
        checkDupes();
        }
    }

    public void checkDupes()
    {
        List<Player> temp = new List<Player>();
        bool dupe = false;
        for(int i = 1; i < teamsCopy4.Length; i++)
        {
            for(int j = 0; j < 11; j++)
            {
                if(teamsCopy4[i].players[j] != nullPlayer)
                {
                    for(int k = 0; k < temp.Count; k++)
                    {
                        if(teamsCopy4[i].players[j].ign == temp[k].ign)
                        {
                            dupe = true;
                        }
                    }
                    if(!dupe)
                        temp.Add(teamsCopy4[i].players[j]);
                    else
                    {
                        teamsCopy4[i].players[j] = nullPlayer;
                        teamsCopy4[i].setPlayer(j, nullPlayer);
                        dupe = false;
                        if(j == 0)
                            teamsCopy4[i].p1 = nullPlayer;
                        else if(j == 1)
                            teamsCopy4[i].p2 = nullPlayer;
                        else if(j == 2)
                            teamsCopy4[i].p3 = nullPlayer;
                        else if(j == 3)
                            teamsCopy4[i].p4 = nullPlayer;
                        else if(j == 4)
                            teamsCopy4[i].p5 = nullPlayer;
                        else if(j == 5)
                            teamsCopy4[i].p6 = nullPlayer;
                        else if(j == 6)
                            teamsCopy4[i].p7 = nullPlayer;
                        else if(j == 7)
                            teamsCopy4[i].p8 = nullPlayer;
                        else if(j == 8)
                            teamsCopy4[i].p9 = nullPlayer;
                        else if(j == 9)
                            teamsCopy4[i].p10 = nullPlayer;
                        else if(j == 10)
                            teamsCopy4[i].p11 = nullPlayer;
                        else if(j == 11)
                            teamsCopy4[i].p12 = nullPlayer;
                    }
                }
                for(int h = 0; h < teamsCopy4.Length; h++)
                {
                    teamsCopy4[h].fillRoles();
                }
            }
        }
        
        refill();
        for(int i = 0; i < teamsCopy4.Length; i++)
        {
            recenter(teamsCopy4[i]);
        }
        postDupesFill();
        postDupesFill();
    }

    public void refill()
    {
        List<Player> tankTemp = new List<Player>();
        List<Player> dpsTemp = new List<Player>();
        List<Player> supportTemp = new List<Player>();

        for(int i = 0; i < teamsCopy4.Length; i++)
        {
            for(int j = 0; j < 11; j++)
            {
                if(teamsCopy4[i].players[j].role == "Tank")
                {
                    tankTemp.Add(teamsCopy4[i].players[j]);
                }
                else if(teamsCopy4[i].players[j].role == "DPS")
                {
                    dpsTemp.Add(teamsCopy4[i].players[j]);
                }
                else if(teamsCopy4[i].players[j].role == "Support")
                {
                    supportTemp.Add(teamsCopy4[i].players[j]);
                }
            }
        }

        realTankPlayers.Clear();
        dpsPlayers.Clear();
        supportPlayers.Clear();

       foreach (Player p in tankCopy)
       {
            if (!tankTemp.Contains(p))
                realTankPlayers.Add(p);
       }

       foreach (Player p in dpsCopy)
       {
            if (!dpsTemp.Contains(p))
                dpsPlayers.Add(p);
       }

       foreach (Player p in supportCopy)
       {
            if (!supportTemp.Contains(p))
                supportPlayers.Add(p);
       }
    }

    public void recenter(Team t)
    {
        Array.Sort(t.players, (a, b) => b.skill.CompareTo(a.skill));
        t.p1 = t.players[0];
        t.p2 = t.players[1];
        t.p3 = t.players[2];
        t.p4 = t.players[3];
        t.p5 = t.players[4];
        t.p6 = t.players[5];
        t.p7 = t.players[6];
        t.p8 = t.players[7];
        t.p9 = t.players[8];
        t.p10 = t.players[9];
        t.p11 = t.players[10];
        t.p12 = t.players[11];
        t.fillRoles();
    }


    public void postDupesFill()
    {
        int deeps = 0;
        int tankers = 0;
        int sups = 0;

        for(int i = 0; i < teamsCopy4.Length; i++)
        {
            deeps = teamsCopy4[i].getDPSCount();
            tankers = teamsCopy4[i].getTankCount();
            sups = teamsCopy4[i].getSupportCount();

            while(deeps < 3)
            {
                recenter(teamsCopy4[i]);
                currentPlayer = dpsPlayers[0];
                AddPlayerNPC(teamsCopy4[i]);
                recenter(teamsCopy4[i]);
                deeps++;
            }
            while(tankers < 3)
            {
                recenter(teamsCopy4[i]);
                currentPlayer = realTankPlayers[0];
                AddPlayerNPC(teamsCopy4[i]);
                recenter(teamsCopy4[i]);
                tankers++;
            }
            while(sups < 3)
            {
                recenter(teamsCopy4[i]);
                currentPlayer = supportPlayers[0];
                AddPlayerNPC(teamsCopy4[i]);
                recenter(teamsCopy4[i]);
                sups++;
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
                else if(sNumber == 4)
                {
                    mapWins1++;
                    if(!postSeason){
                        o1.mapwins4++;
                        o2.maploss4++;
                    }
                }
                else if(sNumber == 5)
                {
                    mapWins1++;
                    if(!postSeason){
                        o1.mapwins5++;
                        o2.maploss5++;
                    }
                }
                else if(sNumber == 6)
                {
                    mapWins1++;
                    if(!postSeason){
                        o1.mapwins6++;
                        o2.maploss6++;
                    }
                }
                else if(sNumber == 7)
                {
                    mapWins1++;
                    if(!postSeason){
                        o1.mapwins7++;
                        o2.maploss7++;
                    }
                }
                else if(sNumber == 8)
                {
                    mapWins1++;
                    if(!postSeason){
                        o1.mapwins8++;
                        o2.maploss8++;
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
                    if(Score1 == "")
                    {
                        Score1 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score2 == "")
                    {
                        Score2 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score3 == "")
                    {
                        Score3 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score4 == "")
                    {
                        Score4 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score5 == "")
                    {
                        Score5 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score6 == "")
                    {
                        Score6 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score7 == "")
                    {
                        Score7 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score8 == "")
                    {
                        Score8 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score9 == "")
                    {
                        Score9 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score10 == "")
                    {
                        Score10 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score11 == "")
                    {
                        Score11 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score12 == "")
                    {
                        Score12 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score13 == "")
                    {
                        Score13 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score14 == "")
                    {
                        Score14 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score15 == "")
                    {
                        Score15 = $"{mapWins1}-{mapWins2}";
                    }
                }
            }
            else if(sNumber == 2)
            {
                if(!postSeason){
                    o1.wins2++;
                    if(s2Score1 == "")
                    {
                        s2Score1 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s2Score2 == "")
                    {
                        s2Score2 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s2Score3 == "")
                    {
                        s2Score3 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s2Score4 == "")
                    {
                        s2Score4 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s2Score5 == "")
                    {
                        s2Score5 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s2Score6 == "")
                    {
                        s2Score6 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s2Score7 == "")
                    {
                        s2Score7 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s2Score8 == "")
                    {
                        s2Score8 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s2Score9 == "")
                    {
                        s2Score9 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s2Score10 == "")
                    {
                        s2Score10 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s2Score11 == "")
                    {
                        s2Score11 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s2Score12 == "")
                    {
                        s2Score12 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s2Score13 == "")
                    {
                        s2Score13 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s2Score14 == "")
                    {
                        s2Score14 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s2Score15 == "")
                    {
                        s2Score15 = $"{mapWins1}-{mapWins2}";
                    }
                }
            }
            else if(sNumber == 3)
            {
                if(!postSeason){
                    o1.wins3++;
                    if(s3Score1 == "")
                    {
                        s3Score1 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s3Score2 == "")
                    {
                        s3Score2 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s3Score3 == "")
                    {
                        s3Score3 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s3Score4 == "")
                    {
                        s3Score4 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s3Score5 == "")
                    {
                        s3Score5 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s3Score6 == "")
                    {
                        s3Score6 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s3Score7 == "")
                    {
                        s3Score7 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s3Score8 == "")
                    {
                        s3Score8 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s3Score9 == "")
                    {
                        s3Score9 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s3Score10 == "")
                    {
                        s3Score10 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s3Score11 == "")
                    {
                        s3Score11 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s3Score12 == "")
                    {
                        s3Score12 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s3Score13 == "")
                    {
                        s3Score13 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s3Score14 == "")
                    {
                        s3Score14 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s3Score15 == "")
                    {
                        s3Score15 = $"{mapWins1}-{mapWins2}";
                    }
                }
            }
            else if(sNumber == 4)
            {
                if(!postSeason){
                    o1.wins4++;
                    if(Score16 == "")
                    {
                        Score16 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score17 == "")
                    {
                        Score17 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score18 == "")
                    {
                        Score18 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score19 == "")
                    {
                        Score19 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score20 == "")
                    {
                        Score20 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score21 == "")
                    {
                        Score21 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score22 == "")
                    {
                        Score22 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score23 == "")
                    {
                        Score23 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score24 == "")
                    {
                        Score24 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score25 == "")
                    {
                        Score25 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score26 == "")
                    {
                        Score26 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score27 == "")
                    {
                        Score27 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score28 == "")
                    {
                        Score28 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score29 == "")
                    {
                        Score29 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score30 == "")
                    {
                        Score30 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score31 == "")
                    {
                        Score31 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score32 == "")
                    {
                        Score32 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score33 == "")
                    {
                        Score33 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score34 == "")
                    {
                        Score34 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score35 == "")
                    {
                        Score35 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score36 == "")
                    {
                        Score36 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score37 == "")
                    {
                        Score37 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score38 == "")
                    {
                        Score38= $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score39 == "")
                    {
                        Score39 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score40 == "")
                    {
                        Score40 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score41 == "")
                    {
                        Score41 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score42 == "")
                    {
                        Score42 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score43 == "")
                    {
                        Score43 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score44 == "")
                    {
                        Score44 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score45 == "")
                    {
                        Score45 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score46 == "")
                    {
                        Score46 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score47 == "")
                    {
                        Score47 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score48 == "")
                    {
                        Score48 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score49 == "")
                    {
                        Score49 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score50 == "")
                    {
                        Score50 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score51 == "")
                    {
                        Score51 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score52 == "")
                    {
                        Score52 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score53 == "")
                    {
                        Score53 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score54 == "")
                    {
                        Score54 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score55 == "")
                    {
                        Score55 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score56 == "")
                    {
                        Score56 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score57 == "")
                    {
                        Score57 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score58 == "")
                    {
                        Score58 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score59 == "")
                    {
                        Score59 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score60 == "")
                    {
                        Score60 = $"{mapWins1}-{mapWins2}";
                    }
                }
            }
            else if(sNumber == 5)
            {
                if(!postSeason){
                    o1.wins5++;
                    if(s5Score16 == "")
                    {
                        s5Score16 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score17 == "")
                    {
                        s5Score17 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score18 == "")
                    {
                        s5Score18 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score19 == "")
                    {
                        s5Score19 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score20 == "")
                    {
                        s5Score20 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score21 == "")
                    {
                        s5Score21 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score22 == "")
                    {
                        s5Score22 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score23 == "")
                    {
                        s5Score23 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score24 == "")
                    {
                        s5Score24 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score25 == "")
                    {
                        s5Score25 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score26 == "")
                    {
                        s5Score26 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score27 == "")
                    {
                        s5Score27 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score28 == "")
                    {
                        s5Score28 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score29 == "")
                    {
                        s5Score29 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score30 == "")
                    {
                        s5Score30 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score31 == "")
                    {
                        s5Score31 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score32 == "")
                    {
                        s5Score32 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score33 == "")
                    {
                        s5Score33 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score34 == "")
                    {
                        s5Score34 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score35 == "")
                    {
                        s5Score35 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score36 == "")
                    {
                        s5Score36 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score37 == "")
                    {
                        s5Score37 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score38 == "")
                    {
                        s5Score38= $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score39 == "")
                    {
                        s5Score39 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score40 == "")
                    {
                        s5Score40 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score41 == "")
                    {
                        s5Score41 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score42 == "")
                    {
                        s5Score42 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score43 == "")
                    {
                        s5Score43 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score44 == "")
                    {
                        s5Score44 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score45 == "")
                    {
                        s5Score45 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score46 == "")
                    {
                        s5Score46 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score47 == "")
                    {
                        s5Score47 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score48 == "")
                    {
                        s5Score48 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score49 == "")
                    {
                        s5Score49 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score50 == "")
                    {
                        s5Score50 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score51 == "")
                    {
                        s5Score51 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score52 == "")
                    {
                        s5Score52 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score53 == "")
                    {
                        s5Score53 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score54 == "")
                    {
                        s5Score54 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score55 == "")
                    {
                        s5Score55 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score56 == "")
                    {
                        s5Score56 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score57 == "")
                    {
                        s5Score57 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score58 == "")
                    {
                        s5Score58 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score59 == "")
                    {
                        s5Score59 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score60 == "")
                    {
                        s5Score60 = $"{mapWins1}-{mapWins2}";
                    }
                }
            }
            else if(sNumber == 6)
            {
                if(!postSeason){
                    o1.wins6++;
                    if(s6Score16 == "")
                    {
                        s6Score16 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score17 == "")
                    {
                        s6Score17 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score18 == "")
                    {
                        s6Score18 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score19 == "")
                    {
                        s6Score19 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score20 == "")
                    {
                        s6Score20 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score21 == "")
                    {
                        s6Score21 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score22 == "")
                    {
                        s6Score22 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score23 == "")
                    {
                        s6Score23 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score24 == "")
                    {
                        s6Score24 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score25 == "")
                    {
                        s6Score25 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score26 == "")
                    {
                        s6Score26 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score27 == "")
                    {
                        s6Score27 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score28 == "")
                    {
                        s6Score28 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score29 == "")
                    {
                        s6Score29 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score30 == "")
                    {
                        s6Score30 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score31 == "")
                    {
                        s6Score31 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score32 == "")
                    {
                        s6Score32 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score33 == "")
                    {
                        s6Score33 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score34 == "")
                    {
                        s6Score34 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score35 == "")
                    {
                        s6Score35 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score36 == "")
                    {
                        s6Score36 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score37 == "")
                    {
                        s6Score37 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score38 == "")
                    {
                        s6Score38= $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score39 == "")
                    {
                        s6Score39 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score40 == "")
                    {
                        s6Score40 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score41 == "")
                    {
                        s6Score41 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score42 == "")
                    {
                        s6Score42 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score43 == "")
                    {
                        s6Score43 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score44 == "")
                    {
                        s6Score44 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score45 == "")
                    {
                        s6Score45 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score46 == "")
                    {
                        s6Score46 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score47 == "")
                    {
                        s6Score47 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score48 == "")
                    {
                        s6Score48 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score49 == "")
                    {
                        s6Score49 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score50 == "")
                    {
                        s6Score50 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score51 == "")
                    {
                        s6Score51 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score52 == "")
                    {
                        s6Score52 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score53 == "")
                    {
                        s6Score53 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score54 == "")
                    {
                        s6Score54 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score55 == "")
                    {
                        s6Score55 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score56 == "")
                    {
                        s6Score56 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score57 == "")
                    {
                        s6Score57 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score58 == "")
                    {
                        s6Score58 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score59 == "")
                    {
                        s6Score59 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score60 == "")
                    {
                        s6Score60 = $"{mapWins1}-{mapWins2}";
                    }
                }
            }
            else if(sNumber == 7)
            {
                if(!postSeason){
                    o1.wins7++;
                    if(s7Score16 == "")
                    {
                        s7Score16 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score17 == "")
                    {
                        s7Score17 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score18 == "")
                    {
                        s7Score18 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score19 == "")
                    {
                        s7Score19 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score20 == "")
                    {
                        s7Score20 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score21 == "")
                    {
                        s7Score21 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score22 == "")
                    {
                        s7Score22 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score23 == "")
                    {
                        s7Score23 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score24 == "")
                    {
                        s7Score24 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score25 == "")
                    {
                        s7Score25 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score26 == "")
                    {
                        s7Score26 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score27 == "")
                    {
                        s7Score27 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score28 == "")
                    {
                        s7Score28 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score29 == "")
                    {
                        s7Score29 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score30 == "")
                    {
                        s7Score30 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score31 == "")
                    {
                        s7Score31 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score32 == "")
                    {
                        s7Score32 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score33 == "")
                    {
                        s7Score33 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score34 == "")
                    {
                        s7Score34 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score35 == "")
                    {
                        s7Score35 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score36 == "")
                    {
                        s7Score36 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score37 == "")
                    {
                        s7Score37 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score38 == "")
                    {
                        s7Score38= $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score39 == "")
                    {
                        s7Score39 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score40 == "")
                    {
                        s7Score40 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score41 == "")
                    {
                        s7Score41 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score42 == "")
                    {
                        s7Score42 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score43 == "")
                    {
                        s7Score43 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score44 == "")
                    {
                        s7Score44 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score45 == "")
                    {
                        s7Score45 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score46 == "")
                    {
                        s7Score46 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score47 == "")
                    {
                        s7Score47 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score48 == "")
                    {
                        s7Score48 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score49 == "")
                    {
                        s7Score49 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score50 == "")
                    {
                        s7Score50 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score51 == "")
                    {
                        s7Score51 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score52 == "")
                    {
                        s7Score52 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score53 == "")
                    {
                        s7Score53 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score54 == "")
                    {
                        s7Score54 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score55 == "")
                    {
                        s7Score55 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score56 == "")
                    {
                        s7Score56 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score57 == "")
                    {
                        s7Score57 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score58 == "")
                    {
                        s7Score58 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score59 == "")
                    {
                        s7Score59 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score60 == "")
                    {
                        s7Score60 = $"{mapWins1}-{mapWins2}";
                    }
                }
            }
            else if(sNumber == 8)
            {
                if(!postSeason){
                    o1.wins8++;
                    if(s8Score16 == "")
                    {
                        s8Score16 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score17 == "")
                    {
                        s8Score17 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score18 == "")
                    {
                        s8Score18 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score19 == "")
                    {
                        s8Score19 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score20 == "")
                    {
                        s8Score20 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score21 == "")
                    {
                        s8Score21 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score22 == "")
                    {
                        s8Score22 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score23 == "")
                    {
                        s8Score23 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score24 == "")
                    {
                        s8Score24 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score25 == "")
                    {
                        s8Score25 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score26 == "")
                    {
                        s8Score26 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score27 == "")
                    {
                        s8Score27 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score28 == "")
                    {
                        s8Score28 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score29 == "")
                    {
                        s8Score29 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score30 == "")
                    {
                        s8Score30 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score31 == "")
                    {
                        s8Score31 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score32 == "")
                    {
                        s8Score32 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score33 == "")
                    {
                        s8Score33 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score34 == "")
                    {
                        s8Score34 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score35 == "")
                    {
                        s8Score35 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score36 == "")
                    {
                        s8Score36 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score37 == "")
                    {
                        s8Score37 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score38 == "")
                    {
                        s8Score38= $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score39 == "")
                    {
                        s8Score39 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score40 == "")
                    {
                        s8Score40 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score41 == "")
                    {
                        s8Score41 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score42 == "")
                    {
                        s8Score42 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score43 == "")
                    {
                        s8Score43 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score44 == "")
                    {
                        s8Score44 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score45 == "")
                    {
                        s8Score45 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score46 == "")
                    {
                        s8Score46 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score47 == "")
                    {
                        s8Score47 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score48 == "")
                    {
                        s8Score48 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score49 == "")
                    {
                        s8Score49 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score50 == "")
                    {
                        s8Score50 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score51 == "")
                    {
                        s8Score51 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score52 == "")
                    {
                        s8Score52 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score53 == "")
                    {
                        s8Score53 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score54 == "")
                    {
                        s8Score54 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score55 == "")
                    {
                        s8Score55 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score56 == "")
                    {
                        s8Score56 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score57 == "")
                    {
                        s8Score57 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score58 == "")
                    {
                        s8Score58 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score59 == "")
                    {
                        s8Score59 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score60 == "")
                    {
                        s8Score60 = $"{mapWins1}-{mapWins2}";
                    }
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
                    if(Score1 == "")
                    {
                        Score1 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score2 == "")
                    {
                        Score2 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score3 == "")
                    {
                        Score3 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score4 == "")
                    {
                        Score4 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score5 == "")
                    {
                        Score5 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score6 == "")
                    {
                        Score6 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score7 == "")
                    {
                        Score7 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score8 == "")
                    {
                        Score8 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score9 == "")
                    {
                        Score9 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score10 == "")
                    {
                        Score10 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score11 == "")
                    {
                        Score11 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score12 == "")
                    {
                        Score12 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score13 == "")
                    {
                        Score13 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score14 == "")
                    {
                        Score14 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score15 == "")
                    {
                        Score15 = $"{mapWins1}-{mapWins2}";
                    }
                }
            }
            else if(sNumber == 2)
            {
                if(!postSeason){
                    o2.wins2++;
                    if(s2Score1 == "")
                    {
                        s2Score1 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s2Score2 == "")
                    {
                        s2Score2 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s2Score3 == "")
                    {
                        s2Score3 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s2Score4 == "")
                    {
                        s2Score4 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s2Score5 == "")
                    {
                        s2Score5 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s2Score6 == "")
                    {
                        s2Score6 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s2Score7 == "")
                    {
                        s2Score7 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s2Score8 == "")
                    {
                        s2Score8 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s2Score9 == "")
                    {
                        s2Score9 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s2Score10 == "")
                    {
                        s2Score10 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s2Score11 == "")
                    {
                        s2Score11 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s2Score12 == "")
                    {
                        s2Score12 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s2Score13 == "")
                    {
                        s2Score13 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s2Score14 == "")
                    {
                        s2Score14 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s2Score15 == "")
                    {
                        s2Score15 = $"{mapWins1}-{mapWins2}";
                    }
                }
            }
            else if(sNumber == 3)
            {
                if(!postSeason){
                    o2.wins3++;
                    if(s3Score1 == "")
                    {
                        s3Score1 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s3Score2 == "")
                    {
                        s3Score2 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s3Score3 == "")
                    {
                        s3Score3 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s3Score4 == "")
                    {
                        s3Score4 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s3Score5 == "")
                    {
                        s3Score5 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s3Score6 == "")
                    {
                        s3Score6 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s3Score7 == "")
                    {
                        s3Score7 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s3Score8 == "")
                    {
                        s3Score8 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s3Score9 == "")
                    {
                        s3Score9 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s3Score10 == "")
                    {
                        s3Score10 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s3Score11 == "")
                    {
                        s3Score11 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s3Score12 == "")
                    {
                        s3Score12 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s3Score13 == "")
                    {
                        s3Score13 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s3Score14 == "")
                    {
                        s3Score14 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s3Score15 == "")
                    {
                        s3Score15 = $"{mapWins1}-{mapWins2}";
                    }
                }
            }
            else if(sNumber == 4)
            {
                if(!postSeason){
                    o2.wins4++;
                    if(Score16 == "")
                    {
                        Score16 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score17 == "")
                    {
                        Score17 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score18 == "")
                    {
                        Score18 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score19 == "")
                    {
                        Score19 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score20 == "")
                    {
                        Score20 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score21 == "")
                    {
                        Score21 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score22 == "")
                    {
                        Score22 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score23 == "")
                    {
                        Score23 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score24 == "")
                    {
                        Score24 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score25 == "")
                    {
                        Score25 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score26 == "")
                    {
                        Score26 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score27 == "")
                    {
                        Score28 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score29 == "")
                    {
                        Score29 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score30 == "")
                    {
                        Score30 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score31 == "")
                    {
                        Score31 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score32 == "")
                    {
                        Score32 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score33 == "")
                    {
                        Score33 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score34 == "")
                    {
                        Score34 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score35 == "")
                    {
                        Score35 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score36 == "")
                    {
                        Score36 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score37 == "")
                    {
                        Score37 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score38 == "")
                    {
                        Score38= $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score39 == "")
                    {
                        Score39 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score40 == "")
                    {
                        Score40 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score41 == "")
                    {
                        Score41 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score42 == "")
                    {
                        Score42 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score43 == "")
                    {
                        Score43 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score44 == "")
                    {
                        Score44 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score45 == "")
                    {
                        Score45 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score46 == "")
                    {
                        Score46 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score47 == "")
                    {
                        Score47 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score48 == "")
                    {
                        Score48 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score49 == "")
                    {
                        Score49 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score50 == "")
                    {
                        Score50 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score51 == "")
                    {
                        Score51 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score52 == "")
                    {
                        Score52 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score53 == "")
                    {
                        Score53 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score54 == "")
                    {
                        Score54 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score55 == "")
                    {
                        Score55 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score56 == "")
                    {
                        Score56 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score57 == "")
                    {
                        Score57 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score58 == "")
                    {
                        Score58 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score59 == "")
                    {
                        Score59 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(Score60 == "")
                    {
                        Score60 = $"{mapWins1}-{mapWins2}";
                    }
                }
            }
            else if(sNumber == 5)
            {
                if(!postSeason){
                    o2.wins5++;
                    if(s5Score16 == "")
                    {
                        s5Score16 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score17 == "")
                    {
                        s5Score17 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score18 == "")
                    {
                        s5Score18 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score19 == "")
                    {
                        s5Score19 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score20 == "")
                    {
                        s5Score20 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score21 == "")
                    {
                        s5Score21 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score22 == "")
                    {
                        s5Score22 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score23 == "")
                    {
                        s5Score23 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score24 == "")
                    {
                        s5Score24 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score25 == "")
                    {
                        s5Score25 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score26 == "")
                    {
                        s5Score26 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score27 == "")
                    {
                        s5Score28 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score29 == "")
                    {
                        s5Score29 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score30 == "")
                    {
                        s5Score30 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score31 == "")
                    {
                        s5Score31 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score32 == "")
                    {
                        s5Score32 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score33 == "")
                    {
                        s5Score33 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score34 == "")
                    {
                        s5Score34 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score35 == "")
                    {
                        s5Score35 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score36 == "")
                    {
                        s5Score36 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score37 == "")
                    {
                        s5Score37 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score38 == "")
                    {
                        s5Score38= $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score39 == "")
                    {
                        s5Score39 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score40 == "")
                    {
                        s5Score40 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score41 == "")
                    {
                        s5Score41 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score42 == "")
                    {
                        s5Score42 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score43 == "")
                    {
                        s5Score43 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score44 == "")
                    {
                        s5Score44 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score45 == "")
                    {
                        s5Score45 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score46 == "")
                    {
                        s5Score46 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score47 == "")
                    {
                        s5Score47 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score48 == "")
                    {
                        s5Score48 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score49 == "")
                    {
                        s5Score49 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score50 == "")
                    {
                        s5Score50 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score51 == "")
                    {
                        s5Score51 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score52 == "")
                    {
                        s5Score52 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score53 == "")
                    {
                        s5Score53 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score54 == "")
                    {
                        s5Score54 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score55 == "")
                    {
                        s5Score55 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score56 == "")
                    {
                        s5Score56 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score57 == "")
                    {
                        s5Score57 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score58 == "")
                    {
                        s5Score58 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score59 == "")
                    {
                        s5Score59 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s5Score60 == "")
                    {
                        s5Score60 = $"{mapWins1}-{mapWins2}";
                    }
                }
            }
            else if(sNumber == 6)
            {
                if(!postSeason){
                    o2.wins6++;
                    if(s6Score16 == "")
                    {
                        s6Score16 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score17 == "")
                    {
                        s6Score17 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score18 == "")
                    {
                        s6Score18 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score19 == "")
                    {
                        s6Score19 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score20 == "")
                    {
                        s6Score20 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score21 == "")
                    {
                        s6Score21 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score22 == "")
                    {
                        s6Score22 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score23 == "")
                    {
                        s6Score23 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score24 == "")
                    {
                        s6Score24 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score25 == "")
                    {
                        s6Score25 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score26 == "")
                    {
                        s6Score26 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score27 == "")
                    {
                        s6Score28 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score29 == "")
                    {
                        s6Score29 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score30 == "")
                    {
                        s6Score30 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score31 == "")
                    {
                        s6Score31 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score32 == "")
                    {
                        s6Score32 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score33 == "")
                    {
                        s6Score33 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score34 == "")
                    {
                        s6Score34 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score35 == "")
                    {
                        s6Score35 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score36 == "")
                    {
                        s6Score36 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score37 == "")
                    {
                        s6Score37 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score38 == "")
                    {
                        s6Score38= $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score39 == "")
                    {
                        s6Score39 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score40 == "")
                    {
                        s6Score40 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score41 == "")
                    {
                        s6Score41 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score42 == "")
                    {
                        s6Score42 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score43 == "")
                    {
                        s6Score43 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score44 == "")
                    {
                        s6Score44 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score45 == "")
                    {
                        s6Score45 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score46 == "")
                    {
                        s6Score46 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score47 == "")
                    {
                        s6Score47 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score48 == "")
                    {
                        s6Score48 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score49 == "")
                    {
                        s6Score49 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score50 == "")
                    {
                        s6Score50 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score51 == "")
                    {
                        s6Score51 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score52 == "")
                    {
                        s6Score52 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score53 == "")
                    {
                        s6Score53 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score54 == "")
                    {
                        s6Score54 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score55 == "")
                    {
                        s6Score55 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score56 == "")
                    {
                        s6Score56 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score57 == "")
                    {
                        s6Score57 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score58 == "")
                    {
                        s6Score58 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score59 == "")
                    {
                        s6Score59 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s6Score60 == "")
                    {
                        s6Score60 = $"{mapWins1}-{mapWins2}";
                    }
                }
            }
            else if(sNumber == 7)
            {
                if(!postSeason){
                    o2.wins7++;
                    if(s7Score16 == "")
                    {
                        s7Score16 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score17 == "")
                    {
                        s7Score17 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score18 == "")
                    {
                        s7Score18 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score19 == "")
                    {
                        s7Score19 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score20 == "")
                    {
                        s7Score20 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score21 == "")
                    {
                        s7Score21 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score22 == "")
                    {
                        s7Score22 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score23 == "")
                    {
                        s7Score23 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score24 == "")
                    {
                        s7Score24 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score25 == "")
                    {
                        s7Score25 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score26 == "")
                    {
                        s7Score26 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score27 == "")
                    {
                        s7Score28 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score29 == "")
                    {
                        s7Score29 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score30 == "")
                    {
                        s7Score30 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score31 == "")
                    {
                        s7Score31 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score32 == "")
                    {
                        s7Score32 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score33 == "")
                    {
                        s7Score33 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score34 == "")
                    {
                        s7Score34 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score35 == "")
                    {
                        s7Score35 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score36 == "")
                    {
                        s7Score36 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score37 == "")
                    {
                        s7Score37 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score38 == "")
                    {
                        s7Score38= $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score39 == "")
                    {
                        s7Score39 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score40 == "")
                    {
                        s7Score40 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score41 == "")
                    {
                        s7Score41 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score42 == "")
                    {
                        s7Score42 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score43 == "")
                    {
                        s7Score43 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score44 == "")
                    {
                        s7Score44 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score45 == "")
                    {
                        s7Score45 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score46 == "")
                    {
                        s7Score46 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score47 == "")
                    {
                        s7Score47 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score48 == "")
                    {
                        s7Score48 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score49 == "")
                    {
                        s7Score49 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score50 == "")
                    {
                        s7Score50 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score51 == "")
                    {
                        s7Score51 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score52 == "")
                    {
                        s7Score52 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score53 == "")
                    {
                        s7Score53 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score54 == "")
                    {
                        s7Score54 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score55 == "")
                    {
                        s7Score55 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score56 == "")
                    {
                        s7Score56 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score57 == "")
                    {
                        s7Score57 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score58 == "")
                    {
                        s7Score58 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score59 == "")
                    {
                        s7Score59 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s7Score60 == "")
                    {
                        s7Score60 = $"{mapWins1}-{mapWins2}";
                    }
                }
            }
            else if(sNumber == 8)
            {
                if(!postSeason){
                    o2.wins8++;
                    if(s8Score16 == "")
                    {
                        s8Score16 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score17 == "")
                    {
                        s8Score17 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score18 == "")
                    {
                        s8Score18 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score19 == "")
                    {
                        s8Score19 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score20 == "")
                    {
                        s8Score20 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score21 == "")
                    {
                        s8Score21 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score22 == "")
                    {
                        s8Score22 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score23 == "")
                    {
                        s8Score23 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score24 == "")
                    {
                        s8Score24 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score25 == "")
                    {
                        s8Score25 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score26 == "")
                    {
                        s8Score26 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score27 == "")
                    {
                        s8Score28 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score29 == "")
                    {
                        s8Score29 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score30 == "")
                    {
                        s8Score30 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score31 == "")
                    {
                        s8Score31 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score32 == "")
                    {
                        s8Score32 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score33 == "")
                    {
                        s8Score33 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score34 == "")
                    {
                        s8Score34 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score35 == "")
                    {
                        s8Score35 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score36 == "")
                    {
                        s8Score36 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score37 == "")
                    {
                        s8Score37 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score38 == "")
                    {
                        s8Score38= $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score39 == "")
                    {
                        s8Score39 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score40 == "")
                    {
                        s8Score40 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score41 == "")
                    {
                        s8Score41 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score42 == "")
                    {
                        s8Score42 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score43 == "")
                    {
                        s8Score43 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score44 == "")
                    {
                        s8Score44 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score45 == "")
                    {
                        s8Score45 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score46 == "")
                    {
                        s8Score46 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score47 == "")
                    {
                        s8Score47 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score48 == "")
                    {
                        s8Score48 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score49 == "")
                    {
                        s8Score49 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score50 == "")
                    {
                        s8Score50 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score51 == "")
                    {
                        s8Score51 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score52 == "")
                    {
                        s8Score52 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score53 == "")
                    {
                        s8Score53 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score54 == "")
                    {
                        s8Score54 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score55 == "")
                    {
                        s8Score55 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score56 == "")
                    {
                        s8Score56 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score57 == "")
                    {
                        s8Score57 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score58 == "")
                    {
                        s8Score58 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score59 == "")
                    {
                        s8Score59 = $"{mapWins1}-{mapWins2}";
                    }
                    else if(s8Score60 == "")
                    {
                        s8Score60 = $"{mapWins1}-{mapWins2}";
                    }
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
        else if(sNumber == 5)
        {
            System.Array.Sort(teamsCopy5, (a, b) =>
            {
                int winCompare = b.wins5.CompareTo(a.wins5);
                if (winCompare != 0)
                    return winCompare;

                int mapWinCompare = b.mapwins5.CompareTo(a.mapwins5);
                if (mapWinCompare != 0)
                    return mapWinCompare;

                return a.maploss5.CompareTo(b.maploss5);
            });

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < teamsCopy5.Length; i++)
            {
                Team t = teamsCopy5[i];
                int rank = i + 1;
                sb.AppendLine($"{rank}. {t.brand}: {t.wins5}W ({t.mapwins5}/{t.maploss5})");
            }
            standings.text = sb.ToString();
        }
        else if(sNumber == 6)
        {
            System.Array.Sort(teamsCopy6, (a, b) =>
            {
                int winCompare = b.wins6.CompareTo(a.wins6);
                if (winCompare != 0)
                    return winCompare;

                int mapWinCompare = b.mapwins6.CompareTo(a.mapwins6);
                if (mapWinCompare != 0)
                    return mapWinCompare;

                return a.maploss6.CompareTo(b.maploss6);
            });

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < teamsCopy6.Length; i++)
            {
                Team t = teamsCopy6[i];
                int rank = i + 1;
                sb.AppendLine($"{rank}. {t.brand}: {t.wins6}W ({t.mapwins6}/{t.maploss6})");
            }
            standings.text = sb.ToString();
        }
        else if(sNumber == 7)
        {
            System.Array.Sort(teamsCopy7, (a, b) =>
            {
                int winCompare = b.wins7.CompareTo(a.wins7);
                if (winCompare != 0)
                    return winCompare;

                int mapWinCompare = b.mapwins7.CompareTo(a.mapwins7);
                if (mapWinCompare != 0)
                    return mapWinCompare;

                return a.maploss7.CompareTo(b.maploss7);
            });

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < teamsCopy7.Length; i++)
            {
                Team t = teamsCopy7[i];
                int rank = i + 1;
                sb.AppendLine($"{rank}. {t.brand}: {t.wins7}W ({t.mapwins7}/{t.maploss7})");
            }
            standings.text = sb.ToString();
        }
        else if(sNumber == 8)
        {
            System.Array.Sort(teamsCopy8, (a, b) =>
            {
                int winCompare = b.wins8.CompareTo(a.wins8);
                if (winCompare != 0)
                    return winCompare;

                int mapWinCompare = b.mapwins8.CompareTo(a.mapwins8);
                if (mapWinCompare != 0)
                    return mapWinCompare;

                return a.maploss8.CompareTo(b.maploss8);
            });

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < teamsCopy8.Length; i++)
            {
                Team t = teamsCopy8[i];
                int rank = i + 1;
                sb.AppendLine($"{rank}. {t.brand}: {t.wins8}W ({t.mapwins8}/{t.maploss8})");
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

    public void seeS1()
    {
        score1.text = Score1;
        score2.text = Score2;
        score3.text = Score3;
        score4.text = Score4;
        score5.text = Score5;
        score6.text = Score6;
        score7.text = Score7;
        score8.text = Score8;
        score9.text = Score9;
        score10.text = Score10;
        score11.text = Score11;
        score12.text = Score12;
        score13.text = Score13;
        score14.text = Score14;
        score15.text = Score15;

        BWinner.text = WinnerString1;
    }

    public void seeS2()
    {
        score1.text = s2Score1;
        score2.text = s2Score2;
        score3.text = s2Score3;
        score4.text = s2Score4;
        score5.text = s2Score5;
        score6.text = s2Score6;
        score7.text = s2Score7;
        score8.text = s2Score8;
        score9.text = s2Score9;
        score10.text = s2Score10;
        score11.text = s2Score11;
        score12.text = s2Score12;
        score13.text = s2Score13;
        score14.text = s2Score14;
        score15.text = s2Score15;

        BWinner.text = WinnerString2;
    }

    public void seeS3()
    {
        score1.text = s3Score1;
        score2.text = s3Score2;
        score3.text = s3Score3;
        score4.text = s3Score4;
        score5.text = s3Score5;
        score6.text = s3Score6;
        score7.text = s3Score7;
        score8.text = s3Score8;
        score9.text = s3Score9;
        score10.text = s3Score10;
        score11.text = s3Score11;
        score12.text = s3Score12;
        score13.text = s3Score13;
        score14.text = s3Score14;
        score15.text = s3Score15;

        BWinner.text = WinnerString3;
    }

    public void seeS4()
    {
        score16.text = Score16;
        score17.text = Score17;
        score18.text = Score18;
        score19.text = Score19;
        score20.text = Score20;
        score21.text = Score21;
        score22.text = Score22;
        score23.text = Score23;
        score24.text = Score24;
        score25.text = Score25;
        score26.text = Score26;
        score27.text = Score27;
        score28.text = Score28;
        score29.text = Score29;
        score30.text = Score30;
        score31.text = Score31;
        score32.text = Score32;
        score33.text = Score33;
        score34.text = Score34;
        score35.text = Score35;
        score36.text = Score36;
        score37.text = Score37;
        score38.text = Score38;
        score39.text = Score39;
        score40.text = Score40;
        score41.text = Score41;
        score42.text = Score42;
        score43.text = Score43;
        score44.text = Score44;
        score45.text = Score45;
        score46.text = Score46;
        score47.text = Score47;
        score48.text = Score48;
        score49.text = Score49;
        score50.text = Score50;
        score51.text = Score51;
        score52.text = Score52;
        score53.text = Score53;
        score54.text = Score54;
        score55.text = Score55;
        score56.text = Score56;
        score57.text = Score57;
        score58.text = Score58;
        score59.text = Score59;
        score60.text = Score60;

        BWinner.text = WinnerString4;
    }

    public void seeS5()
    {
        score16.text = s5Score16;
        score17.text = s5Score17;
        score18.text = s5Score18;
        score19.text = s5Score19;
        score20.text = s5Score20;
        score21.text = s5Score21;
        score22.text = s5Score22;
        score23.text = s5Score23;
        score24.text = s5Score24;
        score25.text = s5Score25;
        score26.text = s5Score26;
        score27.text = s5Score27;
        score28.text = s5Score28;
        score29.text = s5Score29;
        score30.text = s5Score30;
        score31.text = s5Score31;
        score32.text = s5Score32;
        score33.text = s5Score33;
        score34.text = s5Score34;
        score35.text = s5Score35;
        score36.text = s5Score36;
        score37.text = s5Score37;
        score38.text = s5Score38;
        score39.text = s5Score39;
        score40.text = s5Score40;
        score41.text = s5Score41;
        score42.text = s5Score42;
        score43.text = s5Score43;
        score44.text = s5Score44;
        score45.text = s5Score45;
        score46.text = s5Score46;
        score47.text = s5Score47;
        score48.text = s5Score48;
        score49.text = s5Score49;
        score50.text = s5Score50;
        score51.text = s5Score51;
        score52.text = s5Score52;
        score53.text = s5Score53;
        score54.text = s5Score54;
        score55.text = s5Score55;
        score56.text = s5Score56;
        score57.text = s5Score57;
        score58.text = s5Score58;
        score59.text = s5Score59;
        score60.text = s5Score60;
        BWinner.text = WinnerString5;
    }

    public void seeS6()
    {
        score16.text = s6Score16;
        score17.text = s6Score17;
        score18.text = s6Score18;
        score19.text = s6Score19;
        score20.text = s6Score20;
        score21.text = s6Score21;
        score22.text = s6Score22;
        score23.text = s6Score23;
        score24.text = s6Score24;
        score25.text = s6Score25;
        score26.text = s6Score26;
        score27.text = s6Score27;
        score28.text = s6Score28;
        score29.text = s6Score29;
        score30.text = s6Score30;
        score31.text = s6Score31;
        score32.text = s6Score32;
        score33.text = s6Score33;
        score34.text = s6Score34;
        score35.text = s6Score35;
        score36.text = s6Score36;
        score37.text = s6Score37;
        score38.text = s6Score38;
        score39.text = s6Score39;
        score40.text = s6Score40;
        score41.text = s6Score41;
        score42.text = s6Score42;
        score43.text = s6Score43;
        score44.text = s6Score44;
        score45.text = s6Score45;
        score46.text = s6Score46;
        score47.text = s6Score47;
        score48.text = s6Score48;
        score49.text = s6Score49;
        score50.text = s6Score50;
        score51.text = s6Score51;
        score52.text = s6Score52;
        score53.text = s6Score53;
        score54.text = s6Score54;
        score55.text = s6Score55;
        score56.text = s6Score56;
        score57.text = s6Score57;
        score58.text = s6Score58;
        score59.text = s6Score59;
        score60.text = s6Score60;

        BWinner.text = WinnerString6;
    }

    public void seeS7()
    {
        score16.text = s7Score16;
        score17.text = s7Score17;
        score18.text = s7Score18;
        score19.text = s7Score19;
        score20.text = s7Score20;
        score21.text = s7Score21;
        score22.text = s7Score22;
        score23.text = s7Score23;
        score24.text = s7Score24;
        score25.text = s7Score25;
        score26.text = s7Score26;
        score27.text = s7Score27;
        score28.text = s7Score28;
        score29.text = s7Score29;
        score30.text = s7Score30;
        score31.text = s7Score31;
        score32.text = s7Score32;
        score33.text = s7Score33;
        score34.text = s7Score34;
        score35.text = s7Score35;
        score36.text = s7Score36;
        score37.text = s7Score37;
        score38.text = s7Score38;
        score39.text = s7Score39;
        score40.text = s7Score40;
        score41.text = s7Score41;
        score42.text = s7Score42;
        score43.text = s7Score43;
        score44.text = s7Score44;
        score45.text = s7Score45;
        score46.text = s7Score46;
        score47.text = s7Score47;
        score48.text = s7Score48;
        score49.text = s7Score49;
        score50.text = s7Score50;
        score51.text = s7Score51;
        score52.text = s7Score52;
        score53.text = s7Score53;
        score54.text = s7Score54;
        score55.text = s7Score55;
        score56.text = s7Score56;
        score57.text = s7Score57;
        score58.text = s7Score58;
        score59.text = s7Score59;
        score60.text = s7Score60;

        BWinner.text = WinnerString7;
    }

    public void seeS8()
    {
        score16.text = s8Score16;
        score17.text = s8Score17;
        score18.text = s8Score18;
        score19.text = s8Score19;
        score20.text = s8Score20;
        score21.text = s8Score21;
        score22.text = s8Score22;
        score23.text = s8Score23;
        score24.text = s8Score24;
        score25.text = s8Score25;
        score26.text = s8Score26;
        score27.text = s8Score27;
        score28.text = s8Score28;
        score29.text = s8Score29;
        score30.text = s8Score30;
        score31.text = s8Score31;
        score32.text = s8Score32;
        score33.text = s8Score33;
        score34.text = s8Score34;
        score35.text = s8Score35;
        score36.text = s8Score36;
        score37.text = s8Score37;
        score38.text = s8Score38;
        score39.text = s8Score39;
        score40.text = s8Score40;
        score41.text = s8Score41;
        score42.text = s8Score42;
        score43.text = s8Score43;
        score44.text = s8Score44;
        score45.text = s8Score45;
        score46.text = s8Score46;
        score47.text = s8Score47;
        score48.text = s8Score48;
        score49.text = s8Score49;
        score50.text = s8Score50;
        score51.text = s8Score51;
        score52.text = s8Score52;
        score53.text = s8Score53;
        score54.text = s8Score54;
        score55.text = s8Score55;
        score56.text = s8Score56;
        score57.text = s8Score57;
        score58.text = s8Score58;
        score59.text = s8Score59;
        score60.text = s8Score60;

        BWinner.text = WinnerString8;
    }



    public void tourney()
    {   
        showTeam();
        showTeam();
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
        
        if(sNumber <= 3)
        {
            for(int i = 0; i < teamList.Length; i++)
            {
                for(int j = 0; j < teamList[i].players.Length; j++)
                {
                    teamList[i].players[j].age = teamList[i].players[j].age+1;
                }
            }
        }
        else
        {
            for(int i = 0; i < teamList2.Length; i++)
            {
                for(int j = 0; j < teamList2[i].players.Length; j++)
                {
                    teamList2[i].players[j].age = teamList2[i].players[j].age+1;
                }
            }
        }

        //seasonNumber.text = "Season: " + sNumber;
        if(sNumber < 3 || sNumber == 4){
            ScoutButton.SetActive(true);
            nextButton.SetActive(false);
        }

    }

    public void scoutingTime()
    {
        ScoutButton.SetActive(false);
        scouting.SetActive(true);
        currentPlayer = null;
        scouting2.text = "";
        timing = true;
    }

    public void ScoutingTank()
    {
        int tank = (int)Random.Range(0,realTankPlayers.Count);
        String name = realTankPlayers[tank].ign;
        String skill = realTankPlayers[tank].skill.ToString();
        scouting2.text = $"{name}\n{skill}";
        currentPlayer = realTankPlayers[tank];
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
                realTankPlayers.Remove(currentPlayer);
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
        showTeam();
        showTeam();
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
                realTankPlayers.Remove(currentPlayer);
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
                    teamSheetText += LunaticHai.players[i].ign + ": " + (int)(LunaticHai.players[i].skill+LunaticHai.players[i].effectiveSkill) + "\n";
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

            WinnerString1 = "Champions: " + S1Winner + "\nRunner Ups: " + secondP1;
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

            WinnerString2 = "Champions: " + S2Winner + "\nRunner Ups: " + secondP2;
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

            WinnerString3 = "Champions: " + S3Winner + "\nRunner Ups: " + secondP3;
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

            WinnerString4 = "Champions: " + S4Winner + "\nRunner Ups: " + secondP4;
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

            WinnerString5 = "Champions: " + S5Winner + "\nRunner Ups: " + secondP5;
            postSeason = false;
            Franchise();
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

            WinnerString6 = "Champions: " + S6Winner + "\nRunner Ups: " + secondP6;
            postSeason = false;
            Franchise();
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

            WinnerString7 = "Champions: " + S7Winner + "\nRunner Ups: " + secondP7;
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

            WinnerString8 = "Champions: " + S8Winner + "\nRunner Ups: " + secondP8;
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
                    realTankPlayers.Add(t.players[i]);
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
        if(sNumber < 4)
        {
            for(int i = 1; i < teamList.Length; i++)
            {
                ClearTeam(teamList[i]);
            }
        }
        else
        {
            for(int i = 1; i < teamList2.Length; i++)
            {
                ClearTeam(teamList2[i]);
            }
            ogPlayers.Clear();
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
        keepnums = 0;
        playerCount = 0;
        ogs = true;
        
        realTankPlayers.Clear();
        dpsPlayers.Clear();
        supportPlayers.Clear();

        for(int i = 0; i < tankCopy.Count; i++)
        {
            if(!ogPlayers.Contains(tankCopy[i]))
                realTankPlayers.Add(tankCopy[i]);
        }
        for(int i = 0; i < dpsCopy.Count; i++)
        {
            if(!ogPlayers.Contains(dpsCopy[i]))
                dpsPlayers.Add(dpsCopy[i]);
        }
        for(int i = 0; i < supportCopy.Count; i++)
        {
            if(!ogPlayers.Contains(supportCopy[i]))
                supportPlayers.Add(supportCopy[i]);
        }
    }
}