using UnityEngine;
using System.Collections;

public class moveSplash : MonoBehaviour {

	private float speed = .5f;
	private float z;

	void Update () {
		z = transform.position.z;
		z += speed * Time.deltaTime;
		transform.position = new Vector3(transform.position.x, transform.position.y, z);
	
		if (transform.position.z >11){
			Destroy (gameObject);
		}
	}
}
