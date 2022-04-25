using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] public RowUI rowUI;
    [SerializeField] public SecondScoreManager secondScoreManager;

    private void Start()
    {
        secondScoreManager.AddScore(new Score(playerName: "Lizzy", playerScore: 6));
        secondScoreManager.AddScore(new Score(playerName: "Jonny", playerScore: 8));

        var playerScore: Score[] = secondScoreManager.GetHighScores().ToArray();

        for (int i = 0; i < playerScore.Length; i++)
        {
            var row = Instantiate(rowUI, transform).GetComponent<RowUI>();
            row.playerRank.text = (i + 1).ToString();
            row.playerName.text = playerScore[i].playerName;
            row.playerScore.text = playerScore[i].playerScore.ToString;
                
        }
    }
}
