using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RuneSelectorCombination : MonoBehaviour
{
    [Header("Audio")]
    [SerializeField] private AudioSource m_as;
    [SerializeField] private AudioSource m_as2;

    [Header("SetActive")]
    [SerializeField] GameObject[] m_runesButtons;

    [Header("Announcements")]
    [SerializeField] private TMP_Text m_announcerText;

    private int[] m_currentRuneSequence = new[] { 0, 1, 2, 3 };
    private int m_currentIndex = 0;

    private bool CompletedSuccesfully;

    // Indexing the selected Runes
    public void OnRuneActivated(int index)
    {
        if (!CompletedSuccesfully)
        {
            if (m_currentIndex >= m_currentRuneSequence.Length) return;

            if (m_currentRuneSequence[m_currentIndex] == index)
            {
                CorrectSelected();
                Debug.Log("Correct");
            }
            else
            {
                Failed();
                Debug.Log("OhNo! Fail");
                FailCountDown();
                Debug.Log("Countdown");

            }
        }
    }

    // correct selected Sequence
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
        m_as2.Play();
        CompletedSuccesfully = true;
    }

    // failed Sequence
    private void Failed()
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
        m_announcerText.text = "Again";
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
