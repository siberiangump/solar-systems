using UnityEngine;
using System.Collections;

public class task_delivery : task {

	// Use this for initialization
	void Start () {
		init ();
	}

	public override void init (){
		portret = Resources.LoadAll<Sprite> ("images/portrets/");
		GameObject[] plnts = GameObject.FindGameObjectsWithTag("planet") as GameObject[];
		target = plnts [Random.Range (0, plnts.Length-1)];
		credits = (int)Vector3.Distance (this.transform.position, target.transform.position);
		port = portret[Random.Range(0,portret.Length)];
	}

	public override void confirm(GameObject gmo){
		//gmo.AddComponent();
	}

	public override void cancel(){
		GameObject.Destroy (this.gameObject);
	}

	void OnTriggerEnter(Collider other) {
		Debug.Log("llll");
		//checkUI ();
		//if (other.gameObject.tag == "Player") {
		//	UI.SetActive(true);
		//	UI.transform.GetComponentInChildren<SpriteRenderer>().sprite = port;
	//		UI.transform.FindChild("brif").GetComponent<TextMesh>().text = "пирожечки бабушке на планету\n"+target.name + " системы "+ target.GetComponent<planet>().solar.name;
	//		UI.transform.FindChild("price").GetComponent<TextMesh>().text = credits+ " кредитов";
	//		UI.transform.FindChild("OK").GetComponent<GMOButton>().target=this.gameObject;
	//		UI.transform.FindChild("OK").GetComponent<GMOButton>().method = "confirm";
	//		UI.transform.FindChild("NO").GetComponent<GMOButton>().target=this.gameObject;
	//		UI.transform.FindChild("NO").GetComponent<GMOButton>().method = "cancel";
	//	}
	} 

	//void checkUI(){
	//	if (UI == null)
	//		UI = GameObject.FindGameObjectWithTag ("dialog");
	//}

	// Update is called once per frame
	void Update () {
	
	}
}
