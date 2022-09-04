using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bg : MonoBehaviour
{
    public int bgscrollspeed = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -137)
        {
            transform.Translate(0, 216, 0);
        }
        transform.Translate(0, -bgscrollspeed * Time.deltaTime, 0);
    }
}
