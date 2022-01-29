using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour
{
    public bool isMain = true;
    public Camera mainCamera;
    public Camera frontCamera;


    // Call this function to disable FPS camera,
    // and enable overhead camera.
    public void ShowFrontView()
    {
        mainCamera.enabled = false;
        frontCamera.enabled = true;
        isMain = false;
    }

    // Call this function to enable FPS camera,
    // and disable overhead camera.
    public void ShowMainView()
    {
        mainCamera.enabled = true;
        frontCamera.enabled = false;
        isMain = true;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (isMain)
            {
                ShowFrontView();
            }
            else
            {
                ShowMainView();
            }
        }
    }
}
