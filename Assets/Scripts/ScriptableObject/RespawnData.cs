using UnityEngine;
/// <summary>
/// ScriptableObject responsable de almacenar datos de respawn.
/// </summary>
[CreateAssetMenu(menuName = "Prototipo/Respawn/Data")] 
public class RespawnData : ScriptableObject
{
    #region Private variables
    [SerializeField] private float _time; 
    #endregion

    #region Public variavels
    public float Time { get => _time; } 
    #endregion
}
