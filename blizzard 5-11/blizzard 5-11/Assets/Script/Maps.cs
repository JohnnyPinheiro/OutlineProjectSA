using UnityEngine;
using System.Collections;

public class Maps : MonoBehaviour {

	// Use this for initialization
	void Start () {

			transform.Translate(0,0,-VectorMap.size*VectorMap.count);


		
		VectorMap.count++;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
