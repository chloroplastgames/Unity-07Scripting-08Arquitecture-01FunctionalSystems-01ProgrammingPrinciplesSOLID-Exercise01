using UnityEngine;
/// <summary>
/// ScriptableObject responsable de almacenar datos de naves espaciales enemigas
/// </summary>
[CreateAssetMenu(menuName = "Prototipo/Enemy/Data")] 
public class EnemyData : ScriptableObject
{
    #region Private variables
    [SerializeField] private float _speedSpaceShip;
    #endregion

    #region Public variavels
    public float Speed { get => _speedSpaceShip; }
    #endregion
}
