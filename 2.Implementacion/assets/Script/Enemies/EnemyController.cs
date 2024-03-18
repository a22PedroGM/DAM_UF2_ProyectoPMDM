using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public SpriteRenderer sr;
    public int maxHealth = 100;

    public GameObject pointA;
    public GameObject pointB;

    public Rigidbody2D rb;

    private Transform currentPoint;

    public int speed = 3;

    int currentHealth;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        currentPoint = pointB.transform;
        currentHealth = maxHealth;
    }

    void Update()
{
    if (Vector2.Distance(transform.position, currentPoint.position) < 1f)
    {
        ChangeDestination();
    }

    transform.position = Vector2.MoveTowards(transform.position, currentPoint.position, speed * Time.deltaTime);
}

void ChangeDestination()
{
    if (currentPoint == pointA.transform)
    {
        currentPoint = pointB.transform;
        sr.flipX = false;
    }
    else
    {
        currentPoint = pointA.transform;
        sr.flipX = true;
    }
}

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        anim.SetTrigger("Hurt");
        if(currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        anim.SetBool("IsDead", true);
        GetComponent<Collider2D>().enabled = false;
        sr.enabled = false;
        this.enabled = false;
    }
}
