using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraSwitch : MonoBehaviour
{
    public Camera mainCam;
    public Camera secondCam;
    [SerializeField] GameObject ballSpawn;
    [SerializeField] float slowMotionSpeed;

    private void OnEnable()
    {
        mainCam.enabled = true;
        secondCam.enabled = false;
        secondCam.GetComponent<Rigidbody2D>().isKinematic = true;
    }

    public void toggleSecondCam()
    {
        Time.timeScale = slowMotionSpeed;
        secondCam.GetComponent<Rigidbody2D>().isKinematic = false;
        mainCam.enabled = false;
        secondCam.enabled = true;
        ballSpawn.SetActive(false);
    }

}
