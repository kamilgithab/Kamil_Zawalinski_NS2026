using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class listazadanie2 : MonoBehaviour
{
    public List<GameObject> objekty = new List<GameObject>();
    void Start()
    {
        foreach(GameObject obj in objekty)
        {
            if(obj.GetComponent<MeshRenderer>() != null)
            {
                Debug.Log(obj.name + " jest 3D");
                tr(obj.transform);
                if(obj.GetComponent<SpriteRenderer>() != null)
                {
                    sr(obj.GetComponent<SpriteRenderer>());
                }
            }
            else if(obj.GetComponent<SpriteRenderer>() != null)
            {
                Debug.Log(obj.name + " jest 2D");
                tr(obj.transform);
                if(obj.GetComponent<SpriteRenderer>() != null)
                {
                    sr(obj.GetComponent<SpriteRenderer>());
                }
            }
        }
    }

    void Update()
    {
        
    }
    void tr( Transform trTarget)
    {
        if(trTarget.GetComponent<Transform>() == null)
        {
            return;
        }
        Transform tr = trTarget.GetComponent<Transform>();
        Debug.Log("Transform: " + tr.name);
    }
    void sr(SpriteRenderer srTarget)
    {
        SpriteRenderer sr = srTarget.GetComponent<SpriteRenderer>();
        Debug.Log("Sprite Renderer: " + sr.name);
    }
    
}
