using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class espawn : MonoBehaviour
{
    public float time = 0.0f;
    bool s1 = true;
    bool s2 = true;
    bool s3= true;
    bool s4 = true;
    bool s5 = true;
    bool s6 = true;
    bool s7 = true;
    bool s8 = true;
    bool s9 = true;


    public GameObject asdfjkl;
    public GameObject e1;
    public int e1spawn = 0;
    float e1spawnnext = 0.0f;


    public GameObject e2;
    public int e2spawn = 0;
    float e2spawnnext = 0.0f;

    public int e3spawn = 0;
    float e3spawnnext = 0.0f;

    public GameObject e4;
    public int e4spawn = 0;
    float e4spawnnext = 0.0f;

    public GameObject e5;
    public int e5spawn = 0;

    public GameObject e7;
    public int e7spawn = 0;
    public GameObject e8;
    public int e8spawn = 0;

    int e1count = 3;
    // Start is called before the first frame update
    void Start()
    {
        s1 = true;
    }

    // Update is called once per frame
    void Update()
    {
        time = Time.time;

        if(Time.time > 5f && s1 == true)
        {

            e1spawn = 5;
            s1 = false;
        }
        if (Time.time > 8f && s2 == true)
        {
            e2spawn = 8;
            s2 = false;
        }
        if (Time.time > 16f && s4 == true)
        {
            e4spawn = 15;
            s4 = false;
        }


        //e3 after e4
        if (Time.time > 50f && s3 == true)
        {
            e3spawn = 17;
            s3 = false;
        }
        if (Time.time > 72f && s5 == true)
        {
            e5spawn = 1;
            s5 = false;
        }
        if (Time.time > 113f && Time.time < 120f)
        {
            s1 = true;
        }
        else { s1 = false; }




        if (Time.time > 130f && s5 == true)
        {
            e7spawn = 1;
            s7 = false;
        }
        if (Time.time > 130f && s8 == true)
        {
            asdfjkl.SetActive(true);
            e8spawn = 1;
            s8 = false;
        }




        if (e1spawn > 0 && e1spawnnext < Time.time)
        {
            e1spawnnext = Time.time + 0.5f;
            Instantiate(e1, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));
            Instantiate(e1, new Vector3(transform.position.x-34, transform.position.y, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));
            e1spawn -= 1;
        }
        if (e2spawn > 0 && e2spawnnext < Time.time)
        {
            e2spawnnext = Time.time + 10f;
            Instantiate(e2, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));
            Instantiate(e2, new Vector3(transform.position.x - 34, transform.position.y, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));
            e2spawn -= 1;
        }
        if (e3spawn > 0 && e3spawnnext < Time.time)
        {
            e3spawnnext = Time.time + 0.7f;
            Instantiate(e1, new Vector3(transform.position.x, transform.position.y+5, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));
            Instantiate(e1, new Vector3(transform.position.x - 34, transform.position.y+5, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));
            Instantiate(e1, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));
            Instantiate(e1, new Vector3(transform.position.x - 34, transform.position.y, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));
            Instantiate(e1, new Vector3(transform.position.x, transform.position.y-5, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));
            Instantiate(e1, new Vector3(transform.position.x - 34, transform.position.y-5, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));
            e3spawn -= 1;
        }
        if (e4spawn > 0 && e4spawnnext < Time.time)
        {
            e4spawnnext = Time.time + 2f;
            Instantiate(e4, new Vector3(transform.position.x, transform.position.y-5, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));
            Instantiate(e4, new Vector3(transform.position.x - 34, transform.position.y, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));
            
            e4spawn -= 1;
        }
        if (e5spawn > 0)
        {
            
            Instantiate(e5, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));
            Instantiate(e5, new Vector3(transform.position.x - 34, transform.position.y, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));

            e5spawn -= 1;
        }
        if (e7spawn > 0)
        {

            Instantiate(e5, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));
            Instantiate(e5, new Vector3(transform.position.x - 34, transform.position.y, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));
            e7spawn -= 1;
            
        }
        if (e8spawn > 0)
        {

            Instantiate(e8, new Vector3(-1.11f, 10, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));
            Instantiate(e7, new Vector3(-25.24f, 10, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));
            e8spawn -= 1;

        }
    }
}
