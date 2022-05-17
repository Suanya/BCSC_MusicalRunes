using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighTry : MonoBehaviour
{

    [SerializeField] private Transform highScoreEntryContainer;
    [SerializeField] private Transform highScoreEntryTemplate;

    private void Awake()
    {
        highScoreEntryContainer = transform.Find("highScoreEntryContainer");
        highScoreEntryTemplate = transform.Find("highScoreEntryTemplate");

        highScoreEntryTemplate.gameObject.SetActive(false);

        float templateHight = 20f;
        for(int i = 0; i < 10; i++)
        {
            Transform entryTransform = Instantiate(highScoreEntryTemplate, highScoreEntryContainer);
            RectTransform entryRectTransform = entryTransform.GetComponent<RectTransform>();
            entryRectTransform.anchoredPosition = new Vector2(0, -templateHight * i);
            entryTransform.gameObject.SetActive(true);
        }
    }
}
