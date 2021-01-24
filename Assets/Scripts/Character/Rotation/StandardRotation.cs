using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandardRotation : IRotationBehavior
{
    private CharacterController _character;
    public StandardRotation(CharacterController character)
    {
        _character = character;
    }
    public void rotate(IInputsMoviment inputMoviment)
    {
        if(inputMoviment.direction.x > 0)
        {
            _character.transform.rotation = Quaternion.Euler(0,-15,0);
        }else if(inputMoviment.direction.x < 0)
        {
            _character.transform.rotation = Quaternion.Euler(0, 15, 0);
        }
        else
        {
            _character.transform.rotation = Quaternion.Euler(0, 0, 0); 
        }
    }
}
