using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerScript : MonoBehaviour
{
    public float moveSpeed;
    private float horizontal;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        
    }
    private void FixedUpdate()
    {

        transform.Translate(Vector3.right * moveSpeed * horizontal * Time.deltaTime);
    }
}
