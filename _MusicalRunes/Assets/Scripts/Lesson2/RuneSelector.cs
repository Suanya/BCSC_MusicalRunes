using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  1) Attached this to the GameManager
///  2) User will click on buttons and this will tell us if they clicken on the right button
/// </summary>

public class RuneSelector : MonoBehaviour
{
    [SerializeField] private AudioSource m_as;
    [SerializeField] private AudioSource m_as2;

    private int[] m_currentRuneSequence = new[] { 0, 1, 2, 3 };
    private int m_currentIndex = 0;

    private bool CompletedSuccesfully;


    public void OnRuneActivated(int index)
    {
        if(!CompletedSuccesfully)
        {
            if (m_currentIndex >= m_currentRuneSequence.Length) return;

            if (m_currentRuneSequence[m_currentIndex] == index)
            {
                CorrectSelected();
            }
            else
            {
                Failed();
            }
        }
        
    }

    private void Failed()
    {
        m_currentIndex = 0; // restart the whole sequence

        // change announcer text to Failed
        // count down 3 2 1 go
        // prevent buttons of being interactable during that timer
    }

    private void CorrectSelected()
    {
        m_currentIndex++;

        if(m_currentIndex <= 3)
        {
            m_as.Play();
        }

        if(m_currentIndex == 4)
        {
            SequenceCompleted();
            Debug.Log("complete");
        }
        
    }

    private void SequenceCompleted()
    {
        m_as2.Play();
        CompletedSuccesfully = true;
    }
}

