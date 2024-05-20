using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class doscoi5_1 : MonoBehaviour
{

    private Mesh myMesh;
    private float width = 0.5f;
    private float hight = 0.5f;
    public Material mat;
    private float sqrt = 0.7071f;//1 / 1.414
    private float tan = 0.4142f;//tan(22.5)
    private float size = 3024.0f;

    // Start is called before the first frame update
    void Start()
    {
        myMesh = new Mesh();

        myMesh.vertices = new Vector3[]
        {
            new Vector3(-width/2, 0, 0),
            new Vector3(0, 0, -hight/2),
            new Vector3(tan * width * sqrt, 0, (-1 + sqrt) * hight * sqrt),
            new Vector3(0, 0, hight/2),
            new Vector3(width * sqrt / 2, 0, (1 - sqrt) * hight / 2),
            new Vector3(width * sqrt / 4, 0, (1 - 1.5f * sqrt) * hight / 2),
            new Vector3(0, 0, (-1 + sqrt) * hight * sqrt)
        };


        myMesh.SetUVs(0, new Vector2[]
        {
            new Vector2(545.0f/size, 1489.0f/size),
            new Vector2(1592.0f/size, 515.0f/size),
            new Vector2(2163.0f/size, 1144.0f/size),
            new Vector2(1513.0f/size, 2490.0f/size),
            new Vector2(2273.0f/size, 1931.0f/size),
            new Vector2(1976.0f/size, 1554.0f/size),
            new Vector2(1570.0f/size, 1158.0f/size)
        });


        myMesh.triangles = new int[] {
            3, 1, 0,
            3, 4, 6,
            5, 2, 6,
            6, 2, 1,
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
