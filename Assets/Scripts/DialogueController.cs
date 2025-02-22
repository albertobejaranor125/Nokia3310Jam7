using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueController : MonoBehaviour
{
    [SerializeField] Dialogue dialog;
    public void Interact()
    {
        StartCoroutine(DialogueManager.Instance.ShowDialogue(dialog));
    }
}
