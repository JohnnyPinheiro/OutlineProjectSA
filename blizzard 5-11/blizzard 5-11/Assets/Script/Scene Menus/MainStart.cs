using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainStart : MonoBehaviour {

	
	public GameObject cam;
	public Button characterButton;
	public Button buttonBack;
	public Button startGame;
	public Button shop;
	public Button ranking;


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
			buttonBack.interactable = false;
			ButtonsMenu(true);
		}else if(controllerScreens == 1){
			//character
			buttonBack.interactable = true;
			ButtonsMenu(false);
		}else if(controllerScreens == 2){
			//ranking
			buttonBack.interactable = true;
			ButtonsMenu(false);
		}else if(controllerScreens == 3){
			//shop
			buttonBack.interactable = true;
			ButtonsMenu(false);
		}else if(controllerScreens == 4){
			//play game
			Application.LoadLevel("Mapa_Jogo");
		}
	}

	public void BackWindows(){
		cam.transform.position = new Vector3(0, 0, 0);
		buttonBack.interactable = false;
		controllerScreens = 0;
	}

	public void Character(){
		controllerScreens = 1;
		cam.transform.position = new Vector3(0, 20, 0);
	}

	public void RankingGame(){
		controllerScreens = 2;
		cam.transform.position = new Vector3(20,12, 0);
	}

	public void ShopGame(){
		controllerScreens = 3;
		cam.transform.position = new Vector3(20, 0, 0);

	}	

	public void GameStart(){
		controllerScreens = 4;
	}

	void ButtonsMenu(bool id) {
		characterButton.interactable = id;
		startGame.interactable = id;
		shop.interactable = id;
		ranking.interactable = id;
	}


}
