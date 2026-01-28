using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoEvent : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject endUI;
    public string sceneToLoad = "";

    void Awake()
    {
        if (!videoPlayer) videoPlayer = GetComponent<VideoPlayer>();

        videoPlayer.playOnAwake = false;
        videoPlayer.prepareCompleted += OnPrepared;
        videoPlayer.loopPointReached += OnVideoEnd;

        if (endUI) endUI.SetActive(false);
    }

    void Start()
    {
        videoPlayer.Prepare();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            if (!videoPlayer.isPrepared)
                videoPlayer.Prepare();
            else
                videoPlayer.Play();
        }
    }

    private void OnPrepared(VideoPlayer vp)
    {
        Debug.Log("Video prepared -> Play");
        vp.Play();
    }

    private void OnVideoEnd(VideoPlayer vp)
    {
        Debug.Log("Video ended");

        if (endUI) endUI.SetActive(true);

        if (!string.IsNullOrEmpty(sceneToLoad))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }

    void OnDestroy()
    {
        if (videoPlayer != null)
        {
            videoPlayer.prepareCompleted -= OnPrepared;
            videoPlayer.loopPointReached -= OnVideoEnd;
        }
    }
}
