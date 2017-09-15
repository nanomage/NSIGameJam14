using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    public float scrollSpeed = 0.25f;
    private Renderer rend;

    public bool isForest, isLake, isCastle;
    public Material[] materials;

    // Use this for initialization
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isForest && !isLake && !isCastle)
        {
            rend.material = materials[0];
        }

        else if(isLake && !isForest && !isCastle)
        {
            rend.material = materials[1];
        }

        else if (isCastle && !isForest && !isLake)
        {
            rend.material = materials[2];
        }

        float offset = Time.time * scrollSpeed;
        rend.material.SetTextureOffset("_MainTex", new Vector2(0, -offset));
    }
}
