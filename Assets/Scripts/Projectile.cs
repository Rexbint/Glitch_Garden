using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [Range(0f,5f)] [SerializeField] float speed = 1f;
    [SerializeField] int startingDamage = 25;

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        var health = otherCollider.GetComponent<Health>();
        var attacker = otherCollider.GetComponent<Attacker>();
        if (health&&attacker)
        {
            health.DealDamage(startingDamage);
            Destroy(gameObject);
        }
       
    }
}
