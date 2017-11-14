using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTest : MonoBehaviour {

    private AudioManager audioManager;

    private void Start()
    {
        audioManager = AudioManager.instance;
        if (audioManager == null)
            Debug.LogError("No AudioManager found in the scene!");

    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            audioManager.PlaySound("gunShot");
        }
        if (Input.GetButtonDown("Fire2"))
        {
            audioManager.PlaySound("cityAmbience");
        }
    }
}
