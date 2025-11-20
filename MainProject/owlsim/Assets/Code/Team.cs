using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Team : MonoBehaviour
{
    public string brand;
    public Player p1;
    public Player p2;
    public Player p3;
    public Player p4;
    public Player p5;
    public Player p6;
    public Player p7;
    public Player p8;
    public Player p9;
    public Player p10;
    public Player p11;
    public Player p12;
    public int wins;
    public int mapwins;
    public int maploss;
    public int wins2;
    public int mapwins2;
    public int maploss2;
    public int wins3;
    public int mapwins3;
    public int maploss3;
    public int wins4;
    public int mapwins4;
    public int maploss4;
    public int wins5;
    public int mapwins5;
    public int maploss5;
    public int wins6;
    public int mapwins6;
    public int maploss6;
    public int wins7;
    public int mapwins7;
    public int maploss7;
    public int wins8;
    public int mapwins8;
    public int maploss8;
    public Player[] tanks;
    public Player[] dps;
    public Player[] supports;
    public Player[] players;

    public void fillPlayers()
    {
        players = new Player[12];
        players[0] = p1;
        players[1] = p2;
        players[2] = p3;
        players[3] = p4;
        players[4] = p5;
        players[5] = p6;
        players[6] = p7;
        players[7] = p8;
        players[8] = p9;
        players[9] = p10;
        players[10] = p11;
        players[11] = p12;
        tanks = new Player[8];
        dps = new Player[8];
        supports = new Player[8];
    }

    public void setPlayer(int n, Player p)
    {
        players[n] = p;
        Debug.Log(players[n].ign);
    }

    public void fillRoles()
    {
        fillPlayers();
        Array.Clear(tanks, 0, tanks.Length);
        Array.Clear(dps, 0, dps.Length);
        Array.Clear(supports, 0, supports.Length);
        
        int countT = 0;
        int countD = 0;
        int countS = 0;
        for(int i = 0; i <= players.Length-1; i++)
        {
            
            if(players[i].role == "Tank")
            {
                tanks[countT] = players[i];
                countT++;
            }
            else if(players[i].role == "DPS")
            {
                dps[countD] = players[i];
                countD++;
            }
            else if(players[i].role == "Support")
            {
                supports[countS] = players[i];
                countS++;
            }
        }
        for(int i = 0; i <= tanks.Length-1; i++)
        {
            if(tanks[i] == null)
            {
                tanks[i] = players[11];
            }
        }
        for(int i = 0; i <= dps.Length-1; i++)
        {
            if(dps[i] == null)
            {
                dps[i] = players[11];
            }
        }
        for(int i = 0; i <= supports.Length-1; i++)
        {
            if(supports[i] == null)
            {
                supports[i] = players[11];
            }
        }
    }

}
