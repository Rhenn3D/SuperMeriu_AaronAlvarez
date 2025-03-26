using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    public float bulletForce = 7.5f;



    void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        rigidbody.AddForce(Vector2.right * bulletForce, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.layer == 6);
        {
            Goomba enemyScript = collider.gameObject.GetComponent<Goomba>();
            enemyScript.Death();
            BulletDeath();
        }
        if(collider.gameObject.layer == 3)
        {
            BulletDeath();
        }
    }
    void BulletDeath()
    {
        Destroy(gameObject);
    }
}
