using UnityEngine;
using UnityEngine.SceneManagement;

public class Tutorial : MonoBehaviour
{
    public GameObject panel;
    private bool tutorialEnded = false;
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        // Get the scene name
        string sceneName = currentScene.name;

        // Get the scene build index
        int sceneIndex = currentScene.buildIndex;
        if (sceneIndex == 1)
        {
            Time.timeScale = 0f;
        }
        else
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !tutorialEnded)
        {
            Time.timeScale = 1f;
            panel.SetActive(false);
            tutorialEnded = true;
        }
    }
}
