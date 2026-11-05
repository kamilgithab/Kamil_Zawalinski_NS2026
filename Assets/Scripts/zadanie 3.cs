using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadanie3 : MonoBehaviour
{
    public SpriteRenderer sprite;
    public Gradient gradient;
    public Color color;
    void Start()
    {
        
    }

    void Update()
    {
        sprite.color = gradient.Evaluate(sprite.transform.position.y);
        sprite.color = gradient.Evaluate(sprite.transform.rotation.x);
    }
}
