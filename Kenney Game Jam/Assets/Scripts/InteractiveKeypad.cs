using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public GameObject canvas;
    private bool isPlayerInTrigger = false;
    public KeyPad key;

    void Update()
    {
        if (isPlayerInTrigger && Input.GetKeyDown(KeyCode.E) && !key.canEnter)
        {
            if (!canvas.activeSelf)
            {
                canvas.SetActive(true);
                Time.timeScale = 0f;
                Debug.Log("Canvas shown, game paused");
            }
            else
            {
                canvas.SetActive(false);
                Time.timeScale = 1f;
                Debug.Log("Canvas hidden, game resumed");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isPlayerInTrigger = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isPlayerInTrigger = false;
        }
    }
}
