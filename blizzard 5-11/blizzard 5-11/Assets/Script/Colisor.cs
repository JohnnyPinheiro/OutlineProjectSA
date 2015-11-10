using UnityEngine;
using System.Collections;

public class Colisor : MonoBehaviour {

	void OnCollisionEnter(Collision collisionInfo){
		
		if(collisionInfo.gameObject.tag == "Enemy"){
			Application.LoadLevel("GameOver");
			print("tocou");
			
		}
	}
}
