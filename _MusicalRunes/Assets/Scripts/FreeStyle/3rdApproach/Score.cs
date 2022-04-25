using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Score : MonoBehaviour
{
    public string playerName;
    public string playerScore;

    public Score(string playerName, float score)
    {
        this.playerName = playerName;
        this.playerScore = score;
    }
}
