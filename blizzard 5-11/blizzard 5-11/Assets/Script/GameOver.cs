using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {
	public UnityEngine.UI.Text points;
	public UnityEngine.UI.Text records;
	// Update is called once per frame
	
	void Start(){
		points.text = PlayerPrefs.GetInt("points").ToString();
		records.text = PlayerPrefs.GetInt("records").ToString();

	}

	void Update () {
		if(Input.GetMouseButtonDown(0)){
			Application.LoadLevel("MenuIniciar");
		}
	
	}
}
