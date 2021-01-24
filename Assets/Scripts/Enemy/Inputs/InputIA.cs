using UnityEngine;
/// <summary>
/// Interface de entrada para el movimiento del enemigo.
/// </summary>
public class InputIA : IInputsMoviment
{
    public Vector2 direction { get => new Vector2(0, 1); }
}
