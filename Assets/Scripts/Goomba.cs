using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goomba : MonoBehaviour
{
    public float playerSpeed = 4.5f;
    public int direction = 1;
    // Start is called before the first frame update
    void Start()
    {
        //tp al goomba
        //transform.position = new Vector3 (0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(transform.position.x + direction * playerSpeed * Time.deltaTime, transform.position.y, transform.position.z);
        transform.Translate(new Vector3 (direction * playerSpeed * Time.deltaTime, 0, 0));
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(transform.position.x + direction, transform.position.y), playerSpeed * Time.deltaTime);
    }
}
