using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class doscoi6_2 : MonoBehaviour
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
            new Vector3(tan * width * sqrt, 0, -((-1 + sqrt) * hight * sqrt)),
            new Vector3(0, 0, hight / 2),
            new Vector3(-tan * width * sqrt, 0, -((-1 + sqrt) * hight * sqrt)),
            new Vector3(0, 0, -(0.5f * hight - sqrt * hight / 3)),
            new Vector3(width * sqrt / 2, 0, -((1 - sqrt) * hight / 2)),
            new Vector3(-width * sqrt / 2, 0, -((1 - sqrt) * hight / 2)),
            new Vector3(width * sqrt / 4, 0, -(1 - 1.5f * sqrt) * hight / 2),
            new Vector3(-width * sqrt / 4, 0, -(1 - 1.5f * sqrt) * hight / 2),
            new Vector3(0, 0, -(-1 + sqrt) * hight * sqrt),
            new Vector3(width * sqrt / 6, 0, -(1 - sqrt) * hight / 2),
            new Vector3(-width * sqrt / 6, 0, -(1 - sqrt) * hight / 2)
        };

        
        myMesh.SetUVs(0, new Vector2[]
        {
            new Vector2(2268.0f/size, 1800.0f/size),
            new Vector2(1517.0f/size, 2548.0f/size),
            new Vector2(789.0f/size, 1792.0f/size),
            new Vector2(1500.0f/size, 618.0f/size),
            new Vector2(2379.0f/size, 959.0f/size),
            new Vector2(676.0f/size, 956.0f/size),
            new Vector2(2057.0f/size, 1279.0f/size),
            new Vector2(1016.0f/size, 1288.0f/size),
            new Vector2(1520.0f/size, 1796.0f/size),
            new Vector2(1853.0f/size, 935.0f/size),
            new Vector2(1180.0f/size, 938.0f/size)
        });
        

        myMesh.triangles = new int[] {
            0, 2, 1,
            7, 2, 8,
            6, 8, 0,
            3, 10, 9,
            4, 5, 8,
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
