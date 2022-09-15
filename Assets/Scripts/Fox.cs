using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        GameObject otherObject = otherCollider.gameObject;
        if (otherObject.GetComponent<Gravestone>())
        {
            Debug.Log("Grave");
            GetComponent<Animator>().SetTrigger("JumpTrigger");
        }
        else if(otherObject.GetComponent<Defender>())
        {
            Debug.Log("Not grave");
            GetComponent<Attacker>().Attack(otherObject);
        }
    }
}
