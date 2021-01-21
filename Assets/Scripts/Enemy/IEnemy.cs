using UnityEngine;
/// <summary>
/// interfaz de enemigos
/// </summary>
public interface IEnemy
{
    EnemyData Data
    {
        get; 
    }
    /// <summary>
    /// Función que devuelve la "Transform" de los enemigos.
    /// </summary>
    /// <returns></returns>
    Transform GetTransformSpaceShip();
}
