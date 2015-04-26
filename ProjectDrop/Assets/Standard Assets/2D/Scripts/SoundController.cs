using UnityEngine;
using System.Collections;

public class SoundController : MonoBehaviour
{

	[SerializeField]
	AudioClip
		bg;
	[SerializeField]
	AudioClip
		jump;
	[SerializeField]
	AudioClip
		land;
	bool playedLanding = false;
	AudioSource audioSource;

	public static SoundController instance { get; private set; }

	void Awake ()
	{
		instance = this;

		audioSource = gameObject.AddComponent<AudioSource> ();
		audioSource.PlayOneShot (bg);
	}
	
	public void playJump ()
	{
		if (jump != null) {
			playedLanding = false;
			audioSource.PlayOneShot (jump);
		}
	}

	public void playLanding ()
	{
		if (land != null) {
			audioSource.PlayOneShot (land);				
			playedLanding = true; 
		}
	}
}
