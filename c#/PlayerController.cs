using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float velocidad = 5f;
    public Animator animator;

    //salto
    public float fuerzaSalto=10f;
    public float longitud=0.1f;//linea imaginaria entre el personaje y el suelo
    public LayerMask suelo; //nuestro suelo

    private bool tocaSuelo; //si está o no en suelo
    private Rigidbody2D rb; //manipular el personaje
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();//va obtener el rigidbody del personaje
        //que tiene el script asociado
    }

    // Update is called once per frame
    void Update()
    {
        float velocidadX = Input.GetAxis("Horizontal") * Time.deltaTime * velocidad;//lo último para que se mueva uniforme
        Vector3 position = transform.position;//guarda la pos actual
        transform.position = new Vector3(velocidadX + position.x, position.y, position.z);
        

        animator.SetFloat("movimiento",velocidadX*velocidad);
        if (velocidadX<0){
            transform.localScale=new Vector3(-1,1,1);
        }
        if (velocidadX>0){
            transform.localScale=new Vector3(1,1,1);
        }


        

        //salto
        RaycastHit2D salto = Physics2D.Raycast(transform.position, Vector2.down, longitud, suelo);
        //desde el jugador, hacia abajo, del tamaño  declarado mas arriba, busca colisionar con suelo
        tocaSuelo = salto.collider != null;
        //si la línea colisiona con el suelo el anterior sería true, si no choca sería falso
        if(tocaSuelo && Input.GetKeyDown(KeyCode.Space))
        //si el personaje está en el suelo y presiona espacio hará lo que sigue
        {
            rb.AddForce(new Vector2(0f, fuerzaSalto), ForceMode2D.Impulse);
            //le agrega fuerza al salto (0 para no moverlo en horizontal, fuerza de salto, será a modo de impulso)

        }
    }

    void OnDrawGizmos()
    //figuras imaginarias se ven en el editor pero no cuando está jugando
    {
        Gizmos.color = Color.red;
        //le da color
        Gizmos.DrawLine(transform.position, transform.position + Vector3.down * longitud);
        //desde donde inicia, hacia abajo por la longitud del raycast
    }

    
}
