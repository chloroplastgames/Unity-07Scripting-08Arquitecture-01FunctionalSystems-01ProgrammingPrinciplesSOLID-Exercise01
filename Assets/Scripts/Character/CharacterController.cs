using UnityEngine;
/// <summary>
/// script que agrega los comandos del jugador.
/// </summary>
public class CharacterController : MonoBehaviour
{
    #region Private variables
    private IMovimentBehavior _moviment;

    private IInputsMoviment _inputMoviment;

    private IRotationBehavior _rotatio;

    [SerializeField] private ConstrainMoviment _constrains;

    [SerializeField] private SpaceShipData _data;
    #endregion

    #region Properties
    public  SpaceShipData Data { get => _data; }
    #endregion

    #region UNITY METHODS
    private void Awake()
    {
        _inputMoviment = new InputMoviment();

        _moviment = new StandardMoviment(this, _constrains.Constrain);

        _rotatio = new StandardRotation(this);
    } 
    private void FixedUpdate()
    {
        Moviment();
    }

    private void Moviment()
    {
        _moviment.Move(_inputMoviment);

        _rotatio.rotate(_inputMoviment);
    }
    #endregion
}
