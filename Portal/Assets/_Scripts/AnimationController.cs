using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour {
    private bool turnLeft;
	static Animator anim;

	// Use this for initialization
	void Start () {
        turnLeft = false;
		anim = GetComponent<Animator> ();
	}

    // Update is called once per frame
    void Update() {
       
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            turnLeft = true;
            anim.SetBool("walk", true);
        }


        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            turnLeft = false;
            anim.SetBool("walk", true);
        }


        else if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.A))
            anim.SetBool("walk",false);
        if (turnLeft)
            transform.rotation = Quaternion.Euler(0, -90, 0);
        else
            transform.rotation = Quaternion.Euler(0, 90, 0);
        if (Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Mouse1))
            anim.SetTrigger("skill");
       
    }
}
