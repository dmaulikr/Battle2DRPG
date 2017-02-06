//////////////////////////////////////////////////////////////
// FollowTransform.js
// Penelope iPhone Tutorial
//
// FollowTransform will follow any assigned Transform and 
// optionally face the forward vector to match for the Transform
// where this script is attached.
//////////////////////////////////////////////////////////////

#pragma strict

var targetTransform : Transform;		// Transform to follow
var faceForward : boolean = false;		// Match forward vector?
var pos : Vector3; 
private var thisTransform : Transform;

function Start()
{
	// Cache component lookup at startup instead of doing this every frame
	thisTransform = transform;
	pos = new Vector3(0,0,-4);
	
}

function FixedUpdate () 
{
	//thisTransform.position = slerp
		//new Vector3(targetTransform.position.x,targetTransform.position.y,pos.z);
}