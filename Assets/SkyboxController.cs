using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SkyboxController : MonoBehaviour
{
    [SerializeField] Material daytimeMaterial;
    [SerializeField] Material nighttimeMaterial;
    [SerializeField] Light daylight;

    Skybox skybox;

    // Start is called before the first frame update
    void Start()
    {
        skybox = GetComponentInChildren<Skybox>();
        var playerInput = GetComponent<PlayerInput>();
        playerInput.actions.Enable();
    }

    void OnDaytime()
    {
        daylight.intensity = 2;
        skybox.material = daytimeMaterial;
    }

    void OnNighttime()
    {
        daylight.intensity = 0;
        skybox.material = nighttimeMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
