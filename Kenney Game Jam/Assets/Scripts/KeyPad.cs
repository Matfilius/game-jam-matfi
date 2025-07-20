using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class KeyPad : MonoBehaviour
{
    public TMP_InputField charHolder;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject button5;
    public GameObject button6;
    public GameObject button7;
    public GameObject button8;
    public GameObject button9;
    public GameObject button0;
    public GameObject clearButton;
    public GameObject enterButton;
    public bool canEnter = false;
    public DoorTrigger dt;
    public AudioManager audioManager;

    public void b1()
    {
        charHolder.text = charHolder.text + "1";
        audioManager.PlaySFX(audioManager.enternumber);
    }

    public void b2()
    {
        charHolder.text = charHolder.text + "2";
        audioManager.PlaySFX(audioManager.enternumber);
    }

    public void b3()
    {
        charHolder.text = charHolder.text + "3";
        audioManager.PlaySFX(audioManager.enternumber);
    }

    public void b4()
    {
        charHolder.text = charHolder.text + "4";
        audioManager.PlaySFX(audioManager.enternumber);
    }

    public void b5()
    {
        charHolder.text = charHolder.text + "5";
        audioManager.PlaySFX(audioManager.enternumber);
    }

    public void b6()
    {
        charHolder.text = charHolder.text + "6";
        audioManager.PlaySFX(audioManager.enternumber);
    }

    public void b7()
    {
        charHolder.text = charHolder.text + "7";
        audioManager.PlaySFX(audioManager.enternumber);
    }

    public void b8()
    {
        charHolder.text = charHolder.text + "8";
        audioManager.PlaySFX(audioManager.enternumber);
    }

    public void b9()
    {
        charHolder.text = charHolder.text + "9";
        audioManager.PlaySFX(audioManager.enternumber);
    }

    public void b0()
    {
        charHolder.text = charHolder.text + "0";
        audioManager.PlaySFX(audioManager.enternumber);
    }


    public void clearEvent()
    {
        charHolder.text = null;
        audioManager.PlaySFX(audioManager.back);
    }

    public void enterEvent()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        string sceneName = currentScene.name;

        int sceneIndex = currentScene.buildIndex;
        if (sceneIndex == 1){
            if (charHolder.text == "5936")
            {
                Debug.Log("Success");
                audioManager.PlaySFX(audioManager.success);
                canEnter = true;
                charHolder.text = null;
                charHolder.text = charHolder.text + "Success";
                dt.canvas.SetActive(false);
                Time.timeScale = 1f;
            }
            else
            {
                Debug.Log("Failure");
                charHolder.text = null;
                charHolder.text = charHolder.text + "Fail";
                ShowFailMessage();
                charHolder.text = null;
            }
        }
        else if(sceneIndex == 2)
        {
            if (charHolder.text == "8207")
            {
                audioManager.PlaySFX(audioManager.success);
                Debug.Log("Success");
                canEnter = true;
                charHolder.text = null;
                charHolder.text = charHolder.text + "Success";
                dt.canvas.SetActive(false);
                Time.timeScale = 1f;
            }
            else
            {
                Debug.Log("Failure");
                charHolder.text = null;
                charHolder.text = charHolder.text + "Fail";
                ShowFailMessage();
                charHolder.text = null;
            }
        }
        else if (sceneIndex == 3)
        {
            if (charHolder.text == "4918")
            {
                audioManager.PlaySFX(audioManager.success);
                Debug.Log("Success");
                canEnter = true;
                charHolder.text = null;
                charHolder.text = charHolder.text + "Success";
                dt.canvas.SetActive(false);
                Time.timeScale = 1f;
            }
            else
            {
                Debug.Log("Failure");
                charHolder.text = null;
                charHolder.text = charHolder.text + "Fail";
                ShowFailMessage();
                charHolder.text = null;
            }
        }

    }

    private IEnumerator ShowFailMessage()
    {
        yield return new WaitForSeconds(1f);
    }
}
