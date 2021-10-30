using UnityEngine.SceneManagement;
using UnityEngine;

public class GameControllerBehaviour : MonoBehaviour
{
    private Scene scene;
    public void RestartLevel()
    {
        scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
        
    }
}
