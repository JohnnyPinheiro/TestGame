using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CreateMap : MonoBehaviour {


	public GameObject [] Map;
	static List <GameObject> atual;
	
	// Use this for initialization
	void Start () {
		for(int i = 0; i<20;i++){
				//almentar randon em mais 1
				//Instantiate(Map[i], new Vector3(i * 2.0F, 0, 0), Quaternion.identity);
				print(i);
			}
	}
	
	// Update is called once per frame
	void Update () {
		//map.transform.position = new Vector2(10, 10);
	}
}
