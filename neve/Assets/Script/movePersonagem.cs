using UnityEngine;
using System.Collections;

public class movePersonagem : MonoBehaviour {

	public Rigidbody rigd;
	public float speed;
	Animator animator;

	// Use this for initialization
	void Start () {
	 rigd = GetComponent<Rigidbody>();
	 animator = GetComponentInChildren<Animator>();
	 //state = "stop";
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.D)){
			rigd.velocity = new Vector3(-speed, 0,0);
			animator.SetBool ("right", true);
		}else if(Input.GetKey(KeyCode.A)){
			rigd.velocity = new Vector3(speed, 0,0);
		}else{
			animator.SetBool ("right", false);
		}

	}
}
