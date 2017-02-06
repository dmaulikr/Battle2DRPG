//Created by Pier Shaw on 11/19/2015
//Copyright © 2014 Pier Shaw.All rights reserved.
//Movment
//piershaw @gmail.com

using UnityEngine;
using System.Collections;

public class followcam : MonoBehaviour {

	// Use this for initialization
	public Transform targetTransform;		// Transform to follow
	private Transform thisTransform;
	private Vector3 pos; 

	void Start () {

	}
	
	void FixedUpdate () {
		pos = new Vector3(targetTransform.position.x, targetTransform.position.y, -4f);
		this.transform.position = Vector3.Lerp(pos,targetTransform.position,-4f);
	}
	
}
