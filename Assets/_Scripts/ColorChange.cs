using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public Color targetColor;
    public Texture targetTex;

    // Start is called before the first frame update
    void Start()
    {
        Renderer renderer = GetComponent<Renderer>();
        Material material = renderer.material;
        material.color = targetColor;
        //efeito global renderer.sharedMaterial.color = targetColor;
        if(material.HasProperty("_MainTex"))
        {
            material.SetTexture("_MainTex", targetTex);
        }


    }
}
