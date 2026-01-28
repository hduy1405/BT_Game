
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class BasicAudio : MonoBehaviour
{
    private AudioSource _audio;

    void Awake()
    {
        _audio = GetComponent<AudioSource>();
        _audio.playOnAwake = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_audio.clip == null)
            {
                Debug.LogWarning("AudioSource chưa có clip!");
                return;
            }
            Debug.Log("Đã bấm Space bắt đầu phát nhạc");
            _audio.Play();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Đã bấm S dừng phát nhạc");
            _audio.Stop();
        }
    }
}
