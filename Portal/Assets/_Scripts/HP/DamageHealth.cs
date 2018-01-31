using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHealth : MonoBehaviour {
    public int damageAmount = 1;
    public int attackSpeed=1;

    private void OnTriggerEnter(Collider collision)
    {
    
      if (collision.gameObject.tag == "Tower")
        {
            StartCoroutine(DoDamage(collision));
        }
    }

    
    IEnumerator DoDamage(Collider collision)
    {
        while (true)
        {
            Health health = collision.gameObject.GetComponent<Health>();
            health.TakeDamage(damageAmount);
            yield return new WaitForSeconds(attackSpeed);
        }
    }
}
