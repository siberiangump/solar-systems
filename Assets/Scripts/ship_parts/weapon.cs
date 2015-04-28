using UnityEngine;
using System.Collections;

public abstract class weapon : MonoBehaviour {

	public string name;
	public Sprite icon;
	public int bullet_amount;
	public float cooldown;
	public GameObject bulletPrefab;

	abstract public void realise_bullet ();

}
