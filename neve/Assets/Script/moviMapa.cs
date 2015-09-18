using UnityEngine;
using System.Collections;

public class moviMapa : MonoBehaviour {

	public float velocidade;
	private float z;
	
	// Update is called once per frame
	void Update () {
	z = transform.position.z;
		z += velocidade * Time.deltaTime;
	transform.position = new Vector3(transform.position.x, transform.position.y, z);
	
	if (transform.position.z >1000){
		transform.position = new Vector3(transform.position.x, transform.position.y, -1000);
			
		}
	}
}
