using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerScript : MonoBehaviour
{
    public float moveSpeed;
    private float horizontal;
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
    }
    private void FixedUpdate()
    {
        transform.Translate(Vector3.right * moveSpeed * horizontal * Time.deltaTime);
    }
}
