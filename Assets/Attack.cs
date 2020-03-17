using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public Animator animator;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetInteger("Attack", 1);
        }
    }
    public void AttackFinished()
    {
        animator.SetInteger("Attack", 0);
    }
}
