using UnityEngine;
using System.Collections;
//using SimpleJSON;
using System.IO;
using System.Text.RegularExpressions;


public class MCT : MonoBehaviour 
{
	public Transform mtrans,target;
	public float distance,scrollspeed;
	public byte action;

	GameObject BF;
	float RSpeed,MouseX,MouseY,WofS,HofS;
	float[] screen_scrool=new float[3];
	GameObject go;
	Vector3 vect,cVect;
	Vector3 MoveUp,MoveDown,MoveLeft,MoveRigth;
	Quaternion vect1;
	int heigth;

	// Use this for initialization
	void Start () {

		MoveUp.x=1;
		MoveUp.y=0;
		MoveUp.z=0;
		MoveDown.x=-1;
		MoveDown.y=0;
		MoveDown.z=0;
		MoveLeft.x=0;
		MoveLeft.y=-1;
		MoveLeft.z=0;
		MoveRigth.x=0;
		MoveRigth.y=1;
		MoveRigth.z=0;
		distance=3;
		scrollspeed=1;
		RSpeed=0.2f;
		action=1;
		WofS=Screen.width;
		HofS=Screen.height;
		screen_scrool[0]=HofS-10;
		screen_scrool[1]=20;
		screen_scrool[2]=WofS-10;

	}
	
	// Update is called once per frame
	void Update () 
	{
		MouseX=Input.mousePosition.x;
		MouseY=Input.mousePosition.y;
		WofS=Screen.width;
		HofS=Screen.height;
	//	Debug.Log (MouseX+"x");
	//	Debug.Log (MouseY+"y");
	//	Debug.Log (WofS+"w");
	//	Debug.Log (HofS+"h");

	MoveScreen();	
	ScrollScreen();

if(action==0)
		{

		}
if(action!=0)
		{			

		}
		

	}
	
	



	public Vector3 RayCastFromCam(GameObject t){

		Vector3 viewPos = GetComponent<Camera>().WorldToViewportPoint(t.transform.position);
        if (viewPos.x > 0.5F)
            print("target is on the right side!");
        else
            print("target is on the left side!");
		Debug.Log(viewPos);
		return viewPos;
	}
		
	private void MoveScreen()
	{	
		MouseX=Input.mousePosition.x;
		MouseY=Input.mousePosition.y;
if(MouseY>screen_scrool[0])
		{transform.position+=MoveRigth*RSpeed;
		action=0;}
if(MouseY<screen_scrool[1])
		{transform.position+=MoveLeft*RSpeed;
		action=0;}
if(MouseX>screen_scrool[2])
		{transform.position+=MoveUp*RSpeed;
		action=0;}
if(MouseX<screen_scrool[1])
		{transform.position+=MoveDown*RSpeed;
		action=0;
	}
}

	private void ScrollScreen()
	{
if (Input.GetAxis("Mouse ScrollWheel") < 0)distance +=0.1F*scrollspeed;
if (Input.GetAxis("Mouse ScrollWheel") > 0)distance -=0.1F*scrollspeed;	
if(distance<1)distance=1;
if(distance>4)distance=4;	
	}
	
	
	
}
