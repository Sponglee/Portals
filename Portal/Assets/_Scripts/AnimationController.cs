using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour {
	
	static Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            anim.SetTrigger("walk");
        else if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.A))
            anim.SetTrigger("free");
        else if (Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Mouse1))
            anim.SetTrigger("skill");
        else anim.SetTrigger("free");
    }
}
