using UnityEngine;
using DentedPixel;

public class Bar : MonoBehaviour
{
    public GameObject bar;
    public int time;

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
        LeanTween.scaleX(bar, 0, time);
    }
}
