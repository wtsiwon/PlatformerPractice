using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct PlayerCondition
{
    public bool isStun;
    public bool isJump;
    public bool isMove;
}
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
    private PlayerAttack playerAttack;

    private void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
        playerAttack = GetComponent<PlayerAttack>();
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
        #endregion

    }
    private void Move()
    {
        moveInput = new Vector2(Input.GetAxisRaw(moveHorizenAxisName), 0);
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
            playerAttack.isAttacking = false;
        }

    }

    private void Dash()
    {
        if (Input.GetButtonDown(dashButtonName) && Input.GetButtonDown(moveHorizenAxisName))
        {
            dash = true;
            print("Dash" + dash);
        }
        else
        {
            
        }
    }
}
