using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class enemyAttackScript : MonoBehaviour
{
    private Enemy enemyMovement;
    public GameObject player;
    public float attackRange = 6f;
    public float damageRange = 3f;

    private Enemy enemyScript;

    public Material defaultMaterial;
    public Material alertMaterial;
    public Renderer ren;
    public int damageAmount = 1;

    private bool foundPlayer;

    private HealthSlider healthSlider;


    // Start is called before the first frame update
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        healthSlider = player.GetComponent<HealthSlider>();
        enemyScript = GetComponent<Enemy>();
        ren = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) <= attackRange)
        {
            ren.sharedMaterial = alertMaterial;
            enemyScript.badGuy.SetDestination(player.transform.position);
            foundPlayer = true;
        }
        else if (foundPlayer)
        {
            ren.sharedMaterial = defaultMaterial;
            enemyMovement.newLocation();
            foundPlayer = false;
        }
        if (Vector3.Distance(transform.position, player.transform.position) <= damageRange)
        {
            healthSlider.TakeDamage(damageAmount);
        }

    }
}
