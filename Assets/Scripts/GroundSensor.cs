using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{
    public bool IsGrounded;
    void OnTriggerEnter2D(Collider2D collider)
    {
        IsGrounded = true;
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
