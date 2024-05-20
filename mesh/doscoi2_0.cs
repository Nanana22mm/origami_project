using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//1?F??????????
public class doscoi2_0 : MonoBehaviour
{
    //private MeshFilter meshFilter;
    private Mesh myMesh;
    //private Vector3[] myVertices = new Vector3[4];
    //private int[] myTriangles = new int[6];
    //private float width = 8;
    //private float hight = 8;
    private float width = 0.5f;
    private float hight = 0.5f;
    public Material mat;

    // Start is called before the first frame update
    void Start()
    {
        
        myMesh = new Mesh();

        myMesh.vertices = new Vector3[] {
        new Vector3(- width , 0, - hight),
        new Vector3(width, 0, -hight),
        new Vector3(- width, 0, hight),
        new Vector3(width, 0, hight)
        };


        myMesh.SetUVs(0, new Vector2[]
        {
            new Vector2(0, 0),
            new Vector2(1, 0),
            new Vector2(0, 1),
            new Vector2(1, 1)
        });

       
        myMesh.triangles = new int[] {
        2, 1, 0,
        2, 3, 1,
        };
        
        //MeshFilter????????????
        GetComponent<MeshFilter>().sharedMesh = myMesh;
        GetComponent<MeshRenderer>().material = mat;

    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
