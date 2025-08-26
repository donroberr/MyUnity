using UnityEngine;


public class TrampaController : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameManager.RestarVida(1);
        }
    }
}
