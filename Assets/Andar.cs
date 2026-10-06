using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Andar : MonoBehaviour
{
    public Rigidbody variavel;
    void Update()
    {
        variavel.AddForce(0, 0, 5);
        if (Keyboard.current.aKey.isPressed)
        {
            variavel.AddForce(-10, 0, 0);
        }
        if (Keyboard.current.dKey.isPressed)
        {
            variavel.AddForce(10, 0, 0);
        }
    }
}
