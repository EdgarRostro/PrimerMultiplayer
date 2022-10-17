using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thea : MonoBehaviour
{
    public static int lives;
    public bool invencible;

    public GameObject potion;

    // Start is called before the first frame update
    void Start()
    {
        lives = 3;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy" && !invencible)
        {
            lives--;
            StartCoroutine(SetInvencible());
        }
        else if (collision.gameObject.tag == "potion")
        {
            if (GameManager.livesLimit > lives)
            {
                lives++;
                Destroy(collision.gameObject);
                Destroy(potion);
            }
        }
    }

    IEnumerator SetInvencible()
    {
        invencible = true;
        yield return new WaitForSeconds(3);
        invencible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (lives == 0)
        {
            //gameover
        }
    }
}
