using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private PlayerInput playerInput;

    [Tooltip("���� ������")]
    public float atkDelay = 0.5f;

    [Tooltip("������ �ϰ� �ִ°�?")]
    public bool isAttacking;

    [Tooltip("Į")]
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
