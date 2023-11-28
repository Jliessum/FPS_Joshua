using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class Enemy : MonoBehaviour
{
    public NavMeshAgent badGuy;

    public float squareOfMovement = 20f;

    public float xMin;
    public float xMax;
    public float zMin;
    public float zMax;

    private float xPosition;
    private float zPosition;
    private float yPosition;

    public float closeEnough = 2f;

    // Start is called before the first frame update
    void Start()
    {
        xMin = zMin = -squareOfMovement;
        xMax = zMax = squareOfMovement;
        newLocation();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, new Vector3(xPosition, yPosition, zPosition)) < closeEnough)
        {
            newLocation();
        }
    }

    public void newLocation()
    {
        xPosition = Random.Range(xMin, xMax);
        yPosition = transform.position.y;
        zPosition = Random.Range(zMin, zMax);

        badGuy.SetDestination(new Vector3(xPosition, yPosition, zPosition));
    }
}
