using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootSpheres : MonoBehaviour
{
    [SerializeField] GameObject ballPrefab;
    [SerializeField] Transform camera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnThrowBall()
    {
        Instantiate(ballPrefab, camera.position + camera.forward, Quaternion.identity).GetComponent<Rigidbody>().AddForce(camera.forward * 2000);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
