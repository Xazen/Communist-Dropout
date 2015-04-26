using UnityEngine;
using System.Collections;

public class JumpScript : MonoBehaviour {

	private Animator animDrop;

	// Use this for initialization
	void Start () {
		animDrop = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)){
			animDrop.SetTrigger("Jump");
		}
	}
}
