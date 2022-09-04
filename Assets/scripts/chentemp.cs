using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chentemp : MonoBehaviour
{
    // Start is called before the first frame update
    public float chenspeen = 20;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, chenspeen * Time.deltaTime);
    }
}
