using UnityEngine;
/// <summary>
/// interface de movimiento de jugador estándar.
/// </summary>
public class InputMoviment : IInputsMoviment
{ 
    public Vector2 direction { get => new Vector2(Input.GetAxis("Horizontal"), 0); }
    
}
