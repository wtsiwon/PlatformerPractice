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


    private void Update()
    {
        if(GameManager.Instance != null && GameManager.Instance.isGameOver == true)
        {
           
            return;
        }

        #region PlayerInput
        
        #endregion

    }
    private void Move()
    {
        Input.GetAxisRaw(moveHorizenAxisName);
    }

}
