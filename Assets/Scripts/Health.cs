using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float startingHealth = 100;
    [SerializeField] GameObject deathVFX;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

    }

    public void DealDamage(float damage)
    {
        startingHealth -= damage;
        if (startingHealth<=0)
        {
            TriggerDeathVFX();
            Destroy(gameObject);
        }
    }

    private void TriggerDeathVFX()
    {
        if (!deathVFX) { return; }
        GameObject deathVFXObject = Instantiate(deathVFX, transform.position,transform.rotation);
        Destroy(deathVFXObject, 1f);
    }
}
