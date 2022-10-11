using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class RunCS : MonoBehaviour
{
   
    public ComputeShader cs;
    public Material material;
    int kernelShader;
    int size;
    RenderTexture tex;


    // Start is called before the first frame update
    void Start()
    {
        kernelShader = cs.FindKernel("PerlinNoise");
        size = 4096;
        tex = new RenderTexture(size,size,24);
        tex.enableRandomWrite = true;
        tex.Create();
        material.mainTexture = tex;

        cs.SetTexture(kernelShader,"Result",tex);

        cs.SetInt("size", size);
        cs.SetFloat("scale", 100f);
        cs.SetInt("Type", 0);
        cs.SetInt("State", 0);
    }

    // Update is called once per frame
    void Update()
    {
        RunComputeShader();
        
    }
    void RunComputeShader()
    {
        

        cs.Dispatch(kernelShader,size/8,size/8,1);

    }
   
}
