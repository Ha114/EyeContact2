using UnityEngine;

public class InteractionUI : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] GameObject InteractOptionPrefab;
    public IInteractable CurrentTarget { get; private set; }
    void OnEnable()
    {
        CurrentTarget = null;
        CurrentTarget = Player.gameObject.GetComponent<PlayerInteractor>().CurrentTarget;
    }

    void OnDisable()
    {
        CurrentTarget = null;
    }

    void Start()
    {
        var x = CurrentTarget.GetInteractions();
        Debug.Log("InteractionUI count = " + x.Count);

        foreach( var x2 in x)
        {
            Debug.Log("InteractionUI foreach = " + x2.Description);
            GameObject newOption = Instantiate(InteractOptionPrefab, transform.position, transform.rotation) as GameObject;
            newOption.transform.SetParent(this.transform, false);           //InteractOptionPrefab.SetActive(true);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
