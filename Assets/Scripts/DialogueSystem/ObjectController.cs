using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    [SerializeField] Dialogue dialog;
    public void Interact()
    {
        StartCoroutine(DialogueManager.Instance.ShowDialogue(dialog));
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Interact();
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
