using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;

public class musicManager : MonoBehaviour
{
    public List<AudioClip> audioTracks = new List<AudioClip>();
    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.loop = true;
        PlayRandomTrack();
    }

    void PlayRandomTrack()
    {
        int trackIndex = Random.Range(0, audioTracks.Count);
        audioSource.clip = audioTracks[trackIndex];
        audioSource.Play();
    }
}
