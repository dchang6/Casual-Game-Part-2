using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileMovement : MonoBehaviour {
	//variables
	public float moveSpeed = 10;
	public GameObject character;

	private Rigidbody2D characterBody;
	private float ScreenWidth;


	// Use this for initialization
	void Start () {
		ScreenWidth = Screen.width;
		characterBody = character.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		int i = 0;
		//loop over every touch found
		while (i < Input.touchCount) {
			if (Input.GetTouch (i).position.x > ScreenWidth / 2) {
				//move right
				transform.position += Vector3.up * moveSpeed * Time.deltaTime;
			}
			if (Input.GetTouch (i).position.x < ScreenWidth / 2) {
				//move left
				transform.position += Vector3.down * moveSpeed * Time.deltaTime;
			}
			++i;
		}
	}
	void FixedUpdate(){
		#if UNITY_EDITOR
		RunCharacter(Input.GetAxis("Horizontal"));
		#endif
	}

	private void RunCharacter(float horizontalInput){
		//move player
		characterBody.AddForce(new Vector2(horizontalInput * moveSpeed * Time.deltaTime, 0));

	}
}
