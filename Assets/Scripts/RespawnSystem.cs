using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// script responsable de generar enemigos en la pantalla.
/// </summary>
public class RespawnSystem : MonoBehaviour
{
    #region Private Variables

    private float _timeElapsed; 

    private List<GameObject> _enemysInGame;

    private IEnumerator _respawnCoroutine;

    [SerializeField] private RespawnData _data;

    [SerializeField] private Transform _level;

    [SerializeField] private GameObject[] _enemys;
    #endregion
    #region UNITY METHOS
    private void Start()
    {
        ObjectPool();
    }
    #endregion
    #region OWN METHODS

    /// <summary>
    /// función que inicializa naves espaciales en el escenario.
    /// </summary>
    private void ObjectPool()
    {
        _enemysInGame = new List<GameObject>();

        for (int i = 0; i < 10; i++)
        {
            int random = Random.Range(0, _enemys.Length);

            GameObject enemy = Instantiate(_enemys[random]);

            enemy.transform.SetParent(_level);

            _enemysInGame.Add(enemy);

            enemy.SetActive(false);
        }
    }
    /// <summary>
    /// función que inicia la corrutina que posiciona y activa las naves.
    /// </summary>
    /// <param name="widthMin"> punto mínimo donde las naves espaciales pueden aparecer en la pantalla.</param>
    /// <param name="widthMax"> punto maximo donde las naves espaciales pueden aparecer en la pantalla.</param>
    /// <param name="Height"> coordenada em "y" onde as naves espaciais vao aparecer.</param>
    public void Respawn(float widthMin, float widthMax, float Height)
    {
        _respawnCoroutine = respawn(widthMin, widthMax, Height);
        StartCoroutine(_respawnCoroutine);
    }

    #endregion 
    #region COROUTINES
    /// <summary>
    /// corrutina que inicia el proceso de reaparición de la nave espacial.
    /// </summary>
    /// <param name="widthMin"> punto mínimo donde las naves espaciales pueden aparecer en la pantalla.</param>
    /// <param name="widthMax"> punto maximo donde las naves espaciales pueden aparecer en la pantalla.</param>
    /// <param name="Height"> coordenada em "y" onde as naves espaciais vao aparecer.</param>
    /// <returns></returns>
    private IEnumerator respawn(float widthMin, float widthMax, float Height)
    {
        while (true)
        {
            _timeElapsed += Time.deltaTime;
            if (_timeElapsed > _data.Time)
            {
                foreach (GameObject enemy in _enemysInGame)
                {
                    if (enemy.activeInHierarchy == false)
                    {
                        enemy.transform.position = new Vector3(Random.Range(widthMin, widthMax), Height, 0);
                        enemy.SetActive(true);
                        break;
                    }
                }

                _timeElapsed = 0;
            }
            yield return null;
        }
    }
    #endregion


}
