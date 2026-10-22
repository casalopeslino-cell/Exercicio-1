using UnityEngine;
using UnityEngine.SceneManagement;

public class controladorScript : MonoBehaviour
{
    bool fim = false;
    public void acabou()
    {
        fim = true;
        recomecar();
    }

    public void passou()
    {
        SceneManager.LoadScene("Nível 2");
    }
    void recomecar()
    {
        SceneManager.LoadScene("Nível 1");
    }
}
