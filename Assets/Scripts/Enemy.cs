using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{

    public GameObject brujita;
    public float detectRadio;
    private NavMeshAgent monstruo;
    private Animator animMonstruo;

    // Start is called before the first frame update
    void Start()
    {
        monstruo = GetComponent<NavMeshAgent>();
        animMonstruo = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       FindBrujita();
    }

    public void FindBrujita()
    {

        float distance = Vector3.Distance(transform.position, brujita.transform.position);

        if(distance < detectRadio)
        {
            animMonstruo.SetBool("Run", true);
            monstruo.destination = brujita.transform.position;
        }
        else
        {
            monstruo.destination = transform.position;
            animMonstruo.SetBool("Run", false);
        }
        
    }

    
    private void OnCollisionStay(Collision collision)
    {
       /* if (!GameManager.death>=0)
        {
            GameManager.lives--;
            if(GameManager.lives < 0)
            {
                animBrujita.SetBool("death", true);
            }

        }
       */
        //Poner logica de animacion de ataque, quitar vidas y animacion TheaDie
    }
}
