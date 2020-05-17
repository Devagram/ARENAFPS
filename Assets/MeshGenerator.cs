using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshGenerator : MonoBehaviour{
    // Start is called before the first frame update
    Mesh mesh;

    Vector3[] vertices;
    int[] triangles;
    
    
    void Start(){
        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;

        CreateShape();
        UpdateMesh();
    }

    // Update is called once per frame
    void CreateShape(){
        vertices = new Vector3[]{
            new Vector3 (0,0,0),
            new Vector3 (0,0,20),
            new Vector3 (20,0,0)
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
