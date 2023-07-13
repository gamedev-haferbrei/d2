using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    [SerializeField] AudioClip flashlightSfx;

    bool on = false;
    AudioSource audioSource;
    Light light;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        light = GetComponentInChildren<Light>();
        UpdateEnabled();
    }

    void OnFlashlight()
    {
        on = !on;
        audioSource.PlayOneShot(flashlightSfx);
        UpdateEnabled();
    }

    void UpdateEnabled()
    {
        light.enabled = on;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
