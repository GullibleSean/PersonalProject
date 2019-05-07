using UnityEngine;

public class Resources : MonoBehaviour
{    
    public virtual void Triggered()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //GameManager.Instance.AddDollars(Dollars);
            Triggered();
        }
    }
}
