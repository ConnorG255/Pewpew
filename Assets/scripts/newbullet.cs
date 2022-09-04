using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newbullet : MonoBehaviour
{
    public float overallsped= 20f;
    public float ssped = 1.2f;
    // Start is called before the first frame update
    void Start()
    {

    }
    void Awake()
    {
   

    }
    // Update is called once per frame
    void Update()
    {
        
        
        transform.Translate(overallsped * Time.deltaTime, 0, 0);
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.collider.name == "nomorepewpewbox")
        {

            Destroy(gameObject);
        }
    }
}
