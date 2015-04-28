using UnityEngine;
using System.Collections;

public class fallower : MonoBehaviour {

	public GameObject target;
	public string targetTag="";
	public bool x2d=true;
	public bool delay=true;
	public bool paralax=false;


	Vector3 old_position;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (target == null && targetTag!="") {
			target= GameObject.FindGameObjectWithTag(targetTag);	
		}
		if (target != null) {
		 	if(x2d){
				if(paralax)
					this.transform.position=new Vector3(target.transform.position.x*0.1f,target.transform.position.y*0.1f);
				else
					this.transform.position=new Vector3(target.transform.position.x,target.transform.position.y,this.transform.position.z);
			}
		}
	}
}
