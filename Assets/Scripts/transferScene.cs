using UnityEngine;
using UnityEngine.SceneManagement;


public class transferScene : MonoBehaviour
{

    public void changeMenuScene(string sceneName)
    {
       SceneManager.LoadScene(sceneName);
    }
}
