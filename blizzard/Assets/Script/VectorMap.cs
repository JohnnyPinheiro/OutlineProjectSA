using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class VectorMap : MonoBehaviour {
//maps inclinado	
	//lista de pistas totais
	public GameObject[]Maps;
	//lista das pistas instanciadas e atualizadas
	static List <GameObject> atual;
	public float speedMaps;
	private float tempSpeed;
	static public int count;
	static public int size=2500;
	//static int num = Random.Range(0,2);
	private static int i = 0;
	

	// Use this for initialization
	void Start () {
	   count=0;
		atual = new List<GameObject>();
		//num = Random.Range(0,2);
		atual.Add ((GameObject)Instantiate (Maps [0],transform.position, Maps [0].transform.rotation));
		//num = Random.Range(0,2);
		atual.Add ((GameObject)Instantiate (Maps [0],transform.position + new Vector3(110,710,1700) , Maps [0].transform.rotation));
		//
	}
	
	/*void Update(){
		CreateMap();
	}*/

	public  void CreateMap(){
		if(i>=10){
			i =11;
		}else{
			for(i = 1; i<=10;i++){
				 atual.Add ((GameObject)Instantiate (Maps [0],transform.position + new Vector3(-110*i,-710*i,-1700*i) , Maps [0].transform.rotation));
			}
		}
	}


}


