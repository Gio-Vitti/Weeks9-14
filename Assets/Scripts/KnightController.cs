using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class KnightController : MonoBehaviour
{
    Animator animator;
    SpriteRenderer sr;
    public float speed = 5;
    public bool canRun = true;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float direction = Input.GetAxis("Horizontal");

        sr.flipX = (direction < 0);
        animator.SetFloat("movement", Mathf.Abs(direction));

        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("attack");
            canRun = false;
        }

        if (canRun == true)
        {
            transform.position += transform.right * direction * speed * Time.deltaTime;
            animator.SetTrigger("run");

            //Sound Effects

        }

        //Jump
        if (Input.GetKey("Space"))
        {
            Vector2 pos = transform.position;

            pos.y += 10;

            transform.position = pos;
        }
    }


    public void AttackHasFinished()
    {
        Debug.Log("the attack has finished");
        canRun = true;
    }
}
