using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject clearbe;

    float bombt = 0.0f;
    public float p = 0.0f;


    public float score = 0.0f;

    public  int lives = 3;
    bool el1 = true;
    bool el2 = true;

    public float pspeed = 20;
    int direct = 0;
    public Animator anim;
    public bool ayaya = false;
    public GameObject shrift;
    public GameObject playr;
    
    void Start()
    {
        clearbe.SetActive(false);
        shrift.SetActive(false);
        anim.SetFloat("Direction", 0);
        GameManVar var = playr.GetComponent<GameManVar>();

    }


    void Update()
    {
        GameManVar var = playr.GetComponent<GameManVar>();
        var.power = p;


        if (Input.GetKeyDown(KeyCode.X) && p >= 20)
        {
           clearbe.SetActive(true);
            p -= 20f;
            bombt = Time.time + 1f;
        }
        if(Time.time > bombt)
        {
            
            clearbe.SetActive(false);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            lives += 1;
        }
        changeanim();
        move();
        
    }
    public void lifemore()
    {
        if(score >= 100000 && el1 == true)
        {
            lives += 1;
            el1 = false;
        }
        if (score >= 200000 && el2 == true)
        {
            lives += 1;
            el2 = false;
        }
    }
    public void move(){

        //ayayayayayaya
        if (Input.GetKey(KeyCode.Z) == false && Input.GetKey(KeyCode.LeftShift) == false && ayaya)
        {
            pspeed = 40;
        }

        /* 
                if (Input.GetKey(KeyCode.Z))
                {
                    pspeed = 20;
                }


               if (Input.GetKeyDown(KeyCode.LeftShift) && Input.GetKey(KeyCode.Z))
                {
                    shrift.SetActive(true);
                    pspeed = 10;
                }       idk something to get ayayayayayaya to work*/


        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            shrift.SetActive(true);
            pspeed = 10;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            shrift.SetActive(false);
            pspeed = 20;
        }

        
        //"getys animations to work but doesnt work right now"-justin chen 

        if (transform.position.x < 1.59 && Input.GetKey(KeyCode.RightArrow))
        {
           // anim.SetFloat("Direction", -2);
            transform.Translate(pspeed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -29)
        {
            //anim.SetFloat("Direction", 2);
            transform.Translate(-pspeed * Time.deltaTime, 0, 0);
        }
        else { anim.SetFloat("Direction", 0); }

        if (transform.position.y < 14.8 && Input.GetKey(KeyCode.UpArrow))
        {
            //anim.SetFloat("Direction", 0);
            transform.Translate(0, pspeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > -14.84)
        {
           //anim.SetFloat("Direction", 0);
            transform.Translate(0, -pspeed * Time.deltaTime, 0);
        }
      
    }
  

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ebullet")
        {
            if (lives == 0)
            {
                playr.SetActive(false);
            }
            else { lives = lives - 1; }


        }
        if (collision.gameObject.tag == "score")
        {

            score += 1000;

        }
        if (collision.gameObject.tag == "power1" && p < 99.99f)
        {

            p += 1f;

        }
    }


    void changeanim()
    {
        switch (direct)
        {
            case 0:
                anim.SetFloat("Direction", 0);
                break;
            case 2:
                anim.SetFloat("Direction", 2);
                break;
            case -2:
                anim.SetFloat("Direction", -2);
                break;

        }
    }
}
