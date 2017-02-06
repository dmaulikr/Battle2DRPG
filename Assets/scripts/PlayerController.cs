//Created by Pier Shaw on 11/19/2015
//Copyright © 2014 Pier Shaw.All rights reserved.
//PlayerController
//piershaw @gmail.com

using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	private const float speed = 2.0f;
	private const float speedRotation = 300.0f;
	private Animator anime;

	public GameObject ground;

	void Start(){
		Movment.playerMov = Movment.Move.center;
		anime = this.GetComponent<Animator>();
		//bullets
		//rigidbody2D.velocity = new Vector2(0,Time.deltaTime * speed);
	}
	

	void Update (){
		float translation = Input.GetAxis("Vertical") * speed;
		float rotation = Input.GetAxis("Horizontal") * speedRotation;

		translation *= Time.deltaTime;
		rotation *= Time.deltaTime;

		this.transform.Translate(0, translation,0);
		this.transform.Rotate(0, 0, -rotation);


		//player anime
		anime.SetFloat("speed",translation);


	
		if(Input.GetAxis("Horizontal") < -0.1f){
			Movment.playerMov = Movment.Move.left;
		}else if(Input.GetAxis("Horizontal") > 0.1f){
			Movment.playerMov = Movment.Move.right;
		}else if(Input.GetAxis("Vertical") < -0.1f){
			Movment.playerMov = Movment.Move.down;
		}else if(Input.GetAxis("Vertical") > 0.1f){
			Movment.playerMov = Movment.Move.up;
		}else{
			Movment.playerMov = Movment.Move.center;
		}

		Debug.Log(Input.GetAxis("Vertical"));
	}
}
