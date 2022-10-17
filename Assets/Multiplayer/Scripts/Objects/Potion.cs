using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fusion;

public class Potion : NetworkBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && collision.gameObject.GetComponent<CharacterMovementHandler>().lives < 3)
        {
            collision.gameObject.GetComponent<CharacterMovementHandler>().HandleCollision(gameObject.tag);
            Runner.Despawn(Object);
        }
    }
}
