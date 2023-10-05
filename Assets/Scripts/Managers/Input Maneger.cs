using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InputManeger
{
    private static Controles _controls;

    public static void init(Player myPlayer)
    {
            _controls = new Controles();
            _controls.Permanent.Enable();
        
        _controls.Game.Movement.performed += ctx =>
        {
            myPlayer.SetMovementDirection(ctx.ReadValue<Vector2>());
        };
        _controls.Game.Shoot.started += ctxShoot =>
        {
            Debug.Log(message: "Sending Fire!!!");
        };
    }

    public static void GameMode() 
    { 
            _controls.Game.Enable();
        _controls.UI.Disable();
    }

    public static void UIMode() 
    { 
        _controls.Game.Disable();
        _controls.UI.Enable();
    }
}
