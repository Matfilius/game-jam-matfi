using UnityEngine;

public class NewEmptyCSharpScript : MonoBehaviour
{
    public void MuteHandler(bool mute)
    {
        if (mute)
        {
            AudioListener.volume = 0;
        }

        else
        {
            AudioListener.volume = 1;
        }
    }
}
