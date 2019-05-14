using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public float startZoom;

    Transform cameraTrans;

    /*void awake()
    {
        cameraTrans = Camera.main.transform;

        cameraTrans.position = Vector3.zero;

        cameraTrans.eulerAngles = new Vector3(45f, 0f, 0f);

        cameraTrans.Translate(-Vector3.forward * startZoom);
    }
    */
}
