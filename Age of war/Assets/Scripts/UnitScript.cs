using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitScript : MonoBehaviour
{
    private Animator animator;
    private Vector3 moveDirection = Vector3.zero;
    private bool walk;

    [Header("АјАн")]
    public Transform pos;
    public Vector2 boxSize;
    public AudioClip baseAttackSound;

    void Start()
    {
        animator = GetComponent<Animator>();
        walk = true;
    }
    void Update()
    {
        if(walk == true)
        {
            animator.SetBool("Walking", true);
            Moving();
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            StartCoroutine("BaseAttack");
        }
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            walk = false;
            animator.SetBool("Attacking", true);
        }
        else if (collision.CompareTag("Player"))
        {
            walk = false;
            animator.SetBool("Walking", false);
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        StopCoroutine("BaseAttack");
        animator.SetBool("Attacking", false);
        animator.SetBool("Walking", true);
        Invoke("SetTrue", 0.5f);
    }
    private void Moving()
    {
        moveDirection = new Vector3(1, 0, 0);
        transform.position += moveDirection * 200 * Time.deltaTime;
    }
    private void SetTrue()
    {
        walk = true;
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(pos.position, boxSize);
    }
    private IEnumerator BaseAttack()
    {
        yield return new WaitForSeconds(0.88f);
        Collider2D[] collider2Ds = Physics2D.OverlapBoxAll(pos.position, boxSize, 0);
        foreach (Collider2D collider in collider2Ds)
        {
            if (collider.tag == "Enemy")
            {
            }
        }
        StartCoroutine("BaseAttack");
        SoundManager.SoundEffect.SoundPlay("BaseAttackSound", baseAttackSound);
    }
}