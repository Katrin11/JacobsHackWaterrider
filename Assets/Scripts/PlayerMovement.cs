using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	static int playerNo;
	public int speed;
	private int run;
	private int x;
	private int y;

	void Start () {

		 run = 1;
		speed = 1;


	}

	void FixedUpdate () {
		if(run == 1){
			transform.position.x += speed*x;
		}

		if(playerNo == 1){

			if(Input.GetKey(KeyCode.W)){
				transform.rotation =  Quaternion.Euler(0,0,0);
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
