using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Colour : Shape
{
    [SerializeField] Color32 colour;
    internal override void ReturnInput(Text text)
    {
        text.text = materials[0].color.ToString();
    }

    new internal void SetShape()
    {
        Debug.Log(colour.ToString());
        Material m = new Material(materials[0]);
        m.SetColor("_Color", colour);
        materials[0] = m;
        base.SetShape();
    }
    void Start()
    {
        filter = GetComponent<MeshFilter>();
        collider = GetComponent<MeshCollider>();
        renderer = GetComponent<MeshRenderer>();

        SetShape();
    }
}
