using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public string _sceneName;

    public void SceneLoader()
    {
        SceneManager.LoadScene(_sceneName, LoadSceneMode.Additive);
    }
}