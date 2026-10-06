using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

public class seguir : MonoBehaviour
{
    public Transform PALL;
    public Vector3 ML;
    void Update()
    {
        transform.position = PALL.position + ML;
    }
}
