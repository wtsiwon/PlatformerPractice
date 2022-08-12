using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private PlayerInput playerInput;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        playerInput = GetComponent<PlayerInput>();
    }

    private void Update()
    {
        AnimationFlip();
    }
    private void AnimationFlip()
    {
        if (Input.GetButtonDown(playerInput.moveHorizenAxisName))
        {
            spriteRenderer.flipX = Input.GetAxisRaw(playerInput.moveHorizenAxisName) == -1;
        }
    }




}
