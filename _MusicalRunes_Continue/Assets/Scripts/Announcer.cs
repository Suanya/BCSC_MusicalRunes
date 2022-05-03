using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Announcer : MonoBehaviour
{
    [SerializeField] [Range(0f,1f)] private float m_bounceAmplitude = 0.01f;
    [SerializeField] [Range(-10f, 10f)] private float m_bounceFrequency = 0.01f;
    void Update()
    {
        transform.localScale = Vector3.one + Vector3.one * Mathf.Sin(Time.time * m_bounceFrequency) * m_bounceAmplitude;
    }
}
