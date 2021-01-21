using UnityEngine;

public delegate void OffScreen(EnemyController enemy);
/// <summary>
/// script que agrega los comandos del enemigo.
/// </summary>
public class EnemyController : MonoBehaviour, IEnemy
{
    #region Private Variables

    private IMovimentBehavior _moviment;

    private IInputsMoviment _input;

    [SerializeField] private EnemyData _data;
    #endregion

    #region Properties 

    public EnemyData Data => _data;
    #endregion

    #region Events

    public static event OffScreen offScreen;
    #endregion

    #region UNITY METHODS
    private void Awake()
    {
        _input = new InputIA();

        _moviment = new StandardMovimentEnemy(this);
    }
    private void OnEnable()
    {
        offScreen += GameManager.Instance.EventOffScreen;
    }
    private void Update()
    {
        offScreen?.Invoke(this);
    }
    private void FixedUpdate()
    {
        _moviment.Move(_input);
    }
    private void OnDisable()
    {
        offScreen -= GameManager.Instance.EventOffScreen;
    }
    #endregion

    #region OWN METHODS
    /// <summary>
    /// Función que devuelve la "Transform" de los enemigos.
    /// </summary>
    /// <returns></returns>
    public Transform GetTransformSpaceShip()
    {
        return transform;
    }
    #endregion
}
