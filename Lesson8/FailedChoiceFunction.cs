using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailedChoiceFunction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*

    private void FailedChoice(bool choseWrongRune)
    {
        RemainingLives--;

        if(RemainingLives == 0)
        {
            StartCoroutine(FailedSequence(choseWrongRune));
            return;
        }

        if (choseWrongRune)
            Announcer.ShowWrongRuneText();
        else
            Announcer.ShowTimeoutText();
    }
    */
}
