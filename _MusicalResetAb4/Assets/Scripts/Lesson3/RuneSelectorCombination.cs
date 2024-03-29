using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class RuneSelectorCombination : MonoBehaviour
{
    /*
    [Header("GameManager")]
    [SerializeField] private GameManager m_GMScript;
    */
     
    [Header("Audio")]
    [SerializeField] private AudioSource m_audioSourceCorrect;
    [SerializeField] private AudioSource m_audioSourceFail;
    [SerializeField] private AudioSource m_as2;    

    [Header("SetActive")]
    [SerializeField] GameObject[] m_runesButtons;

    [Header("Announcements")]
    [SerializeField] private TMP_Text m_announcerText;

    // [SerializeField] private Color m_failColor;

    

    public int[] m_currentRuneSequence = new[] { 0, 1, 2, 3 };
    public int m_currentIndex = 0;
    public bool m_completedSuccesfully;

    // Indexing the selected Runes
    public void OnRuneActivated(int index)
    {
        if (!m_completedSuccesfully)
        {
            if (m_currentIndex >= m_currentRuneSequence.Length) return;

            if (m_currentRuneSequence[m_currentIndex] == index)
            {
                CorrectSelected();
                Debug.Log("Correct");
                
                //ScoreManager.instance.AddPoint();
            }
            else
            {
                m_audioSourceFail.Play();               
                Failed();
                Debug.Log("OhNo! Fail");
                
                FailCountDown();
                Debug.Log("Countdown");

                //ScoreManager.instance.ResetPoints();
            }
        }
    }

    // correct selected Sequence
    public void CorrectSelected()
    {
        m_currentIndex++;

        //m_GMScript.AddScore(10);
        GameManager.s_instance.AddScore(20);

        if (m_currentIndex <= 3)
        {
            m_audioSourceCorrect.Play();
           
        }

        if (m_currentIndex == 4)
        {
            SequenceCompleted();
            Debug.Log("complete");
            m_announcerText.text = "Yeah!!!";
        }
    }

    private void SequenceCompleted()
    {
        m_as2.Play();
        m_completedSuccesfully = true;
    }

    
    
    

    // failed Sequence
    public void Failed()
    {
        m_currentIndex = 0; // restart the whole sequence
        Debug.Log("IndexBack");
    }
   
    public void FailCountDown()
    {
        ToggleButtonInteractive(false);
        StartCoroutine(ReEnableGame());
    }
    
    IEnumerator ReEnableGame()
    {
        yield return StartCoroutine(AnnoucerCoroutine(3, 1));
        m_announcerText.text = "Again!";
        ToggleButtonInteractive(true);
    }

    IEnumerator AnnoucerCoroutine(int count, int delay)
    {
        for(int i = count; i >= 0; i--)
        {
            m_announcerText.text = i.ToString();
            yield return new WaitForSeconds(delay);          
        }
    }

    private void ToggleButtonInteractive(bool isActive)
    {
        foreach(var runeBtn in m_runesButtons)
        {
            runeBtn.GetComponent<Button>().interactable = isActive;
        }
    }
}
