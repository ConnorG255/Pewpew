using System.Collections;
using UnityEngine.Audio;
using UnityEngine;
using System;

public class sound2 : MonoBehaviour
{
    bool bosslive = false;
    bool live = true;
    public GameObject p;
    public GameObject asdfa;
    public float time;
    public bool asdf = false;


    public Sound[] sounds;
    // Start is called before the first frame update
    void Awake()
    {
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;


            s.source.loop = s.loop;
        }
    }
    void Start()
    {
        
        Play("startbg");
    }
    void Update()
    {

        espawn asdfaa = asdfa.GetComponent<espawn>();
        Player ac = p.GetComponent<Player>();
        
        //sss("startbg");
        if(asdf == true )
        {
            
            Play("son");
        }
        if (Input.GetKey(KeyCode.Z) && ac.lives > 0)
        {
            Play("pewpew");
        }
        if (ac.lives == 0 && live == true)
        {
            Play("ded");
            live = false;
        }

    }
    public void sss(string nam)
    {
        Sound s = Array.Find(sounds, sound => sound.name == nam);
        s.source.volume = s.volume;

    }
    public void Play(string nam)
    {
        Sound s = Array.Find(sounds, sound => sound.name == nam);
        

        s.source.Play();
    }
}
