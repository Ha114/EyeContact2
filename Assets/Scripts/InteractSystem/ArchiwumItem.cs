using UnityEngine;

public class ArchiwumItem : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        Debug.Log(gameObject.name + " - Interact");
    }

    public string GetDescription()
    {
        return "Open Archiwum";
    }

}
