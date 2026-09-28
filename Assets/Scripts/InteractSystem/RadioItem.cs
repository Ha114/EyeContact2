using UnityEngine;

public class RadioItem : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        Debug.Log(gameObject.name + " - Interact");
    }

    public string GetDescription()
    {
        return "Turn on/off radio";
    }

}
