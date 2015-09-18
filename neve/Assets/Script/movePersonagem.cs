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
			animator.SetBool("stop", false);
		}else if(Input.GetKey(KeyCode.A)){
			rigd.velocity = new Vector3(speed, 0,0);
			animator.SetBool ("left", true);
			animator.SetBool("stop", false);
		}else{
			animator.SetBool("stop", true);
			animator.SetBool ("right", false);
			animator.SetBool ("left", false);
		}

		if(Input.GetKeyDown(KeyCode.Z)){
			rigd.AddForce(0, 20,0, ForceMode.Impulse);
			animator.SetBool("stop", false);
			animator.SetBool ("right", false);
			animator.SetBool ("left", false);
			animator.SetBool ("jump", true);
		}

	}
}
