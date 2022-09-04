using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float basebulletspeed = 70f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(basebulletspeed * Time.deltaTime, 0, 0);
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        
        if (col.collider.tag == "nomorepewpewbox" || col.collider.tag == "enemy")
        {
           
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "nomorepewpewbox" || collision.gameObject.tag == "enemy")
        {
            Destroy (gameObject);
        }
    }
}
