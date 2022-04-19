using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Announcer : MonoBehaviour
{
    // bounce amplitude
    // bounce scale

    [SerializeField] [Range(-2f, 2f)] private float m_bounceAmplitude = 0.01f;
    [SerializeField] [Range(-2f, 2f)] private float m_bounceFrequency = 0.01f;


    // Update is called once per frame
    void Update()
    {
        // transform.localScale = new Vector3(0, 0, 0);
        transform.localScale = Vector3.one + Vector3.one * Mathf.Sin(Time.time * m_bounceFrequency) * m_bounceAmplitude;
    }
}
