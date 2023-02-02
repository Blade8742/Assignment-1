using UnityEngine;
using UnityEngine.SceneManagement;

public class Start2 : MonoBehaviour
{
    public void StartGame2 ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
}
