using UnityEngine;
using System.Collections;

public class SlideAnim : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown ("Slide")) {
			GetComponent<Animation> ().Play ("playerslide");
		}
	
	}
}
