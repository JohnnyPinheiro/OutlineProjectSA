using UnityEngine;
using System.Collections;

public class Lerp : MonoBehaviour {

	float lerpTime = 1f;
	float currentLerpTime;

	float moveDistance = 10f;

	Vector3 startPos;
	Vector3 endPos;
	// Use this for initialization
	protected void Start () {
		startPos = transform.position;
		endPos = transform.position + transform.up * moveDistance;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			currentLerpTime = 0f;
		}
		currentLerpTime += Time.deltaTime;
		if (currentLerpTime > lerpTime) {
			currentLerpTime = lerpTime;
		}
		//lerp
		float perc = currentLerpTime / lerpTime;
		transform.position = Vector3.Lerp (startPos, endPos, perc);
	
	}
}
