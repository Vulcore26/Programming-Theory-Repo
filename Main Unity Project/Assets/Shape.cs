using System;
using System.Collections;
using UnityEngine.UI;
using UnityEngine;
[RequireComponent(typeof(MeshCollider))]
[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class Shape : MonoBehaviour
{
    protected MeshFilter filter;
    protected new MeshCollider collider;
    protected new MeshRenderer renderer;
    [SerializeField] internal Mesh mesh;
    [SerializeField] internal Material[] materials;
    [SerializeField] float roationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        filter = GetComponent<MeshFilter>();
        collider = GetComponent<MeshCollider>();
        renderer = GetComponent<MeshRenderer>();

        SetShape();
    }

    internal virtual void ReturnInput(Text text)
    {
        text.text = gameObject.name;
    }

    // Update is called once per frame
    internal virtual void SetShape()
    {
        filter.mesh = mesh;
        renderer.materials = materials;
        collider.sharedMesh = mesh;
        collider.sharedMesh.RecalculateBounds();
        collider.sharedMesh.RecalculateNormals();
    }

    private void Update()
    {
        transform.rotation *= Quaternion.Euler(1f * roationSpeed,0, 1f * roationSpeed) ;
    }
}
