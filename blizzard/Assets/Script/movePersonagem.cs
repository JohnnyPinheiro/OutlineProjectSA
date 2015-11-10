using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class movePersonagem : MonoBehaviour {

	Rigidbody rigd;
	public float speed;
	Animator animator;
	
	private bool jump;
	public float gravity;
	private bool inicio;
	public float forcejump;
	

	//points
	public UnityEngine.UI.Text txtPoints;
	public static  int points;
	// Use this for initialization
	public GameObject invisible;

	//audio
	public AudioSource audio;
	//public AudioClip soundJump;
	//public AudioClip soundSlide;

	void Start () {
		points = 0;
		PlayerPrefs.SetInt("points", points);
		Physics.gravity = new Vector3(0, -gravity, 0);
		rigd = GetComponentInParent <Rigidbody>();
		animator = GetComponentInChildren<Animator>();
		inicio = false;
	
	}
	
	void Update () {

		txtPoints.text = points.ToString();
		//rigd.AddTorque(transform.right*speed);
		movimentation();
		MoveJoy();

		if (!inicio && Input.GetMouseButton (0)) {
			rigd.AddForce(0,0,-80, ForceMode.Impulse);
			inicio = true;
		}
		
	}

	void movimentation(){
		if(Input.GetKey(KeyCode.A)){
			rigd.velocity = new Vector3(speed, rigd.velocity.y,rigd.velocity.z);
				if(!jump){
					animator.SetBool("left",true);
				}
		}else if(Input.GetKey(KeyCode.D)){
			rigd.velocity = new Vector3(-speed, rigd.velocity.y,rigd.velocity.z);
				if(!jump){
					animator.SetBool("right",true);
				}
		}else{
			rigd.velocity = new Vector3(0, rigd.velocity.y,rigd.velocity.z);
			animator.SetBool("left", false);
			animator.SetBool("right",false);
		}


		if(!jump && Input.GetKeyDown(KeyCode.Space)){
			rigd.AddForce(0,forcejump,0, ForceMode.Impulse);
			jump = true;
			animator.SetBool("jump", true);
		}
	}

	void OnCollisionEnter(Collision collisionInfo){
		if(collisionInfo.gameObject.tag == "Ground"){
		//so para voltar o pulo
			jump = false;
			animator.SetBool("jump", false);
			Physics.gravity = new Vector3(0, -gravity, 0);
		}
		
		if(collisionInfo.gameObject.tag == "GameOver"){


			if(points > PlayerPrefs.GetInt("records")){
				PlayerPrefs.SetInt("records", points);
			}
			Application.LoadLevel("GameOver");
		}
	}

	void OnTriggerEnter(Collider other){
		if(other.tag == "Prox"){
			print("novo mapa");
			invisible.GetComponent<VectorMap>().CreateMap();
		}if(other.tag == "Coin"){
			print("1 Coin");
			Destroy(other.gameObject);
			Pontos.points += 1;
		}
	}

	void MoveJoy(){
		if(CrossPlatformInputManager.GetAxis("Horizontal")>0){
			rigd.velocity = new Vector3(-speed, rigd.velocity.y,rigd.velocity.z);
			if(!jump){animator.SetBool("right",true);}
			
		}else if(CrossPlatformInputManager.GetAxis("Horizontal")<0){
			rigd.velocity = new Vector3(speed, rigd.velocity.y,rigd.velocity.z);
			if(!jump){animator.SetBool("left",true);}
		}
	}

	public void jumping(){
		if(!jump){
			rigd.AddForce(0,forcejump,0, ForceMode.Impulse);
			jump = true;
			animator.SetBool("jump", true);
			Physics.gravity = new Vector3(0, -gravity, 0);
		
			
		}
	}

	
}