using UnityEngine;
using DentedPixel;
using UnityEngine.SceneManagement;

public class Bar : MonoBehaviour
{
    public GameObject bar;
    public int time;
    public GameObject panel;

    void Start()
    {
        AnimateBar();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AnimateBar()
    {
        LeanTween.scaleX(bar, 0, time).setOnComplete(GameOver);
    }

    private void GameOver()
    {
        panel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Retry()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}