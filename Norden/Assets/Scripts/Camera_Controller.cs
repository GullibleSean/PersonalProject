using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour
{
    [SerializeField] public float panSpeed;
    [SerializeField] private float panDetect;

    private float yStart;

    private void Awake()
    {
        yStart = Camera.main.transform.position.y;
    }

    private void Update()
    {
        MoveCamera();
    }

    private void MoveCamera()
    {
        float moveX = Camera.main.transform.position.x;
        float moveZ = Camera.main.transform.position.z;

        float xPosition = Input.mousePosition.x;
        float yPostion = Input.mousePosition.y;

        if (Input.GetKey(KeyCode.LeftArrow) || xPosition > 0 && xPosition < panDetect)
        {
            moveX -= panSpeed;
        }
        else if (Input.GetKey(KeyCode.RightArrow) || xPosition < Screen.width && xPosition > Screen.width - panDetect)
        {
            moveX += panSpeed;
        }

        if (Input.GetKey(KeyCode.UpArrow) || yPostion < Screen.height && yPostion > Screen.height - panDetect)
        {
            moveZ += panSpeed;
        }
        else if (Input.GetKey(KeyCode.DownArrow) || yPostion > 0 && yPostion < panDetect)
        {
            moveZ -= panSpeed;
        }

        Vector3 newPosition = new Vector3(moveX, yStart , moveZ);

        Camera.main.transform.position = newPosition;
    }
}
