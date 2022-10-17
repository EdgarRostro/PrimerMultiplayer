using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fusion;

public class NetworkPlayer : NetworkBehaviour, IPlayerLeft
{
    public static NetworkPlayer Local { get; set;}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public override void Spawned()
    {
        if(Object.HasInputAuthority)
        {
            Local = this;

            // Disable main camera
            Camera.main.gameObject.SetActive(false);

            Debug.Log("Spawned, we have input authority");
        }
        else
        {
            //Disable the camera if we are not the local player
            Camera localCamera = GetComponentInChildren<Camera>();
            localCamera.enabled = false;

            //Only 1 audio listner is allowed in the scene so disable remote players audio listner
            AudioListener audioListener = GetComponentInChildren<AudioListener>();
            audioListener.enabled = false;

            // Change color of the player
            gameObject.transform.Find("Thea").GetComponent<Renderer>().material.color = Color.red;

            Debug.Log("Spawned remote player");
        }

        // Set the player name
        transform.name = $"Thea_{Object.Id}";

    }

    public void PlayerLeft(PlayerRef player)
    {
        if (player == Object.InputAuthority)
        {
            Runner.Despawn(Object);
            Debug.Log("OnPlayerLeft, destroying object");
        }
    }
}
