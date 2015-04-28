using UnityEngine;
using System.Collections;

public abstract class ship_part : MonoBehaviour {

	public int condition;
	public slot_type type;
	public int mass;

	public abstract void init (GameObject parent);

	public abstract bool check_requestments (GameObject parent);
}
