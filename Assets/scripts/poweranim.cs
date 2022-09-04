using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poweranim : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -4f * Time.deltaTime, 0);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
     
        if (collision.gameObject.tag == "Player")
        {

            Destroy(gameObject);

        }
    }
}
