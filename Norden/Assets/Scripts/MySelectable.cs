using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MySelectable : MonoBehaviour, ISelectHandler, IPointerClickHandler, IDeselectHandler
{
    public static HashSet<MySelectable> allMySelectables = new HashSet<MySelectable>();
    public static HashSet<MySelectable> currentlySelected = new HashSet<MySelectable>();

    Renderer myRenderer;

    [SerializeField] Material unselectedMaterial;
    [SerializeField] Material selectedMaterial;
    [SerializeField] GameObject player;
    public void Awake()
    {
        allMySelectables.Add(this);
        myRenderer = GetComponent<Renderer>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (!Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.RightShift))
        {
            DeselectAll(eventData);
        }
        OnSelect(eventData);
    }

    public void OnSelect(BaseEventData eventData)
    {
        currentlySelected.Add(this);
        myRenderer.material = selectedMaterial;
        canMove();
    }
    public void OnDeselect(BaseEventData eventData)
    {
        myRenderer.material = unselectedMaterial;
        cannotMove();
    }

    public static void DeselectAll(BaseEventData eventData)
    {
        foreach (MySelectable selectable in currentlySelected)
        {
            selectable.OnDeselect(eventData);
        }
        currentlySelected.Clear();
    }

    public void canMove()
    {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }
        else if (player != null)
        {
            player.GetComponent<Player_Character>().enabled = true;
        }
    }

    public void cannotMove()
    {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }
        else if (player != null)
        {
            player.GetComponent<Player_Character>().enabled = false;
        }
    }
}
