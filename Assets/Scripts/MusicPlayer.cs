using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public  AudioClip music;
    public bool loop = false;
    public bool autoPlay = false;

    private AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
        source.clip = music;

        source.loop = loop;

        if (autoPlay)
            play();
    }

    public void play() {
        source.Play();
	}

    public void pause() {

	}

	public void reset() {
		
	}
}
