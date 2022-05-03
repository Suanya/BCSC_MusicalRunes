using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rune : MonoBehaviour
{
    [SerializeField] private Color m_activationColor;
    [SerializeField] private AudioSource m_audioSource;
    [SerializeField] private Image m_runeImage;
    [SerializeField] private float m_colorTransitionDuration = 0.3f;

    public void RuneClick()
    {
        StopAllCoroutines();
        StartCoroutine(ActivateRune());
    }
    private IEnumerator ActivateRune()
    {
        m_audioSource.Play();

        yield return LerpToColor(Color.white, m_activationColor);


        while(m_audioSource.isPlaying)
        {
            yield return new WaitForEndOfFrame();
        }

        yield return LerpToColor(m_activationColor, Color.white);

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
}
