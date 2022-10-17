using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraManager : MonoBehaviour
{
    public InputManager inputManager;

    //ajustar todas las camaras a la posicion deseada antes de concluir con la integracion del script 

    public Transform playerTransform;
    public Vector3 followVelocity = Vector3.zero;
    public float followSpeed = 0.5f;

    //camara
    public float lookAngleY;
    public float cameraSpeed;
    public GameObject mainCamera;
    Vector3 ThridPcamera;
    public Transform cameraPivot;
    bool fps=false;

    private void Start()
    {
        ThridPcamera = mainCamera.transform.position;
    }

    public void Update()
    {
        followPlayer();
        RotateCamera();

        if (Input.GetMouseButtonDown(1))
        {
            SwitchCamera();
        }
    }

    public void followPlayer()
    {
      Vector3 targetPos = Vector3.SmoothDamp(transform.position, playerTransform.position, ref followVelocity, followSpeed);

      transform.position = targetPos;

    }

    public void RotateCamera()
    {
        lookAngleY = lookAngleY + (inputManager.horizontalCamera*cameraSpeed);

        Vector3 rotation = Vector3.zero;
        rotation.y = lookAngleY;

        Quaternion targetRotation = Quaternion.Euler(rotation);
        transform.localRotation = targetRotation;

    }

    public void SwitchCamera()
    {
        if (fps)
        {
            mainCamera.transform.localPosition = ThridPcamera;
            fps = false;
        }
        else
        {
            mainCamera.transform.localPosition = cameraPivot.localPosition;
            fps = true;
        }
    }
}
