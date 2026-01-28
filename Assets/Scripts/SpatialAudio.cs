using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SpatialAudio : MonoBehaviour
{
    [Range(0f, 1f)] public float spatialBlend = 1f;
    public bool autoLoop = true;

    private AudioSource _audio;

    void Awake()
    {
        _audio = GetComponent<AudioSource>();
        _audio.playOnAwake = false;
        _audio.loop = autoLoop;
        Apply();
    }

    void Start()
    {
        if (_audio.clip != null) _audio.Play();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            spatialBlend = 0f;
            Apply();
            Debug.Log("Audio = 2D");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            spatialBlend = 1f;
            Apply();
            Debug.Log("Audio = 3D");
        }
    }

    void Apply()
    {
        _audio.spatialBlend = spatialBlend;

        if (spatialBlend >= 0.5f)
        {
            _audio.minDistance = 2f;
            _audio.maxDistance = 20f;
            _audio.rolloffMode = AudioRolloffMode.Logarithmic;
        }
    }
}
