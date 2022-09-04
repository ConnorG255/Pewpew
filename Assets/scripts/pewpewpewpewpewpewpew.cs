using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pewpewpewpewpewpewpew : MonoBehaviour
{
    public GameObject basebullet;
    public GameObject hbullet;
    public GameObject laser;
    public GameObject susbullet;
    public GameObject game;

    //Vector3 pos;


    public float baseshootnext = 0.0f;
    float susshootnext = 0.0f;

    public float basefirerate = 0.5f;
    public float susfirerate = 0.1f;




    

   // Movement move;
    //[SerializeField] GameObject player;
    
    void Start()
    {
       // move = player.GetComponent<Movement>(); 
        laser.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        //var 
        Player var = game.GetComponent<Player>();

        //pewpew
    
        if (Input.GetKey(KeyCode.Z))
        {
            
            if (Time.time > baseshootnext)
            {
                //base
                baseshootnext = Time.time + basefirerate;
                Instantiate(basebullet, new Vector3(transform.position.x + 0.75f, transform.position.y, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 90)));
                Instantiate(basebullet, new Vector3(transform.position.x - 0.75f, transform.position.y, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 90)));
                //notshift
                if (var.p >= 20)
                {
                    Instantiate(basebullet, new Vector3(transform.position.x + 1.5f, transform.position.y - 2, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 90)));
                    Instantiate(basebullet, new Vector3(transform.position.x - 1.5f, transform.position.y - 2, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 90)));
                }
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    if (var.p >= 40)
                    {
                        Instantiate(basebullet, new Vector3(transform.position.x + 3f, transform.position.y - 2, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 90)));
                        Instantiate(basebullet, new Vector3(transform.position.x - 3f, transform.position.y - 2, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 90)));
                    }
                }
            }
            if(Time.time > susshootnext)
            {
                susshootnext = Time.time + susfirerate;
                if (Input.GetKey(KeyCode.LeftShift) == false)
                {

                    if (var.p >= 20)
                    {
                        Instantiate(susbullet, new Vector3(transform.position.x + 2.25f, transform.position.y - 2, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 90)));
                        Instantiate(susbullet, new Vector3(transform.position.x - 2.25f, transform.position.y - 2, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 90)));

                           }
                    if (var.p >= 40)
                    {
                        Instantiate(susbullet, new Vector3(transform.position.x + 3.3f, transform.position.y - 2, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 90)));
                        Instantiate(susbullet, new Vector3(transform.position.x - 3.3f, transform.position.y - 2, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 90)));

                    }
                }
            }
            
        
    }

        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.Z))
        {
            laser.SetActive(true);
        }

        else { laser.SetActive(false); }

    }

}
 