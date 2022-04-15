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

    private int[] m_currentRuneSequence = new[] { 0, 1, 2, 3 };
    private int m_currentIndex = 0;

    public void OnRuneActivated(int index)
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

    private void Failed()
    {
        m_currentIndex = 0; // restart the whole sequence
    }

    private void CorrectSelected()
    {
        m_currentIndex++;
        m_as.Play();
        //Logic
        SequenceCompleted();
    }

    private void SequenceCompleted()
    {
       
    }
}

