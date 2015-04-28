using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class scroll_list : MonoBehaviour {

	public GameObject prefab;
	List<GameObject> entrys;

	// Use this for initialization
	void Start () {
		entrys = new List<GameObject> ();
	}

	void addEntry(GameObject gmo){
		GameObject entry =  Instantiate (prefab,new Vector3(this.transform.position.x,this.transform.position.y+prefab.transform.localScale.y*entrys.Count),Quaternion.identity) as GameObject;
		entry.BroadcastMessage ("grabInfo", gmo); 
		entrys.Add (entry);
	}

	// Update is called once per frame
	void Update () {
	
	}
}
