using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Linq;

public class SecondScoreManager : MonoBehaviour
{
    private ScoreData sd;

    private void Awake()
    {
        sd = new ScoreData();
    }

    public IEnumerator<Score> GetHighScores()
    {
        return sd.score.OrderByDescending(keySelector: x :score => x.score);
    }

    public void AddScore(Score score)
    {
        sd.score.Add(score);
    }
}
