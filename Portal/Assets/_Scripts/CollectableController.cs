using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableController : MonoBehaviour {
    public int points;
    private GameController gameController;
    private BeamPositioner beamPositioner;
    // Use this for initialization
    void Start () {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        GameObject beamControllerObject = GameObject.FindWithTag("BeamPositioner");
        if ((gameControllerObject != null) || (beamControllerObject !=null))
            {
            gameController = gameControllerObject.GetComponent<GameController>();
            beamPositioner = beamControllerObject.GetComponent<BeamPositioner>();
        }
            
        if ((gameController == null) || (beamPositioner == null))
            Debug.Log("Cannot find script");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            gameController.AddScore(points);
            Destroy(gameObject);
            beamPositioner.NewOrb();
        }
    }
}
