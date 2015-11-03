using UnityEngine;
using System.Collections;

public class Pontos : MonoBehaviour {

	public UnityEngine.UI.Text txtDistancia;
	public static int distancia;

	public UnityEngine.UI.Text txtScores;
	public static int scores;


	

	// Use this for initialization
	void Start () {
		distancia = 0;
		scores = 0;
		PlayerPrefs.SetInt("Distancia", distancia);
		PlayerPrefs.SetInt("Scores", scores);
	}
	
	// Update is called once per frame
	void Update () {
		txtDistancia.text = distancia.ToString();
		distancia ++;
		txtScores.text = scores.ToString();
	}
	

	/*void OnGUI(){
		GUI.Label(new Rect(10,10,105,20),"Pontuação: "+Pontos.scores.ToString());
	}*/
}
