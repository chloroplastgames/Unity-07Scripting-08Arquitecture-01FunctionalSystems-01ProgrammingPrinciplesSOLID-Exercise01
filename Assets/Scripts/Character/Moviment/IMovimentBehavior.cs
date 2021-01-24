/// <summary>
/// interface de movimiento de jugador estándar.
/// </summary>
public interface IMovimentBehavior
{
    /// <summary>
    /// función que implementará el movimiento del jugador.
    /// </summary>
    /// <param name="input">interface de entrada para movimiento</param>
    void Move(IInputsMoviment input); 
}
