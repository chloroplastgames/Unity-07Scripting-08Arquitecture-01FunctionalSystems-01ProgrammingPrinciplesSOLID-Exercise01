using UnityEngine;
/// <summary>
/// Script de movimiento enemigo
/// </summary>
public class StandardMovimentEnemy : IMovimentBehavior
{
    #region Private Variable 

    private EnemyController _enemy;
    #endregion

    #region Constructor and Destructor

    public StandardMovimentEnemy(EnemyController enemy)
    {
        _enemy = enemy;
    }
    ~StandardMovimentEnemy()
    {
        System.GC.Collect();
    }
    #endregion

    #region OWN METHODS
    /// <summary>
    /// función que implementa el movimiento de los enemigos
    /// </summary>
    /// <param name="input">interface de entrada de movimiento</param>
    public void Move(IInputsMoviment input)
    { 
        Vector3 newPos = new Vector2(_enemy.transform.position.x, _enemy.transform.position.y) +
                                    (input.direction * Time.deltaTime * -_enemy.Data.Speed);

        _enemy.transform.position = newPos;
    }
    #endregion
}
