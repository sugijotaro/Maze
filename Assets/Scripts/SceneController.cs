using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public Button button;
    public string sceneName;

    void Start()
    {
        button.onClick.AddListener(ChangeScene);
    }

    void ChangeScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
