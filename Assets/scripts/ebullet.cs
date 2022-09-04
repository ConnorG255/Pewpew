using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ebullet : MonoBehaviour
{
    public GameObject play;
    public float ebulletspeed = 10f;
   // int lives;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       // Player li = play.GetComponent<Player>();
       // lives = li.lives;
       // li.lives = lives;

        transform.Translate(0,-ebulletspeed * Time.deltaTime, 0);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "nomorepewpewbox")
        {
            //lives = 1;
            Destroy(gameObject);
        }
    }
    
}

