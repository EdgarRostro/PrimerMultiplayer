using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLocomotion : MonoBehaviour
{

    InputManager inputManager;
    Transform camaraTransform;
    Vector3 Direccion;
    Animator animator;


    public float speed = 5f;
    public float gravedad = 5;
    public float rotSpeed = 5f;
    Rigidbody playerRB;

    bool grounded;
    public float jumpHeight = 100f;
    


    public GameObject bullet;
    public GameObject gun;

    private void Awake()
    {
        inputManager = GetComponent<InputManager>();
        camaraTransform = Camera.main.transform;
        playerRB = GetComponent<Rigidbody>();

        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        Mover();
        Rotar();
        //Jump();
    }

    private void OnCollisionEnter(Collision collision)
    {
       // grounded = true;
        //animator.SetBool("jump", false);
    }

    public void Mover()
    {
        Direccion = camaraTransform.forward * inputManager.verticalInput;
        Direccion = Direccion + camaraTransform.right * inputManager.horizontalInput;
        //Direccion.y = 0;
        Direccion.y -= gravedad * Time.deltaTime;
        Direccion.Normalize(); //par que quede en un valor entre 0 y 1

        Direccion = Direccion * speed;

        //mover al personaje
        playerRB.velocity = Direccion;

        Debug.Log("Datos " + inputManager.horizontalInput);

        if(Direccion.x==0 && Direccion.z==0)
        {
            animator.SetBool("run", false);
        }
        else
        {
            animator.SetBool("run", true);
        }
    }

    public void Rotar()
    {
        Vector3 DireccionRotacion = Vector3.zero; //(0,0,0)
        DireccionRotacion = camaraTransform.forward * inputManager.verticalInput;
        DireccionRotacion = DireccionRotacion + camaraTransform.right * inputManager.horizontalInput;
        DireccionRotacion.Normalize();

        if(DireccionRotacion == Vector3.zero)
        {
            DireccionRotacion = transform.forward;
        }

        Quaternion rotacion = Quaternion.LookRotation(DireccionRotacion);
        Quaternion playerRot = Quaternion.Slerp(transform.rotation, rotacion, rotSpeed * Time.deltaTime);

        transform.rotation = playerRot;

    }

    public void Jump()
    {
       // if (grounded)
       // {
          //  grounded = false;
            animator.SetTrigger("jump");

            //playerRB.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
      //  }

    }

   

    public void Shot()
    {

        Debug.Log("Dispara");
        GameObject balaClon=Instantiate(bullet, gun.transform.position,gun.transform.rotation);
        balaClon.GetComponent<Rigidbody>().velocity =gun.transform.up*5;
    }
   

    /*void HandleDeathAnimation()
    {
        animator.SetTrigger("death");
    }

    */
}
