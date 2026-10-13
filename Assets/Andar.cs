using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.Universal;

public class Andar : MonoBehaviour
{
    public Rigidbody variavel;
    private void OnCollisionEnter(Collision quem)
    {
       if (quem.gameObject.tag == "Mau")
        {
            transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
        }
    }
    void FixedUpdate()
    {
        variavel.AddForce(0, 0, 10);
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
