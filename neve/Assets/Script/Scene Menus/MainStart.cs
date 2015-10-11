using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainStart : MonoBehaviour {

	
	public GameObject cam;
	public Button characterButton;
	public Button buttonBack;
	public Button startGame;

	private int controllerScreens;// 0 =

	//public GameObject splash;
	//private float speed = .5f;
	//private float z;
	void start(){
		controllerScreens = 0;

	}



	void Update () {
		/*z = transform.position.z;
		z += speed * Time.deltaTime;
		splash.transform.position = new Vector3(transform.position.x, transform.position.y, z);
	
		if (splash.transform.position.z >11){
			Destroy (splash);
		}*/
		controllerWindows();
	}

	void controllerWindows(){
		if(controllerScreens == 0){
			characterButton.interactable = true;
			buttonBack.interactable = false;
			startGame.interactable = true;
		}else if(controllerScreens == 1){
			//character
			buttonBack.interactable = true;
			startGame.interactable = false;
		}else if(controllerScreens == 2){
			//ranking
			startGame.interactable = false;
		}else if(controllerScreens == 3){
			//shop
			startGame.interactable = false;
		}else if(controllerScreens == 4){
			//play game
			Application.LoadLevel("Mapa_Jogo");
		}
	}

	public void Character(){
		cam.transform.Translate(0, 12, 0);
		characterButton.interactable = false;
		controllerScreens = 1;
	}

	public void BackWindows(){
		cam.transform.position = new Vector3(0, 0, 0);
		buttonBack.interactable = false;
		controllerScreens = 0;
	}

	public void GameStart(){
		controllerScreens = 4;
	}

}
