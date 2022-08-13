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

    EPlayerDir playerDir;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        playerInput = GetComponent<PlayerInput>();
    }

    private void Update()
    {
        MoveAnimationFlip();
    }
    private void MoveAnimationFlip()
    {
        if (Input.GetButtonDown(playerInput.moveHorizenAxisName))
        {
            if (Input.GetAxisRaw(playerInput.moveHorizenAxisName) == 1)
            {
                playerDir = EPlayerDir.Right;
                print(playerDir);
            }
            else if(Input.GetAxisRaw(playerInput.moveHorizenAxisName) == -1)
            {
                playerDir = EPlayerDir.Left;
                print(playerDir);
            }
        }
        transform.rotation = new Quaternion(transform.rotation.x, (float)playerDir, transform.rotation.z ,transform.rotation.w);
    }

}
