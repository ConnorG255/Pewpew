using System.Collections;
using UnityEngine.Audio;
using UnityEngine;
using System;

public class audiomanager : MonoBehaviour
{
    public GameObject start;
    public float sou;
    
    public Sound[] sounds;
    // Start is called before the first frame update
    void Awake ()
    {
        foreach (Sound s in sounds)
        {
           s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = sou;


            s.source.loop = s.loop;
        }
    }
    void Start()
    {

        Play("startbg");
    }
    void Update()
    {
        startmenumanager startsound = start.GetComponent<startmenumanager>();
        sou = startsound.vol2;
        sss("startbg");
        
        

    }
    public void sss(string nam)
    {
        Sound s = Array.Find(sounds, sound => sound.name == nam);
        s.source.volume = sou;
        
    }
    public void Play (string nam)
    {
        Sound s = Array.Find(sounds, sound => sound.name == nam);
        
        s.source.Play();
    }
}
