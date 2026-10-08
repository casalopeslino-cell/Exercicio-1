using UnityEngine;
using TMPro;
public class Pontuação : MonoBehaviour
{
    // Update is called once per frame
    public Transform jogador;
    public TMP_Text contar;
    void Update()
    {
        contar.text = jogador.position.z.ToString("0");  
    }
}
