using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject ebullet1;
    public GameObject ebullet2;
    public GameObject player;
    public GameObject power1;
    public GameObject gold;

   
    public float health = 0f;
    float angleee = 0.0f;

    float e1pewpew = 0.0f;
    float e2pewpew = 0.0f;
    float e4pewpew = 0.0f;
    float e5pewpew = 0.0f;
    float popewpew = 0.0f;
    float depewpew = 0.0f;


    public float e1time = 0.0f;
    bool isleft = false;



    public float fivesec = 5f;
    public string enemytype;
    int asdfasdf = 1;
    // Start is called before the first frame update
    void Start()
    {
        if (transform.position.x > -10)
        {
            isleft = true;
        }
        if (transform.position.x > 10)
        {
            isleft = false;
        }

        e1time = Time.time + 1.75f;

        switch (enemytype)
        {
            case ("justin"):
                health = 2;
                
                break;
            case ("e1"):

                health = 300;

                
                break;
            case ("e2"):

                health = 3000;


                break;
            case ("e4"):
                health = 300;
                break;
            case ("e5"):
                health = 10000;
                break;
            case ("de"):
                health = 30000;
                break;
            case ("po"):
                health = 30000;

                break;
        }
        
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x > -10)
        {
            isleft = true;
        }
        if (transform.position.x > 10)
        {
            isleft = false;
        }












        GameManVar var = player.GetComponent<GameManVar>();
        



        switch (enemytype)
        {
            /*case("justin"):
                
                Instantiate(ebullet1, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));
                Instantiate(ebullet1, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 10)));
                Instantiate(ebullet1, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(new Vector3(0, 0, -10)));
                if (transform.position.x > 1.5)
                {
                    asdfasdf = 2;
                }
                if (transform.position.x < -29)
                {
                    asdfasdf = 1;
                }
                if (transform.position.x < 1.59 && asdfasdf == 1)
                {
                    // anim.SetFloat("Direction", -2);
                    transform.Translate(10 * Time.deltaTime, 0, 0);
                }
                else if (asdfasdf == 2 && transform.position.x > -29)
                {
                    //anim.SetFloat("Direction", 2);
                    transform.Translate(-10 * Time.deltaTime, 0, 0);
                }
                break;*/
            case("e1"):

                
                if(e1time > Time.time)
                {
                    transform.Translate(0, -4f * Time.deltaTime, 0);
                }

                if (isleft)
                {
                    transform.Translate(-4f * Time.deltaTime, 0, 0);
                }
                else { transform.Translate(4f * Time.deltaTime, 0, 0); }
                


                if (Time.time > e1pewpew)
                {
                    e1pewpew = Time.time + 0.5f;
                    Instantiate(ebullet1, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));
                }
                break;

            case ("e2"):


                

                if (isleft)
                {
                    transform.Translate(-1f * Time.deltaTime, 0, 0);
                }
                else { transform.Translate(1f * Time.deltaTime, 0, 0); }



                if (Time.time > e2pewpew)
                {
                    e2pewpew = Time.time + 0.8f;
                    Instantiate(ebullet2, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));
                }
                break;
            case ("e4"):
                if (isleft)
                {
                    transform.Translate(-2f * Time.deltaTime, 0, 0);
                }
                else { transform.Translate(2f * Time.deltaTime, 0, 0); }
                if (Time.time > e4pewpew)
                {
                    

                    e4pewpew = Time.time + 0.7f;
                    Instantiate(ebullet1, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(new Vector3(0, 0, -10)));
                    Instantiate(ebullet1, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(new Vector3(0, 0, -5)));
                    //Instantiate(ebullet1, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));
                    Instantiate(ebullet1, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 5)));
                    Instantiate(ebullet1, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 10)));
                }
                
                break;
            case ("e5"):
                if (isleft)
                {
                    transform.Translate(-0.2f * Time.deltaTime, 0, 0);
                }
                else { transform.Translate(0.2f * Time.deltaTime, 0, 0); }
                if (Time.time > e5pewpew)
                {
                    e5pewpew = Time.time + 0.05f;
                    Instantiate(ebullet2, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(new Vector3(0, 0, angleee)));
                    angleee -= 8;
                }

                break;
            case ("po"):
                if (Time.time > popewpew)
                {
                    popewpew = Time.time + 0.03f;
                    Instantiate(ebullet2, new Vector3(transform.position.x, transform.position.y - 5f, transform.position.z), Quaternion.Euler(new Vector3(0, 0, angleee)));
                    angleee -= 4;
                }
                

                break;
            case ("de"):
                if (Time.time > depewpew)
                {
                    depewpew = Time.time + 0.2f;
                    Instantiate(ebullet1, new Vector3(transform.position.x, transform.position.y - 5f, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));
                    Instantiate(ebullet1, new Vector3(transform.position.x, transform.position.y - 5f, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 5)));
                    Instantiate(ebullet1, new Vector3(transform.position.x, transform.position.y - 5f, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 10)));
                    Instantiate(ebullet1, new Vector3(transform.position.x, transform.position.y - 5f, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 15)));
                    Instantiate(ebullet1, new Vector3(transform.position.x, transform.position.y - 5f, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 20)));
                    Instantiate(ebullet1, new Vector3(transform.position.x, transform.position.y - 5f, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 25)));
                    Instantiate(ebullet1, new Vector3(transform.position.x, transform.position.y - 5f, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 30)));
                    Instantiate(ebullet1, new Vector3(transform.position.x, transform.position.y - 5f, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 35)));
                    Instantiate(ebullet1, new Vector3(transform.position.x, transform.position.y - 5f, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 40)));
                    Instantiate(ebullet1, new Vector3(transform.position.x, transform.position.y - 5f, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 45)));

                }


                break;
        }


        if(health < 0)
        {
            switch (enemytype)
            {
                case ("justin"):
                  //  var.score += 100;
                    Destroy(gameObject);
                    break;
                case ("e1"):
                    // var.scoreint = 1000;
                    Instantiate(power1, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));
                    Instantiate(gold, new Vector3(transform.position.x - 3f, transform.position.y, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));
                    Destroy(gameObject);
                    break;
                case ("e2"):
                    // var.scoreint = 1000;
                    Instantiate(power1, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));
                    Instantiate(gold, new Vector3(transform.position.x - 3f, transform.position.y, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));
                    Instantiate(gold, new Vector3(transform.position.x - 1f, transform.position.y, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));
                    Destroy(gameObject);
                    break;
                case ("e4"):
                    // var.scoreint = 1000;
                    Instantiate(power1, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));
                    Instantiate(gold, new Vector3(transform.position.x - 3f, transform.position.y, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));
                    Destroy(gameObject);
                    break;
                case ("e5"):
                    // var.scoreint = 1000;
                    Instantiate(power1, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));
                    Instantiate(gold, new Vector3(transform.position.x - 3f, transform.position.y, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));
                    Destroy(gameObject);
                    break;
                case ("po"):
                    // var.scoreint = 1000;
                    Instantiate(power1, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));
                    Instantiate(power1, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));
                    Instantiate(gold, new Vector3(transform.position.x - 3f, transform.position.y, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));
                    Instantiate(gold, new Vector3(transform.position.x - 3f, transform.position.y, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));
                    Instantiate(gold, new Vector3(transform.position.x - 3f, transform.position.y, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));
                    Destroy(gameObject);
                    break;
                case ("de"):
                    // var.scoreint = 1000;
                    Instantiate(power1, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));
                    Instantiate(power1, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));
                    Instantiate(gold, new Vector3(transform.position.x - 3f, transform.position.y, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));
                    Instantiate(gold, new Vector3(transform.position.x - 3f, transform.position.y, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));
                    Instantiate(gold, new Vector3(transform.position.x - 3f, transform.position.y, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));
                    Destroy(gameObject);
                    break;
            }
        }




        
    }
    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.collider.tag == "nomorepewpewbox")
        {

            Destroy(gameObject);
        }
        /*if (col.collider.tag == "laser")
        {

            health -= 0.5f;
        } */

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "laser")
        {
            health -= 70f;
        }
        
        if (collision.gameObject.tag == "bullet")
        {
            health -= 50f;
        }
        if (collision.gameObject.tag == "bullet2")
        {
            health -= 125f;
        }
    }
}
