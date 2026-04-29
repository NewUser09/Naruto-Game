using System.Collections;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class IntroController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public string nextScene = "Home";

    void Start()
    {
        videoPlayer.Prepare();
        videoPlayer.prepareCompleted += OnPrepared;
        videoPlayer.loopPointReached += EndReached;
    }

    void OnPrepared(VideoPlayer vp)
    {
        StartCoroutine(PlayVideoSmooth(vp));
    }

    IEnumerator PlayVideoSmooth(VideoPlayer vp)
    {
        yield return null;
        vp.skipOnDrop = false;

        vp.Play();
        vp.Pause();
        vp.Play();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetMouseButtonDown(0))
        {
            SkipIntro();
        }
    }

    void EndReached(VideoPlayer vp)
    {
        FinishIntro();
    }

    void SkipIntro()
    {
        FinishIntro();
    }

    void FinishIntro()
    {
        SceneManager.LoadScene(nextScene);
    }
}