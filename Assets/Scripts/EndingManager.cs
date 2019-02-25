using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(CanvasGroup))]
public class EndingManager : MonoBehaviour
{

    public string totalEndingNumber;

    public Text title;

    public Text subtitle;

    public Image image;

    public Text endingNumberText;

    public void Awake()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    public void ShowEnding(EndingData ending)
    {
        CanvasGroup canvasGroup = GetComponent<CanvasGroup>();
        canvasGroup.alpha = 0f;
        LeanTween.alphaCanvas(canvasGroup, 1f, 2f);

        gameObject.SetActive(true);
        title.text = ending.title;
        subtitle.text = ending.subtitle;
        image.sprite = ending.image;
        endingNumberText.text = "Ending " + ending.endingNumber + " of " + totalEndingNumber + ".";
    }
}
