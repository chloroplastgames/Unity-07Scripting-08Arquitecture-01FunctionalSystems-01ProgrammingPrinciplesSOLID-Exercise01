using UnityEngine;

/// <summary>
/// Script responsable de almacenar información de la nave espacial.
/// </summary>
[CreateAssetMenu(menuName ="Prototipo/Player/Data")]
public class SpaceShipData : ScriptableObject
{
    #region Private variables
    [SerializeField] private float _speedSpaceShip;
    #endregion

    #region Public variavels
    public float Speed { get => _speedSpaceShip; }
    #endregion
}
