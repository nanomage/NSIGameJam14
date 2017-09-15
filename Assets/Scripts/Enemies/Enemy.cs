using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("Stats")]
    public float moveSpeed = 5f;
    public float attackDelay = 1f;

    [Header("References")]
    public Player player;
    private Rigidbody rigid;

    // Use this for initialization
    protected virtual void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        player = GameObject.Find("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        //if the player is null
        if (player == null)
            return;

        Move();
        Attack();
    }

    protected virtual void Move()
    {
        rigid.AddForce(Vector3.forward * moveSpeed);
    }

    protected virtual void Attack()
    {

    }

}
