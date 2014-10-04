using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	
	public int playerNo;
	public float speed;
	private int run;
	private int x;
	private int y;

	
	void Start () {
		
		run = 1;
		x=0;
		
	}

	void OnMouseDown()
	{ run=0;
	}
	
	void FixedUpdate () {
		//if(
		if(run == 1){
			transform.position += new Vector3(speed*x* Time.deltaTime ,speed*y* Time.deltaTime,0);
		}
		if(run == 1){

		if(playerNo == 1){
			
			if(Input.GetKey(KeyCode.W)){
				transform.rotation =  Quaternion.Euler(0,0,0);
				x=0;
				y=1;
			}
			if(Input.GetKey(KeyCode.A)){
				transform.rotation =  Quaternion.Euler(0,0,90);
				x=-1;
				y=0;
			}
			if(Input.GetKey(KeyCode.S)){
				transform.rotation =  Quaternion.Euler(0,0,180);
				x=0;
				y=-1;
			}
			if(Input.GetKey(KeyCode.D)){
					Playereast();
			} 
			}
			if(playerNo == 2)
				{
					if(Input.GetKey(KeyCode.UpArrow)){
					playernorth();
					}
					if(Input.GetKey(KeyCode.LeftArrow)){
					playerwest();
					}
					if(Input.GetKey(KeyCode.DownArrow)){
					Playersouth();
					}
					if(Input.GetKey(KeyCode.RightArrow)){
					Playereast();
					}
				}
			}

			
		}
	private void playernorth(){
		transform.rotation =  Quaternion.Euler(0,0,0);
		x=0;
		y=1;
	}
	private void Playersouth(){
		transform.rotation =  Quaternion.Euler(0,0,180);
		x=0;
		y=-1;
	}
	private void playerwest(){
		transform.rotation =  Quaternion.Euler(0,0,90);
		x=-1;
		y=0;
	}
	private void Playereast(){	
		transform.rotation =  Quaternion.Euler(0,0,270);
		x=1;
		y=0;

	}
	private void go(){
		//if(run == 1){
		//transform.position.x += speed*x;
		//}
	}
}
	
	
	

