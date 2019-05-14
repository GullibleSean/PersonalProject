using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour
{
    public float startZoom;
    Transform cameraTransform;

    private void Start()
    {
        cameraTransform = Camera.main.transform;

        cameraTransform.position = Vector3.zero;

        cameraTransform.eulerAngles = new Vector3(45f, 0f, 0f);

        cameraTransform .Translate(-Vector3.forward * startZoom);
    }
}
