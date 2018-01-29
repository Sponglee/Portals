using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour {
	public Transform player;
	public Transform reciever;
	private bool playerIsOverlapping = false;
	public float playerOffset=5f;

	// Update is called once per frame
	void LateUpdate () {
		if (playerIsOverlapping) {
			Vector3 portalToPlayer = player.position - transform.position;
			Vector3 positionOffset = new Vector3(playerOffset,0f,0f);
			player.position = reciever.position + positionOffset;
			playerIsOverlapping = false;
      
		}
	}


    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player" )
        {
            playerIsOverlapping = true;
           
        }
			
	}
    
   /* void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
            playerIsOverlapping = false;
    }*/
}	
