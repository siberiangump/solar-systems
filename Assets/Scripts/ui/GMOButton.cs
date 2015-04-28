using UnityEngine;
using System.Collections;

public class GMOButton : ui_element {

	public GameObject target;
	public string method,parametr,findName;
	public int parametrInt=-1;
	public float parametrFloat=-1;
	public bool paramertThisName=false;

	// Use this for initialization
	void Start () {
		if(findName!="")
		target = GameObject.Find(findName)as GameObject;
	}

	void OnMouseUp() {
		if(findName!="")
			target = GameObject.Find(findName)as GameObject;

		if (paramertThisName)
			target.BroadcastMessage (method, this.gameObject.name);
		else if(parametr!="")
			target.BroadcastMessage (method, parametr);
		else if(parametrInt!=-1)
			target.BroadcastMessage (method, parametrInt);
		else if(parametrFloat!=-1)
			target.BroadcastMessage (method, parametrFloat);
		else target.BroadcastMessage (method);
	}

	void setIntParametr(int param){
		parametrInt = param;
	}
	
}
