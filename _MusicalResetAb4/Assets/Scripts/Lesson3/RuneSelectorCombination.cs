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

    /*
    [Header("Visuals")]
    [SerializeField] private Color m_colorCorrect;
    [SerializeField] private float m_colorTransitionDuration = 0.3f;
    [SerializeField] private Image m_runeImage;
    */

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
                //StartCoroutine(ColorCorrect());
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
            // StartCoroutine(ColorCorrect());
            
        }

        if (m_currentIndex == 4)
        {
            SequenceCompleted();
            Debug.Log("complete");
            m_announcerText.text = "Yeah!!!";
        }

      

    }

    /*
    // color correct
    private IEnumerator ColorCorrect()
    {
        yield return LerpToColor(Color.white, m_colorCorrect);

        yield return new WaitForEndOfFrame();

        yield return LerpToColor(m_colorCorrect, Color.white);
    }

    private IEnumerator LerpToColor(Color start, Color end)
    {
        float elapsedTime = 0;
        float startTime = Time.time;

        while(elapsedTime < m_colorTransitionDuration)
        {
            m_runeImage.color = Color.Lerp(start, end, elapsedTime / m_colorTransitionDuration);
            elapsedTime = Time.time - startTime;

            yield return null;

        }
    }
    */



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
