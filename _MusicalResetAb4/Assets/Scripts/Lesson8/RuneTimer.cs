using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Challenge 1
/// </summary>


public class RuneTimer : MonoBehaviour
{
    public float m_runeChoosingTime;
    public float m_remainingRuneChooseTime;

    bool isRuneChoosingTime;

    // Start is called before the first frame update
    void Start()
    {


        // Update is called once per frame
        void Update()
        {
            /*
             * Ozzy Solution
            if (!isRuneChoosingTime) return;

            m_remainingRuneChooseTime -= Time.deltaTime;
            m_remainingRuneChooseTime = Mathf.Max(0, m_remainingRuneChooseTime);
            timeText.text = m_remainingRuneChooseTime.ToString("F1");

            if (m_remainingRuneChooseTime <= 0)
                StartCoroutine(FailedSequence(false));

            private IEnumerator FailedSequence(bool choseWrongRune = true)
            {
                isRuneChoosingTime = false;
                SetPlayerInactivity(false);

                if (choseWrongRune)
                    Announcer.ShowWrongRune();
                else
                    Announcer.ShowTimeoutText()
            }

            */

            /*
             * Carlos Solution
             * 
             *  private IEnumerator RuneTimer()
                {
                    myTimer = 5.0f;

                    while(myTimer > 0f)
                    {
                        myTimer -= Time.deltaTime;
                        m_timeImage.fillAmount = myTimer / 5.0f;
                        Debug.Log(myTimer);
                        yield return null;
                    }

                    if ( myTimer <= 0f)
                    {
                        FailedRune("timesUp");
                    }
                }
             * 
             */
        }

        /*
         * private void LosingLife()
         * {
         *      m_maxLives -= -1;
         *      m_GMScript.m_currentLives.text = m_maxLives.ToString();
         *      
         *      if(m_maxLifes <= 0)
         *      {   
         *          LostGame();
         *      }
         *      
         * }
         */


        }
    }
    
