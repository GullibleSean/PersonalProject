using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectClicker : MonoBehaviour
{
    public Button button;
    public GameObject HQ;

    private void Start()
    {
        if (HQ != null)
        {
            HQ = GameObject.FindGameObjectWithTag("HeadQuarters");
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform != null)
                {
                    PrintName(hit.transform.gameObject);
                }
                if (hit.collider.gameObject.tag == "HeadQuarters")
                {
                    button.gameObject.SetActive(true);
                }
            }
        }
    }

    private void PrintName(GameObject go)
    {
        print(go.name);
    }
}
