using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class animP2 : MonoBehaviour
{
    public Animator animator;
    public float moveSpeed, dirX;

    public LayerMask enemyLayer;
    public Transform attackPoint;
    public float attackRange = 0.5f;

    public int attackDamage = 20;
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 500;
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxisRaw("HorizontalPlayer2") * moveSpeed * Time.deltaTime;

        if (dirX != 0)
            animator.SetBool("isWalking", true);
        else
            animator.SetBool("isWalking", false);


        //Attack
        if (Input.GetButtonDown("AttackPlayer2"))
        {
            animator.SetBool("isAttacking", true);
            Attack();
        }
        else
        {
            animator.SetBool("isAttacking", false);
        }
    }
    void Attack()
    {
        //DETECT
        Collider2D[] hitEnemy = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayer);
        //DAMAGE
        foreach (Collider2D enemy in hitEnemy)
        {
            Debug.Log("DMAGED YER SON " + enemy.name);
            enemy.GetComponent<HealthP1>().TakeDamage(attackDamage);
        }
    }
}
