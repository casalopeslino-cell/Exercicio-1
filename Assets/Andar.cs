using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.Universal;
using TMPro;

public class Andar : MonoBehaviour
{
    public Rigidbody variavel;
    public float vida = 10;
    public float coin = 0;

    public TMP_Text coins;
    public TMP_Text health;
    void FixedUpdate()
    {
        variavel.AddForce(0, 0, 9);
        if (Keyboard.current.aKey.isPressed)
        {
            variavel.AddForce(-10, 0, 0);
        }
        if (Keyboard.current.dKey.isPressed)
        {
            variavel.AddForce(10, 0, 0);
        }
    }
    private void OnCollisionEnter(Collision quem)
    {
        if (quem.gameObject.tag == "Mau")
        {
            vida -= 1;
            health.text = vida.ToString();
        }
    }
    private void OnTriggerEnter(Collider quem)
    {
        if (quem.gameObject.tag == "Bom")
        {
            coin += 1;
            coins.text = coin.ToString();
        }
    }
}