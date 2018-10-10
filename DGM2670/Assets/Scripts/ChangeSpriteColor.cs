using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ChangeSpriteColor : ScriptableObject
{
    public ColorData Color;

    public void Call (SpriteRenderer spriteRenderer)
    {
        spriteRenderer.color = Color.Value; 
    }
    
    public void Call (Material material)
    {
        material.color = Color.Value; 
    }
}
