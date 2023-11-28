using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class enemyAttackScript : MonoBehaviour
{
    private Enemy enemyMovement;
    public Transform player;
    public float attackRange = 6f;

    private Enemy enemyScript;

    public Material defaultMaterial;
    public Material alertMaterial;
    public Renderer ren;

    private bool foundPlayer;


    // Start is called before the first frame update
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
            enemyMovement = GetComponent<Enemy>();
        ren = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, player.position) <= attackRange)
        {
            ren.sharedMaterial = alertMaterial;
            enemyScript.badGuy.SetDestination(player.position);
            foundPlayer = true;
        }
        else if (foundPlayer)
        {
            ren.sharedMaterial = defaultMaterial;
            enemyMovement.newLocation();
            foundPlayer = false;
        }
    }
}
