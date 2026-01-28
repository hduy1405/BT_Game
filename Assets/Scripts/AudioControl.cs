using UnityEngine;

public class AudioControl : MonoBehaviour
{
    private bool _muted;
    private bool _paused;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            _muted = !_muted;
            AudioListener.volume = _muted ? 0f : 1f;
            Debug.Log(_muted ? "Global MUTE" : "Global UNMUTE");
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            _paused = !_paused;
            AudioListener.pause = _paused;
            Debug.Log(_paused ? "Global PAUSE" : "Global RESUME");
        }
    }
}
