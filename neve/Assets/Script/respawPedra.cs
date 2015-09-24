using UnityEngine;
using System.Collections;

public class respawPedra : MonoBehaviour {
	public GameObject obstaclePrefab; //obstacle spawn
	public float rateSpawn; //temp spawn
	public float currentTime; //controller time spawn
	private int position;
	private float x;
	public float posi1;
	public float posi2;
	public float posi3;
	
	// Use this for initialization
	void Start () {
		currentTime = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		currentTime += Time.deltaTime;
		if(currentTime >= rateSpawn){
			currentTime = 0;
			position = Random.Range(1,100);
			if(position < 33){
				x = posi1;
			}else if(position >= 33 && position <66){
				x = posi2;
			}else{
				x = posi3;
			}
			GameObject tempPrefab = Instantiate(obstaclePrefab) as GameObject;
			tempPrefab.transform.position = new Vector3(x, transform.position.y,transform.position.z);
			print (position);
		}
	}
}
