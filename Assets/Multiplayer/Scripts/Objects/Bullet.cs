using UnityEngine;
using Fusion;

public class Bullet : NetworkBehaviour
{

    [Networked] private TickTimer life { get; set; }

    public void Init(Vector3 forward)
    {
        life = TickTimer.CreateFromSeconds(Runner, 5.0f);
        GetComponent<Rigidbody>().velocity = forward;
    }

    public override void FixedUpdateNetwork()
    {
        if(life.Expired(Runner))
            Runner.Despawn(Object);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && !collision.gameObject.GetComponent<CharacterMovementHandler>().invencible)
        {
            Debug.Log("ColisionBullet");
            collision.gameObject.GetComponent<CharacterMovementHandler>().HandleCollision(gameObject.tag);
            Runner.Despawn(Object);
        }     
    }

}

