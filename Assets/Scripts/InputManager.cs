using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    PlayerActions playerControler;
    PlayerLocomotion playerLocomotion;
    public Vector2 movementInput;

    public Vector2 cameraInput;

    public bool jumpInput=false;
    Rigidbody playerRB;
    public float jumpHeight = 5f;

    public float verticalInput;
    public float horizontalInput;

    public float verticalCamera;
    public float horizontalCamera;

    public bool shotInput = false;

    private void OnEnable()
    {
        if(playerControler== null)
        {
            playerControler = new PlayerActions();

            //Asignar el valor de run a nuestra variable
            playerControler.TheaMain.Run.performed += i => movementInput = i.ReadValue<Vector2>();


            //asignar valor camara (mouse) a la variable
            playerControler.TheaMain.Camera.performed += i => cameraInput = i.ReadValue<Vector2>();

            //asignar valor de jump
            playerControler.TheaMain.Jump.performed += i => jumpInput = true;

            //Disparo
            playerControler.TheaMain.Shot.performed += i => shotInput = true;

        }

        playerControler.Enable();
    }

    private void Awake()
    {
        playerLocomotion = GetComponent<PlayerLocomotion>();
    }

    private void OnDisable()
    {
        playerControler.Disable();
    }

    private void Update()
    {
        HandleMovementInput();
        HandleJumpInput();
        HandleShotInput();
    }

    public void HandleMovementInput()
    {
        //movimiento
        verticalInput = movementInput.y;
        horizontalInput = movementInput.x;

        //camara 
        verticalCamera = cameraInput.y;
        horizontalCamera = cameraInput.x;

    }

    public void HandleJumpInput()
    {
        //Si se detecta input, resetear y esperar a obter input otra vez
        if (jumpInput)
        {
            jumpInput = false;
            playerLocomotion.Jump();

            //playerRB.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
        }
    }

    public void HandleShotInput()
    {
        if (shotInput)
        {
            Debug.Log("DISPARA inputmanager");
            shotInput = false;
            playerLocomotion.Shot();
        }
    }
   
}
