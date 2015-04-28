using UnityEngine;
using System.Collections;

public class get_aura : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public void init(){

		GameObject[] solars = GameObject.FindGameObjectsWithTag("solar");
		GameObject solar = solars[0];
		float distance = Vector3.Distance(this.gameObject.transform.position,solar.transform.position);
		foreach(GameObject gmo in solars){
			float d=Vector3.Distance(this.gameObject.transform.position,gmo.transform.position);
			if(distance>d){
				distance=d;
				solar=gmo;
			}
		}
		this.GetComponent<SpriteRenderer> ().color = new Color (solar.GetComponent<solar> ().aura.r, solar.GetComponent<solar> ().aura.g, solar.GetComponent<solar> ().aura.b, 1);
	
	}

	// Update is called once per frame
	void Update () {
	
	}
}
