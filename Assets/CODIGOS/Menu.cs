using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void iniciar()
    {
        SceneManager.LoadScene(0);
    }

    public void acabou()
    {
        Application.Quit();
    }
}
