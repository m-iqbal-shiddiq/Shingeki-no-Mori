using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionScript : MonoBehaviour {

    public GameObject menuPanel;
    public GameObject optionPanel;

    GameObject backMusic;
    AudioSource myMusic;
    public Slider Volume;

    private void Start()
    {
        backMusic = GameObject.FindGameObjectWithTag("Music");
        myMusic = backMusic.GetComponent<AudioSource>();
        Volume.value = myMusic.volume;
    }

    private void Update()
    {
        myMusic.volume = Volume.value;
    }

    public void Back()
    {
        optionPanel.SetActive(false);
        menuPanel.SetActive(true);
    }
}
