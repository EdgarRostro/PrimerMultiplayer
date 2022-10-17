using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterInputHandler : MonoBehaviour
{
    Vector2 moveInputVector = Vector2.zero;
    Vector2 viewInputVector = Vector2.zero;
    bool isJumpButtonPressed = false;
    bool shoot = false;    

    //Other component
    CharacterMovementHandler characterMovementHandler;

    private void Awake()
    {
        characterMovementHandler = GetComponent<CharacterMovementHandler>();
    }

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        // View Input
        viewInputVector.x = Input.GetAxis("Mouse X");
        viewInputVector.y = Input.GetAxis("Mouse Y") * -1; // Inver the mouse look

        characterMovementHandler.SetViewInputVector(viewInputVector);

        // Move input
        moveInputVector.x = Input.GetAxis("Horizontal");        
        moveInputVector.y = Input.GetAxis("Vertical"); 

        // Jump
        if(Input.GetButtonDown("Jump"))
            isJumpButtonPressed = true;

        // Shoot
        if(Input.GetButtonDown("Fire1"))
            shoot = true;
    }
    public NetworkInputData GetNetworkInput()
    {
        NetworkInputData networkInputData = new NetworkInputData();
        
        // View data
        networkInputData.rotationInput = viewInputVector.x;

        //Move data
        networkInputData.movementInput = moveInputVector;

        // Jump data
        networkInputData.isJumpPressed = isJumpButtonPressed;

        // Reset jump button
        isJumpButtonPressed = false;

        // Shoot data
        networkInputData.shoot = shoot;

        // Reset shoot
        shoot = false;

        return networkInputData;
    }   
}
