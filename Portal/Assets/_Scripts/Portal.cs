using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour {
	public Transform reciever;
    private SkeletonController skeleton;
	private PlayerController player;
    private Transform playerModel;
    private Transform skeletonModel;
    private GameObject skeletonObject;
    private GameObject playerObject;
	private bool playerIsOverlapping = false;
    private bool skeletonIsOverlapping = false;
	public float playerOffset=5f;


    private void Start()
    {
        skeletonObject = GameObject.FindWithTag("Skeleton");
        playerObject = GameObject.FindWithTag("Player");
        player = playerObject.GetComponent<PlayerController>();
        skeleton = skeletonObject.GetComponent<SkeletonController>();
        
        
    }
    // Update is called once per frame
    void LateUpdate () {
		if (playerIsOverlapping)
        {
			Vector3 portalToPlayer = playerObject.transform.position - transform.position;
			Vector3 positionOffset = new Vector3(playerOffset,0f,0f);
			playerObject.transform.position = reciever.position + positionOffset;
			playerIsOverlapping = false;
      
		}
        else if (skeletonIsOverlapping)
        {
            Vector3 portalToPlayer = skeletonObject.transform.position - transform.position;
            Vector3 positionOffset = new Vector3(playerOffset, 0f, 0f);
            skeletonObject.transform.position = reciever.position + positionOffset;
            skeletonIsOverlapping = false;

        }
    }


    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player" )
        {
            playerIsOverlapping = true;
            
        }
        if (other.tag == "Skeleton")
        {
            skeletonIsOverlapping = true;

        }

    }
    
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
            playerIsOverlapping = false;
        if (other.tag == "Skeleton")
            skeletonIsOverlapping = false;
    }
}	