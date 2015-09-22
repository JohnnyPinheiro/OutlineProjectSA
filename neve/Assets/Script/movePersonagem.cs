using UnityEngine;
using System.Collections;

public class movePersonagem : MonoBehaviour {

	public Rigidbody rigd;
	public float speed;
	Animator animator;
	string state;
	private bool jump;
	

	// Use this for initialization
	void Start () {
	 rigd = GetComponent<Rigidbody>();
	 animator = GetComponentInChildren<Animator>();
	 state = "stop";
	}
	
	// Update is called once per frame
	void Update () {
		movimentation();
	}

	void movimentation(){
		if(Input.GetKey(KeyCode.A)){
			rigd.velocity = new Vector2(speed, rigd.velocity.y);
				if(!jump){
					animator.SetBool("left",true);
				}
		}else if(Input.GetKey(KeyCode.D)){
			rigd.velocity = new Vector2(-speed, rigd.velocity.y);
				if(!jump){
					animator.SetBool("right",true);
				}
		}else{
			rigd.velocity = new Vector2(0, rigd.velocity.y);
			animator.SetBool("left", false);
			animator.SetBool("right",false);
		}


		if(!jump && Input.GetKeyDown(KeyCode.Space)){
			rigd.AddForce(Vector2.up*15*60);
			jump = true;
			animator.SetBool("jump", true);
		}

	}

	void OnCollisionEnter(Collision collisionInfo){
		if(collisionInfo.gameObject.tag == "Ground"){
			jump = false;
			animator.SetBool("jump", false);
			print (jump);
		}
		if(collisionInfo.gameObject.tag == "Enemy"){
			Application.LoadLevel("GameOver");
		}
	}
}