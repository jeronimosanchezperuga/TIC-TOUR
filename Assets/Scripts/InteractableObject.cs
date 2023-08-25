using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public SOInteractableData data;

    public virtual void InteractionBehavior()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            UIManager.Instance.ShowInteraction(data.instructions);
            other.GetComponent<InteractionManager>().currentInteractable = this;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            UIManager.Instance.HideInteraction();
            other.GetComponent<InteractionManager>().currentInteractable = null;
        }
    }
}