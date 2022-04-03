using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collision : MonoBehaviour
{
    [SerializeField] cameraSwitch cameraSwitcher;

    private void Start()
    {
        cameraSwitcher = cameraSwitcher.GetComponent<cameraSwitch>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Respawn")
        {
            if (cameraSwitcher == null) { return; }
            cameraSwitcher.toggleSecondCam();
        }
    }
}
