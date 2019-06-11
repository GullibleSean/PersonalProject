using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base_Building : MonoBehaviour
{
    [SerializeField] public GameObject building;

    public void Build()
    {
        Ray ray = Camera.main.ScreenPointToRay(new Vector3(Camera.main.transform.position.x + Screen.width/2, Camera.main.transform.position.z + Screen.height/2, 0));
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.tag == "Floor" && hit.collider.tag != "Wall")
            {
                    Instantiate(building, new Vector3(hit.point.x, hit.point.y + 5, hit.point.z), Quaternion.identity);
            }
        }
    }
}
