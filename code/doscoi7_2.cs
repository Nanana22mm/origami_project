using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement; //ç≈èâÇ…êÈåæ

public class doscoi7_2 : MonoBehaviour
{
    //public AudioClip audioClip;
    //AudioSource audioSource;

    private Mesh myMesh;
    public Material mat;
    private float width = 0.7f;
    private float hight = 0.7f;
    private float sqrt = 0.7071f;//1 / 1.414
    private float tan = 0.4142f;//tan(22.5)
    private float size_w = 1126;
    private float size_h = 1208;

    // Start is called before the first frame update
    void Start()
    {
        myMesh = new Mesh();
        //audioSource = GetComponent<AudioSource>();
        
        myMesh.vertices = new Vector3[]
        {
            new Vector3(-tan * width * sqrt, 0, (-1 + sqrt) * hight * sqrt),
            new Vector3(0, 0, -hight / 2),
            new Vector3(tan * width * sqrt, 0, (-1 + sqrt) * hight * sqrt),
            new Vector3(0, 0, 0.5f * hight - sqrt * hight / 3),
            new Vector3(-width * sqrt / 2, 0, (1 - sqrt) * hight / 2),
            new Vector3(width * sqrt / 2, 0, (1 - sqrt) * hight / 2),
            new Vector3(-width * sqrt/ 4, 0, (1 - 1.5f * sqrt) * hight / 2),
            new Vector3(width * sqrt/ 4, 0, (1 - 1.5f * sqrt) * hight / 2),
            new Vector3(0, 0, (-1 + sqrt) * hight * sqrt),
            new Vector3(-width * sqrt / 6, 0, (1 - sqrt) * hight / 2),
            new Vector3(width * sqrt / 6, 0, (1 - sqrt) * hight / 2)
        };


        myMesh.SetUVs(0, new Vector2[]
        {
            new Vector2(125.0f/size_w, 389.0f/size_h),  //0
            new Vector2(563.0f/size_w, 1.0f/size_h),    //1
            new Vector2(1007.0f/size_w, 410.0f/size_h), //2
            new Vector2(535.0f/size_w, 1157.0f/size_h), //3
            new Vector2(10.0f/size_w, 944.0f/size_h),   //4
            new Vector2(1086.0f/size_w, 960.0f/size_h), //5
            new Vector2(238.0f/size_w, 714.0f/size_h),  //6
            new Vector2(886.0f/size_w, 726.0f/size_h),  //7
            new Vector2(555.0f/size_w, 395.0f/size_h),  //8
            new Vector2(340.0f/size_w, 956.0f/size_h),  //9
            new Vector2(778.0f/size_w, 963.0f/size_h)   //10
        });


        myMesh.triangles = new int[] {
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
        /*if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Scene8");
        }*/
        //audioSource.PlayOneShot(audioClip);
    }
}
