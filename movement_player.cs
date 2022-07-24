using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement_player : MonoBehaviour
{
    [Header ("(1) Refencias unity")]
    [Tooltip("Selecciona el -GameObject- que represente a tu jugador")]
    [SerializeField] private CharacterController controller;
    [Tooltip("Selecciona el -GameObject- que represente tu camara")]
    public Transform elCamaras;
    [Tooltip("Selecciona el -GameObject- que este en los pies de tu jugador y cerca del piso")]
    public Transform checaPiso;

    [Header ("(2) Movimiento jugador")]
    [Range(2f, 10f)]public float Velocidad = 5f;
    public float Saltar = 3f;
    [SerializeField] private float gravedad = -9.81f;
    [Space(3)]
    [SerializeField] private float distanciaDelPiso = 0.4f;
    [SerializeField] private LayerMask groundMask;

    private Vector3 Velocity;
    private bool StaEnPiso;

    public Animator animacion;


    void Update()
    {
        //movimiento por el juego
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude >= 0.1f)//movimiento referente a  la camara
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + elCamaras.eulerAngles.y;
            transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);

            Vector3 DireccionPaMoverse = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(DireccionPaMoverse.normalized * Velocidad * Time.deltaTime);
        }

        animacion.SetFloat("VelocidadX", horizontal);
        animacion.SetFloat("VelocidadY", vertical);

        //saltar
        if (Input.GetButtonDown("Jump") && StaEnPiso)
            Velocity.y = Mathf.Sqrt(Saltar * -2f * gravedad);

        StaEnPiso = Physics.CheckSphere(checaPiso.position, distanciaDelPiso, groundMask);

        if (StaEnPiso && Velocity.y < 0)
        {
            Velocity.y = -2f;
        }

        Velocity.y += gravedad * Time.deltaTime;
        controller.Move(Velocity * Time.deltaTime);
    }
}
