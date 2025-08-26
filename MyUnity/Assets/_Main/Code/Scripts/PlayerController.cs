using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rb2d;
    [SerializeField]
    private Vector2 direccion = new Vector2(1f ,1f);
    [SerializeField]
    private float fuerzaDeSalto = 2000000000000000000f;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.AddForce(direccion * fuerzaDeSalto);
            
        }
        else
        {
            print("No oprimi la tecla espacio");
        }
        
        
    }
}
