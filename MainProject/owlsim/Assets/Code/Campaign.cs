using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = UnityEngine.Random;
using TMPro;

public class Campaign : MonoBehaviour
{
    public List<Player> tankPlayers = new List<Player>();
    public List<Player> tanksPlayer = new List<Player>();
    public List<Player> dpsPlayers = new List<Player>();
    public List<Player> supportPlayers = new List<Player>();

    [SerializeField] Player nullPlayer;

    public Team[] teamList;
    public Team LunaticHai;
    public Team GCBusan;
    public Team KingdooPanthera;
    public Team Cloud9;
    public Team Envy;
    public Team Rogue;


    void Start()
    {
        
        LunaticHai = gameObject.AddComponent<Team>();
        LunaticHai.brand = "Lunatic Hai";

        GCBusan = gameObject.AddComponent<Team>();
        GCBusan.brand = "GC Busan";

        KingdooPanthera = gameObject.AddComponent<Team>();
        KingdooPanthera.brand = "Kingdoo Panthera";

        Cloud9 = gameObject.AddComponent<Team>();
        Cloud9.brand = "Cloud9";

        Envy = gameObject.AddComponent<Team>();
        Envy.brand = "Envy";

        Rogue = gameObject.AddComponent<Team>();
        Rogue.brand = "Rogue";

        teamList[0] = LunaticHai;
        teamList[1] = GCBusan;
        teamList[2] = KingdooPanthera;
        teamList[3] = Cloud9;
        teamList[4] = Envy;
        teamList[5] = Rogue;

        tankPlayers = tanksPlayer;

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













}
