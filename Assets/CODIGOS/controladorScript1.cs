using UnityEngine;
using UnityEngine.SceneManagement;

public class controladorScript1 : MonoBehaviour
{
    public GameObject opi;
    bool fim = false;
    public void acabou()
    {
        fim = true;
        recomecar();
    }

    public void passou()
    {
        opi.SetActive(true);
        Time.timeScale = 0f;
    }
    void recomecar()
    {
        SceneManager.LoadScene("Nível 1");
    }
}
