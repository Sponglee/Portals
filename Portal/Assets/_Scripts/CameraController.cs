using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	public Transform target; 
	public float smootSpeed= 0.125f; 
	public Vector3 offset; 



	// Update is called once per frame 
	void LateUpdate () { 
		/*Vector3 desiredPosition = target.position + offset; 
		Vector3 smoothedPosition = Vector3.Lerp (transform.position, desiredPosition, smootSpeed); 
		transform.position = smoothedPosition; */
		transform.LookAt (target); 
	

		}
}