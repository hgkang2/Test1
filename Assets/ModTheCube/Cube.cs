using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    private int xyz;
    private float speed;
    
    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;
        
        Material material = Renderer.material;
        
        material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);
        
        
        xyz = Random.Range(0,3);
        speed = Random.Range(10.0f,100.0f);
    }

    void Update()
    {
        float x, y, z;
        switch (xyz)
        {
            case 0:
                x = speed * Time.deltaTime;
                y = 0.0f;
                z = 0.0f;
                break;
            case 1:
                x = 0.0f;
                y = speed * Time.deltaTime;
                z = 0.0f;
                break;
            case 2:
                x = 0.0f;
                y = 0.0f;
                z = speed * Time.deltaTime;
                break;
            default:
                x = 0.0f;
                y = 0.0f;
                z = 0.0f;
                break;
        }
        transform.Rotate(10.0f * Time.deltaTime, 0.0f, 0.0f);
        r += 0.1f;
        if(r>1.0f)ref = 0.0f;
        g += 0.1f;
         if(g>1.0f)ref = 0.0f;
        b += 0.1f;
        if(b>1.0f)ref = 0.0f;
        Renderer.material.color = new Color(r,g,b,0.4f);
    }
}
