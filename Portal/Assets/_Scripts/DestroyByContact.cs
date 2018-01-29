using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {
    private BeamPositioner beamPositioner;

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Beam"))
        {
            Destroy(other.gameObject);
            GameObject beamObject = GameObject.FindWithTag("BeamPositioner");
            beamPositioner = beamObject.GetComponent<BeamPositioner>();
            beamPositioner.NewOrb();
        }
        
    }
}
