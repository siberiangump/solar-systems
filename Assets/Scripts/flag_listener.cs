using UnityEngine;
using System.Collections;

public abstract class flag_listener : MonoBehaviour {

	public flag_camp flags; 

	void Awake () {
		
		GameObject gmo = GameObject.FindGameObjectWithTag ("flag_camp");
		if( gmo == null ) gmo = GameObject.Instantiate(Resources.Load("flag_camp"))as GameObject ;
		flags = gmo.GetComponent<flag_camp> ();

	} 

	// Update is called once per frame
	void Update () {
		
		GameObject gmo = GameObject.FindGameObjectWithTag ("flag_camp");
		if( gmo == null ) gmo = GameObject.Instantiate(Resources.Load("flag_camp"))as GameObject ;
		flags = gmo.GetComponent<flag_camp> ();
		
		if (flags) {
			if (flags.play){ 
				OnPlayUpdate ();
				if(!flags.blockedByUI)OnUniverseUpdate();
			}
			if (!flags.play) OnPauseUpdate ();

		}

	}

	public virtual void OnPlayUpdate (){
	}

	public virtual void OnPauseUpdate (){
	}

	public virtual void OnUpdate (){
	}

	public virtual void OnUniverseUpdate (){
	}

	public virtual void OnMiniMapUpdate (){
	}


}
