using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasMove : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    private Vector3 moveDirection = Vector3.zero;
    private void Start()
    {
    }
    private void Update()
    {
        UpdateMove();
    }
    public void UpdateMove()
    {
        float x = Input.GetAxisRaw("Horizontal");
        moveDirection = new Vector3(x, 0, 0);
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
        if (transform.position.x >= 1575)
        {
            //transform.Translate(new Vector3(-5, 0, 0));
            transform.position = new Vector3(1575, 540, -1);
        }
        else if (transform.position.x <= 345)
        {
            //transform.Translate(new Vector3(5, 0, 0));
            transform.position = new Vector3(345, 540, -1);
        }
    }
}