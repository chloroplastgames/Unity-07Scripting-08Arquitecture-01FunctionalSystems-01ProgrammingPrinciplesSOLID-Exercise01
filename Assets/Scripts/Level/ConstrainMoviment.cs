
using UnityEngine;
/// <summary>
/// Script responsable de definir y mostrar los límites de movimiento 
/// </summary>
public class ConstrainMoviment : MonoBehaviour
{
    #region Private Variables
    [SerializeField] private Rect _constrain;
    #endregion

    #region Properties
    public Rect Constrain { get => _constrain; }
    #endregion

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(new Vector2(_constrain.xMin, _constrain.yMin), new Vector2(_constrain.xMin, _constrain.yMax));
        Gizmos.DrawLine(new Vector2(_constrain.xMin, _constrain.yMin), new Vector2(_constrain.xMax, _constrain.yMin));
        Gizmos.DrawLine(new Vector2(_constrain.xMin, _constrain.yMax), new Vector2(_constrain.xMax, _constrain.yMax));
        Gizmos.DrawLine(new Vector2(_constrain.xMax, _constrain.yMax), new Vector2(_constrain.xMax, _constrain.yMin)); 
    }
}
