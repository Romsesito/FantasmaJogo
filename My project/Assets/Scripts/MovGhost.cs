using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Cube : MonoBehaviour
{
    public float moveSpeed = 5f;
 
    // Start is called before the first frame update
    void Start()
    {
       
    }
 
    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
 
        Vector3 move = new Vector3(moveX, 0f, moveZ) * moveSpeed * Time.deltaTime;
 
        transform.Translate(move);
    }
}