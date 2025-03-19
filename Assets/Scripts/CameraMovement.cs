using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    
    public Transform playerTransform;
    public Vector3 offset;
    public Vector2 maxPosition;

    public Vector2 minPosition;
    public float interpolationRatio = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 desiredPosition = playerTransform.position + offset;
        float clampX = Mathf.Clamp(desiredPosition.x, minPosition.x, maxPosition.x); //para limitar la posicion de la camara en x
        float clampY = Mathf.Clamp(desiredPosition.y, minPosition.y, maxPosition.y); //pra limitar la posicion de la camar en y
        Vector3 clampedPosition = new Vector3(clampX, clampY, desiredPosition.z);
        Vector3 lerpedPosition = Vector3.Lerp(transform.position, clampedPosition, interpolationRatio);
        transform.position = lerpedPosition;
    }
}
