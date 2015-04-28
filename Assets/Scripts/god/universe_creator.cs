using UnityEngine;
using System.Collections;

public class universe_creator : MonoBehaviour {

	public GameObject planet_holder;
	public GameObject task;
	public GameObject back_holder;
	public GameObject universe_prefab;
	public GameObject[] systems;
	public Sprite[] planets;
	public Sprite[] backs;


	public int universe_min_size=3;
	public int universe_max_size=5;
	public int min_planet_per_system=3;
	public int max_planet_per_system=5;
	public int emptines=3;
	public int system_radius=50;
	public int back_radius=15;
	public int planet_radius;

	private GameObject global_back;
	private GameObject universe;


	void Awake () {
		systems = Resources.LoadAll<GameObject> ("prefabs/systems") as GameObject[];
		planets = Resources.LoadAll<Sprite> ("images/planets/");
		backs = Resources.LoadAll<Sprite> ("images/backs/");
		dayOne ();
	}



	[ContextMenu ("bigbang")]
	public void dayOne(){
		universe = Instantiate (universe_prefab) as GameObject;
		global_back = GameObject.FindGameObjectWithTag ("global_back");


		int universe_x_size=Random.Range (universe_min_size, universe_max_size);
		int universe_y_size = Random.Range (universe_min_size, universe_max_size);
		for (int i =0; i<universe_x_size; i++) {
			for (int j =0; j<universe_y_size; j++) {
				if(Random.Range(0,10)>emptines)
				dayTwo(new Vector3(system_radius*i+Random.Range(0,system_radius/3),system_radius*j+Random.Range(0,system_radius/3),0),systems[Random.Range(0,systems.Length)]);
			}
		}
		for (int i =0; i<(int)(universe_x_size*system_radius/back_radius); i++) {
			for (int j =0; j<(int)(universe_y_size*system_radius/back_radius); j++) {
					dayFour(new Vector3(back_radius*i+Random.Range(0,back_radius/5),back_radius*j+Random.Range(0,back_radius/5),5+Random.Range(0,10)),backs[Random.Range(0,backs.Length)]);
			}
		}
		//GameObject[] plnts = GameObject.FindGameObjectsWithTag ("planet") as GameObject[];
		//int mx = Random.Range (3, 6); 
		//for (int l =0; l<mx;l++){
		//	dayFive(plnts[Random.Range(0,plnts.Length)]);
		//}

		Destroy (this);

	}

	public void dayTwo(Vector3 possition,GameObject system){
		GameObject gmo = Instantiate(system, possition, Quaternion.identity) as GameObject;
		gmo.transform.parent = universe.gameObject.transform;
		GameObject solar = gmo.transform.GetComponentInChildren<solar>().gameObject;

		solar.name = gen_name () + Random.Range(0,100);
		int amount_of_planets = Random.Range (min_planet_per_system,max_planet_per_system);
		for (int i =0; i<amount_of_planets; i++) {
			dayThree(new Vector3(solar.transform.position.x+(i+1)*planet_radius/(amount_of_planets*2),solar.transform.position.y,0),planets[Random.Range(0,planets.Length)],solar);
		}

	}

	public void dayThree(Vector3 possition, Sprite planet, GameObject solar){
		GameObject gmo = Instantiate (planet_holder, possition + new Vector3 (Random.Range (0.3f, 0.6f), 0, 0), Quaternion.identity)as GameObject;
		gmo.transform.GetComponentInChildren<planet> ().solar = solar;
		GameObject plnt = gmo.transform.GetComponentInChildren<planet> ().gameObject;
		gmo.transform.parent = solar.transform.parent;
		plnt.GetComponent<SpriteRenderer> ().color = new Color (solar.GetComponent<solar> ().aura.r, solar.GetComponent<solar> ().aura.g, solar.GetComponent<solar> ().aura.b, 1);
		plnt.GetComponent<SpriteRenderer> ().sprite = planet;
		plnt.name = gen_name ();
		int direction = (int)Random.Range (0, 10);
		if (direction < 6)
						direction = -1;
				else
						direction = 1;
		plnt.GetComponent<planet> ().direction = direction;
	}

	public void dayFour(Vector3 position,Sprite back){
		GameObject gmo = Instantiate (back_holder,position,new Quaternion(0,0,Random.Range(0,180),1))as GameObject;
		gmo.GetComponent<SpriteRenderer> ().sprite = back;
		gmo.transform.parent = global_back.transform;
	}

	public void dayFive(GameObject planet){
		Vector3 p = new Vector3 (planet.transform.parent.transform.position.x - 0.5f, planet.transform.parent.transform.position.y + 0.5f, planet.transform.parent.transform.position.z);
		GameObject gmo = Instantiate (task,p,new Quaternion(0,0,Random.Range(0,180),1))as GameObject;
		gmo.transform.parent = planet.transform.parent.transform.FindChild("ui");
	}



	public string gen_name(){
		string[] characters1 = new string[] {"b", "c", "d", "f", "g", "h", "i", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "y", "z"};
		string[] characters2 = new string[] {"a", "e", "o", "u"};
		string[] characters3 = new string[] {"br", "cr", "dr", "fr", "gr", "pr", "str", "tr", "bl", "cl", "fl", "gl", "pl", "sl", "sc", "sk", "sm", "sn", "sp", "st", "sw", "ch", "sh", "th", "wh"};
		string[] characters4 = new string[] {"ae", "ai", "ao", "au", "a", "ay", "ea", "ei", "eo", "eu", "e", "ey", "ua", "ue", "ui", "uo", "u", "uy", "ia", "ie", "iu", "io", "iy", "oa", "oe", "ou", "oi", "o", "oy"};
		string[] characters5 = new string[] {"turn", "ter", "nus", "rus", "tania", "hiri", "hines", "gawa", "nides", "carro", "rilia", "stea", "lia", "lea", "ria", "nov", "phus", "mia", "nerth", "wei", "ruta", "tov", "zuno", "vis", "lara", "nia", "liv", "tera", "gantu", "yama", "tune", "ter", "nus", "cury", "bos", "pra", "thea", "nope", "tis", "clite"};		

		
		int Random1 = Random.Range(0,characters1.Length);
		int Random2 = Random.Range(0,characters2.Length);
		int Random3 = Random.Range(0,characters3.Length);
		int Random4 = Random.Range(0,characters4.Length);	
		int Random5 = Random.Range(0,characters5.Length);
		
		
		string name = characters1[Random1] + characters2[Random2] + characters5[Random5];
		
		return name;
	}
	// Update is called once per frame
	void Update () {
	
	}
}
