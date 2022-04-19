using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinLighManager : MonoBehaviour
{
    [SerializeField] private GameObject[] m_spinLights;

    private void Start()
    {
        StartCoroutine(FlashLights());
    }

    IEnumerator FlashLights()
    {
        while(true)
        {
            yield return new WaitForSeconds(0.5f);

            foreach(GameObject go in m_spinLights)
            {
                go.SetActive(true);
                
            }
        }
    }


}
