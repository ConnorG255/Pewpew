using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laseranim : MonoBehaviour
{
    public int speedl;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, speedl * Time.deltaTime);
    }
}
