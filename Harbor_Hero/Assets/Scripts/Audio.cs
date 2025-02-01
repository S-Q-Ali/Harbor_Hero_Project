using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public static Audio instance;
    public AudioSource coinsource;
    public AudioClip coinsound;
    public AudioSource victorysource;
    public AudioClip victorysound;
    public AudioSource oceansource;
    public AudioClip oceansound;
    public AudioSource crashsource;
    public AudioClip crashsound;
    // public AudioSource boatsource;
    // public AudioClip boatsound;

    // Start is called before the first frame update
    void Start()
    {
        coinsource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void Awake()
    {
        instance = this;
    }

}
