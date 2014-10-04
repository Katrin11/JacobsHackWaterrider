using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	
	static int playerNo;
	public float speed;
	private int run;
	private int x;
	private int y;
	
	void Start () {
		
		run = 1;
		speed = 1;
		x=0;
		playerNo=1;
		
	}
	
	void FixedUpdate () {
		if(run == 1){
			transform.position += new Vector3(speed*x,speed*y,0);
		}
		
		if(playerNo == 1){
			
			if(Input.GetKey(KeyCode.W)){
				transform.rotation =  Quaternion.Euler(0,0,0);
				x=0;
			}
			if(Input.GetKey(KeyCode.A)){
				transform.rotation =  Quaternion.Euler(0,0,90);
				x=0;
			}
			if(Input.GetKey(KeyCode.S)){
				transform.rotation =  Quaternion.Euler(0,0,180);
				x=0;
			}
			if(Input.GetKey(KeyCode.D)){
				transform.rotation =  Quaternion.Euler(0,0,270);
				x=0;
			}
			
			
		}
	}
	
	private void go(){
		//if(run == 1){
		//transform.position.x += speed*x;
		//}
	}
	
}
