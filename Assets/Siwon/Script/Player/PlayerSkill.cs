using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkill : MonoBehaviour
{
    public float dmg;

    public float skillDel = 1.5f;

    public float currentDel;

    public float dashdistance;

    public bool isDashing;

    public float dashTime = 0.2f;
    private PlayerInput playerInput;
    private Rigidbody2D rb;

    

    private void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        currentDel += Time.deltaTime;
    }
    private void Update()
    {
        
        #region
        Dash();
        #endregion

    }

    private void Dash()
    {
        if(playerInput.dash == true && currentDel >= skillDel)
        {
            print("Dash");
            rb.velocity = new Vector2(rb.velocity.x,0);
            transform.position = Vector3.Lerp(playerInput.moveInput, new Vector3(playerInput.moveInput.x, playerInput.moveInput.x + dashdistance,0),0.2f);
            currentDel = 0;
        }

    }

}