using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doscoi3_0 : MonoBehaviour
{
    private Mesh myMesh;
    private float width = 0.5f;
    private float hight = 0.5f;
    public Material mat;

    // Start is called before the first frame update
    void Start()
    {
        myMesh = new Mesh();

        myMesh.vertices = new Vector3[]
        {
            new Vector3(- width/2, 0, 0),
            new Vector3(0, 0, -hight/2),
            new Vector3(0, 0, hight/2),
            new Vector3(width/2, 0, 0),
            //new Vector3(-width/4, 0, -hight/4),
            //new Vector3(-width/4, 0, hight/4),
            //new Vector3(width/4, 0, -hight/4),
            //new Vector3(width/4, 0, hight/4),
            //new Vector3(0, 0, 0)
        };


        myMesh.SetUVs(0, new Vector2[]
        {
            new Vector2(0, 0.5f),
            new Vector2(0.5f, 0),
            new Vector2(0.5f, 1),
            new Vector2(1, 0.5f),
            //new Vector2(0.25f, 0.25f),
            //new Vector2(0.25f, 0.75f),
            //new Vector2(0.75f, 0.25f),
            //new Vector2(0.75f, 0.75f),
            //new Vector2(0.5f, 0.5f)
        });


        myMesh.triangles = new int[] {
            0, 2, 1,
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
