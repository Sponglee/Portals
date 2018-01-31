using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Navigation : MonoBehaviour {
    public GameObject[] wps;
    NavMeshAgent agent;
    public Animator anim;
	// Use this for initialization
	void Start () {
        agent = this.GetComponent<NavMeshAgent>();
        int d = Random.Range(0, wps.Length);
        agent.SetDestination(wps[d].transform.position);
	}
	
	// Update is called once per frame
	void Update () {
        if (agent.remainingDistance < 1)
        {
            agent.isStopped = true;
            anim.SetBool("Attack", true);
            //TowerHealth -= damage * attackSpeed * Time.deltaTime;
        }
        else
            anim.SetBool("Attack", false);
	}
}
