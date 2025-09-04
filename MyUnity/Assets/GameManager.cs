using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] private TMP_Text vidaText;
    [SerializeField] private TMP_Text tiempoText;
    [SerializeField] private TMP_Text puntosText;
    [SerializeField] private TMP_Text llaveText;
    [SerializeField] private TMP_Text estadoText;

    [Header("Variables")]
    [SerializeField] private int _vida;



    public void RestarVida(int vida)
    {
        _vida -= vida;
        EstadoDelJugador(vida);
    }

    public void SumarVida(int vida)
    {
        _vida += vida;
        EstadoDelJugador(vida);
    }

    public void EstadoDelJugador(int vida)
    {
        if (vida >= 70)
        {
            estadoText.text = "Bien";
        } 
        else if (vida <= 50 && vida >= 50)
        {
            estadoText.text = "Regular";
        }
        else if (vida >= 20)
        {
            estadoText.text = "Critico";
        }
        else if( vida <= 0)
        {
            estadoText.text = "Murio";
        }
    }
}
