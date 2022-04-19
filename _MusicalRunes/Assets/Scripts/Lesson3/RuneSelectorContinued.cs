using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RuneSelectorContinued : MonoBehaviour
{
    [SerializeField] private AudioSource m_as;
    [SerializeField] private AudioSource m_audioSourceFail;
    [SerializeField] private AudioSource m_asComplete;
    

    private int[] m_currentRuneSequence = new[] { 0, 1, 2, 3 };
    private int m_currentIndex = 0;

    private bool CompletedSuccesfully;


    public void OnRuneActivated(int index)
    {
        if (!CompletedSuccesfully)
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
 
    // correct Sequence
    private void CorrectSelected()
    {
        m_currentIndex++;

        if (m_currentIndex <= 3)
        {
            m_as.Play();
        }

        if (m_currentIndex == 4)
        {
            SequenceCompleted();
            Debug.Log("complete");
        }

    }

    private void SequenceCompleted()
    {
        m_asComplete.Play();
        CompletedSuccesfully = true;
    }

    // fail Sequence
    private void Failed()
    {
        m_audioSourceFail.Play();
        //FailCountDown();
        m_currentIndex = 0; // restart the whole sequence
    }
}
