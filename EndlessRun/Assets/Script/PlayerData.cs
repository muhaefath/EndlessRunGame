using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData  {


    public float Score;


    public PlayerData(GameManagerController player)
    {
        Score = player.Score;
    }
}
