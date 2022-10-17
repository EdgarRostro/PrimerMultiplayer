using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fusion;
using UnityEngine.UI;

public class CharacterMovementHandler : NetworkBehaviour
{
    Vector2 viewInput;
    Animator animator;

    [SerializeField]
    private Bullet bullet;

    [SerializeField]
    private GameObject gun;

    // Rotation 
    float cameraRotationX = 0;

    // Other Componenent
    NetworkCharacterControllerPrototypeCustom networkCharacterControllerPrototypeCustom;
    Camera localCamera;

    public Image[] hearts;
    public int lives;
    public bool invencible;

    private void Awake()
    {
        networkCharacterControllerPrototypeCustom = GetComponent<NetworkCharacterControllerPrototypeCustom>();
        localCamera = GetComponentInChildren<Camera>();

        animator = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        lives = 2;
    }

    // Update is called once per frame
    void Update()
    {
        cameraRotationX += viewInput.y * Time.deltaTime * networkCharacterControllerPrototypeCustom.viewUpDownRotationSpeed;
        cameraRotationX = Mathf.Clamp(cameraRotationX, -10, 10);

        localCamera.transform.localRotation = Quaternion.Euler(cameraRotationX, 0, 0);
    }

    public override void FixedUpdateNetwork()
    {
        // Set UI
        SetLivesUI();

        // Get the input from the network
        if(GetInput(out NetworkInputData networkInputData))
        {
            // Rotate the view
            networkCharacterControllerPrototypeCustom.Rotate(networkInputData.rotationInput);

            // Move
            Vector3 moveDirection = transform.forward * networkInputData.movementInput.y + transform.right * networkInputData.movementInput.x;
            moveDirection.Normalize();

            networkCharacterControllerPrototypeCustom.Move(moveDirection);

            // DISPARAR
            if (networkInputData.shoot)
            {
                Runner.Spawn(bullet, gun.transform.position, gun.transform.rotation, Object.InputAuthority,
                        (runner, o) =>
                        {
                            // Initialize the Ball before synchronizing it
                            o.GetComponent<Bullet>().Init(10 * (gun.transform.rotation * Vector3.up));
                        });
            }

            if(Runner.IsForward)
            {
                //Jump
                if(networkInputData.isJumpPressed)
                    animator.SetTrigger("jump");

                if (moveDirection == Vector3.zero)
                {
                    animator.SetBool("run", false);
                }
                else
                {
                    animator.SetBool("run", true);
                }
            }

        }
    }

    public void SetViewInputVector(Vector2 viewInput)
    {
        this.viewInput = viewInput;
    }

    void SetLivesUI()
    {
        for(int i = 0; i < lives; i++)
        {
            hearts[i].gameObject.SetActive(true);
        }
        for(int i = lives; i < hearts.Length; i++)
        {
            hearts[i].gameObject.SetActive(false);
        }
    }

    public void HandleCollision(string tag)
    {
        if (tag == "Enemy" && !invencible)
        {
            lives--;
            StartCoroutine(SetInvencible());
        }
        else if (tag == "potion")
        {
            lives++;
        }
    }

    IEnumerator SetInvencible()
    {
        invencible = true;
        yield return new WaitForSeconds(3);
        invencible = false;
    }
}
