using UnityEngine;

public class BinocularItem : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        Debug.Log(gameObject.name + " - Interact");
    }

    public string GetDescription()
    {
        return "Interact with Binocular";
    }

}
