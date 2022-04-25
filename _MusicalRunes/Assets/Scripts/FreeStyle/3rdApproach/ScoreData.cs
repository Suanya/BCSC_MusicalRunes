using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class ScoreData
{
    public List<Score> score;

    public ScoreData()
    {
        score = new List<Score>();
    }
}
