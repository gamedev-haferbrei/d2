using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SkyboxController : MonoBehaviour
{
    [SerializeField] Material daytimeMaterial;
    [SerializeField] Material nighttimeMaterial;

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
        skybox.material = daytimeMaterial;
    }

    void OnNighttime()
    {
        skybox.material = nighttimeMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
