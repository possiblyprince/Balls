using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playPause : MonoBehaviour
{
    // Start is called before the first frame update
    bool isPaused = false;
    [SerializeField] Canvas playPauseCanvas;
    [SerializeField] Image toChange;
    [SerializeField] Sprite play;
    [SerializeField] Sprite pause;
    void Start()
    {
        toChange.GetComponent<Image>().sprite = pause;
    }

    public void pausePlay()
    {
        if (isPaused == false)
        {
            toChange.GetComponent<Image>().sprite = play;
            Time.timeScale = 0;
            isPaused = true;
        }

        else
        {
            toChange.GetComponent<Image>().sprite = pause;
            Time.timeScale = 1;
            isPaused = false;
        }
    }
}
