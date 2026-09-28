using UnityEngine;

public class MapItem : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        Debug.Log(gameObject.name + " - Interact");
    }

    public string GetDescription()
    {
        return "Interact with map";
    }

}
