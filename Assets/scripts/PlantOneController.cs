
//Created by Pier Shaw on 11/19/2015
//Copyright © 2014 Pier Shaw.All rights reserved.
//PlantOneController
//piershaw @gmail.com


using UnityEngine;
using System.Collections;

public class PlantOneController : MonoBehaviour {

	public GameObject player;

	private PlayerController pc;
	private Animator anime;
	
	void Start(){
		pc = player.GetComponent<PlayerController>();
		anime = this.GetComponent<Animator>();
	}




	//keep
	void OnTriggerEnter2D(Collider2D other) {
		 

		switch(Movment.playerMov){

			case Movment.Move.center:  
				Debug.Log("center");
				anime.SetBool("hitUp",false);
				break;

			case Movment.Move.up:  
				Debug.Log("up");
				anime.SetBool("hitUp",true);
				break;

			case Movment.Move.down:  
				Debug.Log("down");
				break;

			case Movment.Move.right:  
				Debug.Log("right");
				break;

			case Movment.Move.left:  
				Debug.Log("left");
				break;

		default:
			anime.SetBool("hitUp",false);
				break;

		}

	}
}
