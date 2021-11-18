using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitchButton : MonoBehaviour
{
    public string levelName;

    public void OnClick()
    {
        SceneManager.LoadScene(levelName);
    }

}
