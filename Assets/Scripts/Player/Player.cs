using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Stats")]
    public float moveSpeed = 20;
    public float maxSpeed = 10;
    public float attackDelay = 0.5f;

    [Header("References")]
    private Rigidbody rigid;
    public Transform firePoint;
    public GameObject rainbow;

    // Use this for initialization
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        attackDelay -= Time.deltaTime;
    }

    void Move()
    {
        float inputV = Input.GetAxis("Vertical");
        float inputH = Input.GetAxis("Horizontal");

        Vector3 force = new Vector3(inputH, 0, inputV);

        if(rigid.velocity.magnitude < maxSpeed)
        {
            rigid.AddForce(force * moveSpeed);
        }
            
    }

    void Attack()
    {
        if(Input.GetKeyDown(KeyCode.Space) && attackDelay <=0)
            {
            Instantiate(rainbow, firePoint.position, transform.rotation);
            attackDelay = 1;
        }
    }

    void OnCollisionEnter(Collision hit)
    {
        if(hit.collider.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
