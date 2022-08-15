using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EPlayerDir
{
    Left = 180,
    Right = 0
}
public class PlayerAnimation : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private PlayerInput playerInput;

    private EPlayerDir playerDir;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        playerInput = GetComponent<PlayerInput>();
    }

    private void Update()
    {
        MoveAnimation();
    }
    private void MoveAnimationFlip()
    {
        if (Input.GetButtonDown(playerInput.moveHorizenAxisName))
        {
            if (Input.GetAxisRaw(playerInput.moveHorizenAxisName) == 1)
            {
                if (Input.GetAxisRaw(playerInput.moveHorizenAxisName) == -1)
                {
                    playerDir = EPlayerDir.Left;
                }
                playerDir = EPlayerDir.Right;
                print(playerDir);
            }
            else if (Input.GetAxisRaw(playerInput.moveHorizenAxisName) == -1)
            {
                if (Input.GetAxisRaw(playerInput.moveHorizenAxisName) == 1)
                {
                    playerDir = EPlayerDir.Right;
                }
                playerDir = EPlayerDir.Left;
                print(playerDir);
            }
        }
        transform.rotation = new Quaternion(transform.rotation.x, (float)playerDir, transform.rotation.z, transform.rotation.w);
    }
    private void MoveAnimation()
    {
        
    }
}