using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homingbullet : MonoBehaviour
{
    public GameObject enem;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (enem.transform.position - transform.position).normalized * 8 * Time.deltaTime;
    }
}
