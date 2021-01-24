using UnityEngine;
/// <summary>
/// Script de movimiento del jugador.
/// </summary>
public class StandardMoviment : IMovimentBehavior
{
    #region Private Variables

    private CharacterController _character;

    private Rect _constrains;

    #endregion

    #region Constructor and Destructor
    public StandardMoviment(CharacterController character, Rect constrains)
    {
        _character = character;
        _constrains = constrains;
    }
    ~StandardMoviment()
    {
        System.GC.Collect();
    }
    #endregion

    #region OWN METHODS
    /// <summary>
    /// función que implementa el movimiento del jugador.
    /// </summary>
    /// <param name="input">interface de entrada de movimiento</param>
    public void Move(IInputsMoviment input)
    {
        Vector3 newPos = new Vector2(_character.transform.position.x,_character.transform.position.y) +
                                    (input.direction * Time.deltaTime * _character.Data.Speed);  

        if (_constrains.Contains(newPos))
        {
            _character.transform.position = newPos;
        } 
    }
    #endregion
}
