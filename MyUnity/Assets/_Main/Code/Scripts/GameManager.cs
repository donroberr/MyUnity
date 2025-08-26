using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private int _puntos;
    [SerializeField]
    private int _vida = 10;
    [SerializeField]
    private float _tiempo;

    [SerializeField]
    private int _tiempoEntero;

    private void Update()
    {
        // Si el tiempo aún no ha llegado a cero
        if (_tiempo > 0f)
        {
            _tiempo -= Time.deltaTime;
            _tiempoEntero = (int)_tiempo;

            // Mostrar solo los segundos enteros en consola
            Debug.Log("Tiempo restante: " + Mathf.CeilToInt(_tiempo));
        }
    }
    public void SumarPuntos(int cantidad )
    {
        _puntos += cantidad;

    }

    public void RestarVida(int cantidad)
    {
        if (_vida <= 0)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            _vida -= cantidad;
        }
    }


}
