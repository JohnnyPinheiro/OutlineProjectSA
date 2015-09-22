using UnityEngine;
using System.Collections;

public class Pontos : MonoBehaviour {

	public UnityEngine.UI.Text txtDistancia;
	public static int distancia;
	

	// Use this for initialization
	void Start () {
	distancia = 0;
		
		PlayerPrefs.SetInt("Distancia", distancia);
	}
	
	// Update is called once per frame
	void Update () {
		txtDistancia.text = distancia.ToString();
		distancia ++;
	}
}
