using UnityEngine;
using UnityEngine.Video;

[RequireComponent(typeof(VideoPlayer))]
public class VideoPlay : MonoBehaviour
{
    private VideoPlayer _vp;

    void Awake()
    {
        _vp = GetComponent<VideoPlayer>();
        _vp.playOnAwake = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            if (_vp.clip == null && string.IsNullOrEmpty(_vp.url))
            {
                Debug.LogWarning("VideoPlayer chưa có clip/url!");
                return;
            }
            _vp.Play();
        }
    }
}
