using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private PlayerInput playerInput;

    [Tooltip("공격 딜래이")]
    public float atkDelay = 0.5f;

    [Tooltip("공격을 하고 있는가?")]
    public bool isAttacking;

    [Tooltip("칼")]
    public GameObject sword;
    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
    }

    private void Update()
    {
        #region
        Attack();
        #endregion
    }

    private void Attack()
    {
        if(playerInput.attack == true && isAttacking == false)
        {
            StartCoroutine(CAttackDelay());
        }
    }
    private IEnumerator CAttackDelay()
    {
        isAttacking = true;
        yield return new WaitForSeconds(atkDelay);
    }
}
