using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalController : MonoBehaviour {
   
    public GameObject[] portalsLeft;
    public GameObject[] portalsRight;
    public Transform[] spotsLeft;
    public Transform[] spotsRight;
    private int count;
    private int countRight;
    private Transform temp;
    private Transform next;

    // Use this for initialization
    void Start()
    {
        count = 0;
        countRight = 0;
    }


// Update is called once per frame
void Update () {
        if (Input.GetKeyDown(KeyCode.Mouse0))
            {
            count++;
            count = (count % 3);
            for (int i = 0; i < 3; i++)
            {
                portalsLeft[i].transform.position = spotsLeft[((count+ i + 1) % 3)].position;
            }

        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            countRight++;
            countRight = (countRight % 3);
            for (int i = 0; i < 3; i++)
            {
                portalsRight[i].transform.position = spotsRight[((countRight + i + 1) % 3)].position;
            }

        }
    }
}
