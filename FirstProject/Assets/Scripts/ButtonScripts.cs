using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonScripts : MonoBehaviour
{
    [SerializeField] private Button scene1Button, scene2Button, scene3Button, backButton;
    private string sceneToLoad;

    // Start is called before the first frame update
    void Start()
    {
        scene1Button.onClick.AddListener(LoadScene1);
        scene2Button.onClick.AddListener(LoadScene2);
        scene3Button.onClick.AddListener(LoadScene3);
        backButton.onClick.AddListener(ToSelection);
    }

    void LoadScene1()
    {
        sceneToLoad = "FirstScene";
        SceneManager.LoadScene(sceneToLoad);
    }

    void LoadScene2()
    {
        sceneToLoad = "SecondScene";
        SceneManager.LoadScene(sceneToLoad);
    }

    void LoadScene3()
    {
        sceneToLoad = "ThirdScene";
        SceneManager.LoadScene(sceneToLoad);
    }

    void ToSelection()
    {
        sceneToLoad = "SampleScene";
        SceneManager.LoadScene(sceneToLoad);
    }
}
