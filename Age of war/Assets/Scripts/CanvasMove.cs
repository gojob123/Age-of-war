using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasMove : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    private Vector3 moveDirection = Vector3.zero;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void UpdateMove()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        moveDirection = new Vector3(x, y, 0);
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
        if (transform.position.x > 3950)
        {
            transform.Translate(new Vector3(-5, 0, 0));
        }
        else if (transform.position.x < -3950)
        {
            transform.Translate(new Vector3(5, 0, 0));
        }
        if (transform.position.y > 2930)
        {
            transform.Translate(new Vector3(0, -5, 0));
        }
        else if (transform.position.y < -2930)
        {
            transform.Translate(new Vector3(0, 5, 0));
        }
    }
}
