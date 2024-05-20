using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class doscoi5_2 : MonoBehaviour
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
            new Vector3(-tan * width * sqrt, 0, (-1 + sqrt) * hight * sqrt),
            new Vector3(0, 0, -hight/2),
            new Vector3(tan * width * sqrt, 0, (-1 + sqrt) * hight * sqrt),
            new Vector3(0, 0, hight/2),
            new Vector3(-width * sqrt / 2, 0, (1 - sqrt) * hight / 2),
            new Vector3(width * sqrt / 2, 0, (1 - sqrt) * hight / 2),
            new Vector3(-width * sqrt / 4, 0, (1 - 1.5f * sqrt) * hight / 2),
            new Vector3(width * sqrt / 4, 0, (1 - 1.5f * sqrt) * hight / 2),
            new Vector3(0, 0, (-1 + sqrt) * hight * sqrt)
        };

        myMesh.SetUVs(0, new Vector2[]
        {
            new Vector2(960.0f/size, 1059.0f/size),
            new Vector2(1564.0f/size, 510.0f/size),
            new Vector2(2130.0f/size, 1100.0f/size),
            new Vector2(1500.0f/size, 2454.0f/size),
            new Vector2(817.0f/size, 1782.0f/size),
            new Vector2(2203.0f/size, 1785.0f/size),
            new Vector2(1116.0f/size, 1483.0f/size),
            new Vector2(1950.0f/size, 1509.0f/size),
            new Vector2(1542.0f/size, 1100.0f/size)
        });

        myMesh.triangles = new int[] {
            0, 2, 1,
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
