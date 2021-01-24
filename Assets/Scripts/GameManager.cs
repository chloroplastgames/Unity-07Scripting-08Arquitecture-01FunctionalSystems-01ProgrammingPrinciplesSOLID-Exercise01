using UnityEngine;

/// <summary>
/// Script responsable de agregar otros sistemas de juego.
/// </summary>
public class GameManager : MonoBehaviour
{
    #region Private Variables 

    private static GameManager _instance;

    private RespawnSystem _respawn;

    [SerializeField] private ConstrainMoviment _constrain; 

    #endregion 

    #region Properties

    public static GameManager Instance { get => _instance; }

    #endregion

    #region UNITY METHODS
    private void Awake()
    {
        if(_instance == null)
        {
            _instance = this;
        }
        _respawn = GetComponent<RespawnSystem>();
    }

    private void Start()
    {
        _respawn.Respawn(_constrain.Constrain.xMin,_constrain.Constrain.xMax,_constrain.Constrain.yMax);
    }
    #endregion

    #region EVENT METHODS
    /// <summary>
    /// función que desactivará a los enemigos al salir de los límites
    /// </summary>
    /// <param name="enemy">interface de enemigos</param>
    public void EventOffScreen(IEnemy enemy)
    {
        if (!_constrain.Constrain.Contains(enemy.GetTransformSpaceShip().position))
        { 
            enemy.GetTransformSpaceShip().gameObject.SetActive(false);
        } 
    }
    #endregion
}
