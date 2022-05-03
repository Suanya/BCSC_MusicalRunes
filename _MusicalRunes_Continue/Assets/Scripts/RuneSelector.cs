using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// Attach this to the GameManager.
/// User will click on button and this will
/// tell us if they clicked on the right button
/// </summary>
public class RuneSelector : MonoBehaviour
{
    [SerializeField] private Button[] m_runeButtons;
    [SerializeField] private TextMeshProUGUI m_text;


    [SerializeField] private AudioSource m_as;
    public int[] m_currentRuneSequence = new[] { 0, 1, 2, 3 };
    public int m_currentIndex = 0;

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
        m_currentIndex = 0;
        StartCoroutine(OnFail());
    }

    IEnumerator OnFail()
    {
        foreach(var rune in m_runeButtons)
        {
            rune.enabled = false;
        }
        m_text.text = "FAILED!";
        yield return new WaitForSeconds(1);
        m_text.text = "3!";
        yield return new WaitForSeconds(1);
        m_text.text = "2!";
        yield return new WaitForSeconds(1);
        m_text.text = "1!";
        yield return new WaitForSeconds(1);
        m_text.text = "Go!";
        foreach (var rune in m_runeButtons)
        {
            rune.enabled = true;
        }
    }

    private void CorrectSelected()
    {
        m_currentIndex++;
        m_as.Play();
        GameManager.s_instance.AddScore(10);
        //Logic
        SequenceCompleted();
    }

    private void SequenceCompleted()
    {
        throw new NotImplementedException();
    }
}
