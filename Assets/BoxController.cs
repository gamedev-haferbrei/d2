using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BoxController : MonoBehaviour
{
    [SerializeField] Transform camera;
    [SerializeField] GameObject[] boxPrefabs;
    [SerializeField] RectTransform[] selectionButtons;

    Rigidbody companionCube;

    int selection = 0;
    Rigidbody held = null;

    // Start is called before the first frame update
    void Start()
    {
        Select(0);
    }

    void OnControlBox(InputValue value)
    {
        if (value.isPressed)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit emma;

            if (Physics.Raycast(ray, out emma) && emma.collider.tag == "Box")
            {
                held = emma.collider.gameObject.GetComponent<Rigidbody>();
            }
            else if (selection == 3 && companionCube != null)
            {
                held = companionCube;
            }
            else
            {
                held = Instantiate(boxPrefabs[selection]).GetComponent<Rigidbody>();
                if (selection == 3) companionCube = held;
            }
        } else
        {
            held = null;
        }
    }

    void Select(int n)
    {
        selection = n;
        for (int i = 0; i < selectionButtons.Length; i++)
        {
            if (i == n)
            {
                selectionButtons[i].localScale = new Vector3(1f, 1f, 1f);
            } else
            {
                selectionButtons[i].localScale = new Vector3(0.6f, 0.6f, 0.6f);
            }
        }
    }

    void OnSelectBox1() => Select(0);
    void OnSelectBox2() => Select(1);
    void OnSelectBox3() => Select(2);
    void OnSelectBox4() => Select(3);

    // Update is called once per frame
    void FixedUpdate()
    {
        if (held != null)
        {
            held.MovePosition(camera.position + camera.forward * 4);
        }
    }
}
