using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class doscoi6 : MonoBehaviour
{

    private Mesh myMesh;
    private float width = 0.5f;
    private float hight = 0.5f;
    public Material mat;
    private float sqrt = 0.7071f;//1 / 1.414
    private float tan = 0.4142f;//tan(22.5)
    private float size = 500.0f;

    // Start is called before the first frame update
    void Start()
    {
        
        myMesh = new Mesh();

        myMesh.vertices = new Vector3[]
        {
            new Vector3(tan * width * sqrt, 0, -((-1 + sqrt) * hight * sqrt)),
            new Vector3(0, 0, hight / 2),
            new Vector3(-tan * width * sqrt, 0, -((-1 + sqrt) * hight * sqrt)),
            new Vector3(0, 0,  -hight / 2),
            new Vector3(width * sqrt / 2, 0, -((1 - sqrt) * hight / 2)),
            new Vector3(-width * sqrt / 2, 0, -((1 - sqrt) * hight / 2)),
            new Vector3(width * sqrt/ 4, 0, -((1 - 1.5f * sqrt) * hight / 2)),
            new Vector3(-width * sqrt/ 4, 0, -((1 - 1.5f * sqrt) * hight / 2)),
            new Vector3(0, 0, -((-1 + sqrt) * hight * sqrt))
        };

        
        myMesh.SetUVs(0, new Vector2[]
        {
            new Vector2(387.0f/size, 344.0f/size),
            new Vector2(263.0f/size, 481.0f/size),
            new Vector2(127.0f/size, 354.0f/size),
            new Vector2(256.0f/size, 18.0f/size),
            new Vector2(418.0f/size, 182.0f/size),
            new Vector2(89.0f/size, 188.0f/size),
            new Vector2(348.0f/size, 265.0f/size),
            new Vector2(163.0f/size, 260.0f/size),
            new Vector2(245.0f/size, 335.0f/size)
        });
        

        myMesh.triangles = new int[] {
            2, 1, 0,
            3, 5, 8,
            3, 8, 4,
            7, 2, 8,
            6, 8, 0,
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
