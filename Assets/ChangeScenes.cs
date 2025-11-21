using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{

    public void GoToLoreScene()
    {
        SceneManager.LoadScene("LoreScene_v01");
    }
    
}
