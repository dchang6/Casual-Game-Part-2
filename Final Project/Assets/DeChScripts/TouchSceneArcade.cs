using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using UnityEngine.SceneManagement;

public class TouchSceneArcade : MonoBehaviour {
	//variables
	private float ScreenWidth;

	  private AudioSource source;
    private float volLowRange = .5f;
    private float volHighRange = 1.0f;
    public AudioClip GameStarts;

	// Use this for initialization
	void Start () {
		ScreenWidth = Screen.width;
	}

	void Awake()
    {

        source = GetComponent<AudioSource>();

    }

	
	void Update () {
		int i = 0;
		while (i < Input.touchCount) {
			if (Input.GetTouch (i).position.x > ScreenWidth / 100)
            {SceneManager.LoadScene("Arcade Mode", LoadSceneMode.Single);
			float vol = Random.Range(volLowRange, volHighRange);
            source.PlayOneShot(GameStarts);
			}
			++i;
		}
	}
}