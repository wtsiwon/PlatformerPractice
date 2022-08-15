using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerInput : MonoBehaviour
{
    public string moveHorizenAxisName = "Horizontal";
    public string moveVertialAxisName = "Vertical";

    public string fireButtonName = "Fire1";
    public string jumpButtonName = "Jump";
    public string reloadButtonName = "Reload";
    public string dashButtonName = "Dash";

    public Vector2 moveInput { get; private set; }
    public bool jump { get; private set; }
    public bool attack { get; private set; }
    public bool dash { get; private set; }


    private PlayerMovement playerMovement;
    private Rigidbody2D rb;

    private void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (GameManager.Instance != null && GameManager.Instance.isGameOver == true)
        {
            return;
        }

        #region PlayerInput

        Move();
        Jump();
        Attack();
        Dash();

        #endregion

    }
    private void Move()
    {
        moveInput = new Vector2(Input.GetAxisRaw(moveHorizenAxisName),rb.velocity.y);
    }
    private void Jump()
    {
        if (Input.GetButtonDown(jumpButtonName))
        {
            jump = true;
            print(jump);
        }
        else if (Input.GetButtonUp(jumpButtonName))
        {
            jump = false;

            playerMovement.isJump = false;
            print(jump);
        }
    }

    private void Attack()
    {
        if (Input.GetButtonDown(fireButtonName))
        {
            attack = true;
            print("공격" + attack);
        }
        else if (Input.GetButtonUp(fireButtonName))
        {
            attack = false;
            print("공격" + attack);
        }

    }

    private void Dash()
    {
        if (Input.GetKey(KeyCode.D) && Input.GetKeyDown(KeyCode.LeftShift))
        {
            dash = true;
            print("Dash" + dash);
        }
        else if (Input.GetKey(KeyCode.A) && Input.GetKeyDown(KeyCode.LeftShift))
        {
            dash = true;
            print("Dash" + dash);
        }
    }
}
