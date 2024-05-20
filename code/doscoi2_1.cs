using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//1?F??????????
public class doscoi2_1 : MonoBehaviour
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
            new Vector3(- width , 0, - hight),
            new Vector3(0, 0, -hight),
            new Vector3(- width, 0, hight),
            new Vector3(0, 0, hight),
            new Vector3(width, 0, -hight),
            new Vector3(0, 0, 0),
            new Vector3(width, 0, 0)
        };

        myMesh.SetUVs(0, new Vector2[]
        {
            new Vector2(0, 0),
            new Vector2(0.5f, 0),
            new Vector2(0, 1),
            new Vector2(0.5f, 1),
            new Vector2(1, 0),
            new Vector2(0.5f, 0.5f),
            new Vector2(1, 0.5f)
        });


        myMesh.triangles = new int[] {
            0, 2, 1,
            2, 3, 1,
            1, 5, 4,
            5, 6, 4,
            3, 6, 5,
        };

        GetComponent<MeshFilter>().sharedMesh = myMesh;
        GetComponent<MeshRenderer>().material = mat;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
