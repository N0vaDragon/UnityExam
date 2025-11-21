using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{

    public void GoToGameScene()
    {
        SceneManager.LoadScene("GameScene_v01");
    }
    
}
