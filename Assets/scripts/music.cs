using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour
{
   // If possible already reference this via the Inspector
    [SerializeField] private AudioSource _audioSource;

    public AudioSource AudioSource => _audioSource;

    // Others can only read
    // Only this class can set the value
    public static music Instance {get; private set;}

    private void Awake()
    {
        
        DontDestroyOnLoad(this.gameObject);

        // As fallback get it on runtime ONCE
        if(!_audioSource) _audioSource = GetComponent<AudioSource>();
    }

    public void PlayClip(AudioClip clip)
    {
        _audioSource.clip = clip;
        _audioSource.Play();
    }
}
