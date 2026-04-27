using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PortraitSlideShow : MonoBehaviour
{
    public Image portraitImage;
    public CanvasGroup canvasGroup;

    public Sprite[] portraits;

    public float displayTime = 2f;
    public float fadeDuration = 0.5f;

    private int currentIndex = 0;

    void Start()
    {
        StartCoroutine(Slideshow());
    }

    IEnumerator Slideshow()
    {
        while (true)
        {
            // tampilkan portrait sekarang
            portraitImage.sprite = portraits[currentIndex];

            // fade in
            yield return StartCoroutine(Fade(0f, 1f));

            // tunggu
            yield return new WaitForSeconds(displayTime);

            // fade out
            yield return StartCoroutine(Fade(1f, 0f));

            // next index
            currentIndex++;
            if (currentIndex >= portraits.Length)
                currentIndex = 0;
        }
    }

    IEnumerator Fade(float start, float end)
    {
        float time = 0;

        while (time < fadeDuration)
        {
            time += Time.deltaTime;
            canvasGroup.alpha = Mathf.Lerp(start, end, time / fadeDuration);
            yield return null;
        }

        canvasGroup.alpha = end;
    }
}