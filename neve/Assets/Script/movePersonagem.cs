using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class movePersonagem : MonoBehaviour {

	public Rigidbody rigd;
	public float speed;
	Animator animator;
	string state;
	private bool jump;
	public float gravity;
	public float speedX;
	private float speedY;

	// Use this for initialization
	void Start () {
	 Physics.gravity = new Vector3(0, -gravity, 0);
	 rigd = GetComponent<Rigidbody>();
	 animator = GetComponentInChildren<Animator>();
	 state = "stop";
	// speedX = 0;
		speedY = 0;
	}
	
	// Update is called once per frame
	void Update () {
		movimentation();
		//MoveCube();
		MoveJoy();
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
			rigd.AddForce(0,15,0, ForceMode.Impulse);
			jump = true;
			animator.SetBool("jump", true);
		}
	}

	void OnCollisionEnter(Collision collisionInfo){
		if(collisionInfo.gameObject.tag == "Ground"){
		//so para voltar o pulo
			jump = false;
			animator.SetBool("jump", false);
			print (jump);
		}
		if(collisionInfo.gameObject.tag == "Enemy"){
			Application.LoadLevel("GameOver");
		}
	}

	void MoveJoy(){
		if(CrossPlatformInputManager.GetAxis("Horizontal")>0){
			print("vai direita");
			rigd.velocity = new Vector2(-speed, rigd.velocity.y);
				if(!jump){
					animator.SetBool("right",true);
				}
		}else if(CrossPlatformInputManager.GetAxis("Horizontal")<0){
			print("vai esquerda");
			rigd.velocity = new Vector2(speed, rigd.velocity.y);
				if(!jump){
					animator.SetBool("left",true);
				}
		}else{
			print("parado");
		}
	}

	public void jumping(){
		rigd.AddForce(0,15,0, ForceMode.Impulse);
		jump = true;
		animator.SetBool("jump", true);
	}


	/*void MoveCube(){
       if(Input.GetMouseButton(0)){
	       if(Input.mousePosition.x < 240){
	        	//transform.Translate(-cont * Time.deltaTime, 0, 0, Space.World);
	        	rigd.velocity = new Vector2(speed, rigd.velocity.y);
	        	if(!jump){
					animator.SetBool("left",true);
				}
	       }else if(Input.mousePosition.x >= 240){
			    //transform.Translate(cont * Time.deltaTime, 0, 0, Space.World);
				rigd.velocity = new Vector2(-speed, rigd.velocity.y);
				if(!jump){
					animator.SetBool("right",true);
				}
			}		
		}
	}*/
}