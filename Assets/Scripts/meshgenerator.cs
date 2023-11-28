using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshCollider))]

public class meshgenerator : MonoBehaviour
{
    Mesh mesh;

    Vector3[] vertices;
    int[] triangles;


    // Start is called before the first frame update
    void Start()
    {
        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;


        CreateShape();
        updateMesh();

        GetComponent<MeshFilter>().sharedMesh = mesh;
        GetComponent<MeshCollider>().convex = true;
    }

    void CreateShape()

    {
        vertices = new Vector3[]
        {
           new Vector3(0.0f, 0.0f, 0.0f), //0 bottom left
           new Vector3(0.0f, 0.0f, 1.0f), //1 top left
           new Vector3(1.0f, 0.0f, 0.0f), //2 top right 
           new Vector3(1.0f, 0.0f, 1.0f), //3 bottom right
           new Vector3(0.5f, 1.0f, 0.5f), //4 top coordinate
        };

        triangles = new int[]
        {
         2,1,0, // onderkant
          1,2,3, // onderkant
 
          2,0,4, // bovenkant piramide
          0,1,4, // bovenkant piramide
          1,3,4, // bovenkant piramide
          3,2,4, // bovenkant piramide
       
       };
    }

    void updateMesh()
    {
        mesh.Clear();

        mesh.vertices = vertices;
        mesh.triangles = triangles;
    }
}
