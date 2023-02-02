using UnityEngine;
using UnityEngine.SceneManagement;

public class Start3 : MonoBehaviour
{
    public void StartGame3 ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
}
