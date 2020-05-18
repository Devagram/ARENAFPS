using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshGenerator : MonoBehaviour{
    // Start is called before the first frame update
    Mesh mesh;

    Vector3[] vertices;
    int[] triangles;

    int i = 1;
    
    void Start(){
        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;

        CreateShape();
        UpdateMesh();
    }
    void Update()
    {
        i -= 1;
        CreateShape();
        UpdateMesh();
    }

    // Toying around with Update modifying the mesh using an i to gradually increase the shape.
    // Update is called once per frame
    void CreateShape(){
        vertices = new Vector3[]{
            new Vector3 (0,0,0),
            new Vector3 (0,0,-i),
            new Vector3 (-i,0,0)
        };

        triangles = new int[]{
            0, 1, 2
        };
    }

    void UpdateMesh(){
        mesh.Clear();

        mesh.vertices = vertices;
        mesh.triangles = triangles;
    }
}
