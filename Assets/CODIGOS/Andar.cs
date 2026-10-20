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

    public AudioSource som;
    public AudioClip bater;
    public AudioClip recolher;
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
            som.PlayOneShot(bater);
            vida -= 1;
            health.text = vida.ToString();
            if (vida < 1)
            {
                FindAnyObjectByType<controladorScript>().acabou();
            }
        }
    }
    private void OnTriggerEnter(Collider quem)
    {
        if (quem.gameObject.tag == "Bom")
        {
            som.PlayOneShot(recolher);
            coin += 1;
            coins.text = coin.ToString();
        }
    }

    private void OnCollisionExit(Collision quem)
    {
       if (quem.gameObject.tag == "Plataforma")
        {
            FindAnyObjectByType<controladorScript>().acabou();
        }
    }
}