using UnityEngine;
using System.Collections;

public class movingStone : MonoBehaviour {

	public float speed;
	private float z;
		
	void Update () {
		
		z = transform.position.z;
		z += speed * Time.deltaTime;
		
		transform.position = new Vector3(transform.position.x,transform.position.y, z);
		
		
		if(z > 1065){
			Destroy(transform.gameObject);
			
		}
	}
}
