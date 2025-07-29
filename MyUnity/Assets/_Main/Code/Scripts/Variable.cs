using UnityEngine;

public class Variable : MonoBehaviour
{
    [SerializeField]
    private int vida = 1;
    [SerializeField]
    private int punaje = 200;
    [SerializeField]
    private int nivel = 29;

    public string nombre = "Roberto";
    [SerializeField]
    private float tiempo = 60.5f;
    [SerializeField]
    private bool isAlive = true;
    
    public GameObject camera;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hola Mundo!");      
    }

    // Update is called once per frame
    void Update()
    {
        print("Hola Mundo!");
    }
}
 