using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamPositioner : MonoBehaviour {
    public GameObject spotLight;
    public Transform[] orbSpots;
    public Transform[] beamSpots;
    public GameObject Beam;
    public GameObject orb;
    public GameObject spotlight;
    private Animator flash;
    public float intense;
    private Transform randomSpawn;
  
    private Light myLight;
   
	// Use this for initialization
	void Start () {
        flash = spotlight.GetComponent<Animator>();
  
        myLight = spotLight.GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Mouse2))
        {
            NewOrb(); 
           
           
        }

	}

    public void NewOrb()
    {
        int rng = Random.Range(0, 3);
        myLight.intensity = intense;
        flash.SetTrigger("Beam");
        randomSpawn = beamSpots[rng];
        transform.LookAt(randomSpawn);
        Instantiate(orb, orbSpots[rng]);
        Instantiate(Beam, transform);
        myLight.intensity = 33;
      
      
    }
}
