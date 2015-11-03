using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class VectorMap : MonoBehaviour {
//maps inclinado	
	//lista de pistas totais
	public GameObject[]Maps;
	//lista das pistas instanciadas e atualizadas
	List <GameObject> atual;
	public float speedMaps;
	private float tempSpeed;
	static public int count;
	static public int size=2500;
	//static int num = Random.Range(0,2);
	private int i = 0;
	

	// Use this for initialization
	void Start () {
	   count=0;
		atual = new List<GameObject>();
		//num = Random.Range(0,2);
		atual.Add ((GameObject)Instantiate (Maps [0],transform.position, Maps [0].transform.rotation));
		//num = Random.Range(0,2);
		//atual.Add ((GameObject)Instantiate (Maps [0],transform.position + new Vector3(0,-650,-1500) , Maps [num].transform.rotation));
		//
	}
	
	// Update is called once per frame
	void Update () {
	
		//tempSpeed += 1 *Time.deltaTime; 
		//for(int i=1;i<=10;i++){
		//	if (tempSpeed <= 20){atual[i].transform.Translate(0,0,speedMaps); print("Stage 1");}
		//	if (tempSpeed > 20 && tempSpeed <= 40){atual[i].transform.Translate(0,0,speedMaps*speedMaps);print("Stage 2");}
		//	if (tempSpeed > 40 && tempSpeed <= 60){atual[i].transform.Translate(0,0,speedMaps*speedMaps*speedMaps);print("Stage 3");}
		//	if (tempSpeed > 60){atual[i].transform.Translate(0,0,speedMaps*speedMaps*2);print("Final Stage");}
			/*if(atual[i].transform.position.z < 1301 ){
				Destroy(atual[i]);
				atual.Remove(atual[i]);
				//instancia outro
				atual.Add ((GameObject)Instantiate (Maps [Random.Range(0,Maps.Length)],transform.position+ new Vector3(0,-1200,-3000) , Maps [num].transform.rotation));
				count++;
				
				break;
			}*/
			//atual.Add ((GameObject)Instantiate (Maps [Random.Range(0,Maps.Length)],transform.position+ new Vector3(0,-1200,-3000) , Maps [num].transform.rotation));
			//count++;
			//i++;	
			//	break;
		
	//	}

		CreateMap();

	}

	void CreateMap(){
		
		if(i>=10){
			i =11;
		}else{
			for(i = 1; i<=10;i++){
				 atual.Add ((GameObject)Instantiate (Maps [0],transform.position + new Vector3(0,-650*i,-1500*i) , Maps [0].transform.rotation));
			}
		}
	}


}


