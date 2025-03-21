using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{
    public bool IsGrounded;

    public Goomba goomba;
    void OnTriggerEnter2D(Collider2D collider)
    {
        IsGrounded = true;
        if(collider.gameObject.layer == 3)
        {
            IsGrounded = true;
            //Debug.Log(collider.gameObject.name);
            //Debug.Log(collider.gameObject.transform.position);
        }
        else if(collider.gameObject.layer == 6)
        {
            goomba = collider.gameObject.GetComponent<Goomba>();
            goomba.Death();
        }
    }

 void OnTriggerStay2D(Collider2D Collider)
 {
    IsGrounded = true;
 }

    void OnTriggerExit2D(Collider2D collider)
    {
        IsGrounded = false;
    }
}
