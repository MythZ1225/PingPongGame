using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {
    public AudioClip[] Songs;

    //AudioSource audio;
    int currentSong = 0;

    // Use this for initialization
    void Start () {
       //audio = GetComponent<AudioSource>();

	}
	
	// Update is called once per frame
	void Update () {
        if ( GetComponent<AudioSource>().isPlaying  == false)
        {
            currentSong++;
            if (currentSong >= Songs.Length)
            {
                currentSong = 0;
            }
            GetComponent<AudioSource>().clip = Songs[Random.Range(0,Songs.Length)];
            GetComponent<AudioSource>().Play();
        }
	}
}
