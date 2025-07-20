using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public GameObject panel;
    private bool tutorialEnded = false;
    void Start()
    {
        Time.timeScale = 0f;
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
