using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteractor : MonoBehaviour
{
    public Camera mainCamera;
    public float interactionDistance = 3f;
    public GameObject interactionUI;
    public TextMeshProUGUI interactionText;

    private bool hitSomething;
    private IInteractable interactable;

    [SerializeField] private InputActionReference interactAction;

    void OnEnable()
    {
        interactAction.action.performed += InteracteInput;
        interactAction.action.canceled += InteracteInput;
    }

    void OnDisable()
    {
        interactAction.action.performed -= InteracteInput;
        interactAction.action.canceled -= InteracteInput;
    }

    private void InteracteInput(InputAction.CallbackContext context)
    {
        if (hitSomething && interactable != null)
        {
            interactable.Interact();
        }
    }


    void Update()
    {
       HandleInteraction();
    }

    void HandleInteraction()
    {
        Ray ray = mainCamera.ViewportPointToRay(Vector3.one/2f);
        RaycastHit hit;

        hitSomething = false;

        if (Physics.Raycast(ray, out hit, interactionDistance))
        {
            if (hit.collider.gameObject.TryGetComponent(out interactable))
            {
                hitSomething = true;
                interactionText.text = interactable.GetDescription();
            }
        }
        interactionUI.SetActive(hitSomething);    
    }
}
