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
    [SerializeField] private float rotationSpeed = 0.5f;
    internal float RotationSpeed
    {
        get { return rotationSpeed; }
    }
    [SerializeField] private string shapeName;

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
        text.text = shapeName;
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
        transform.rotation *= Quaternion.Euler(1f * rotationSpeed,0, 1f * rotationSpeed) ;
    }
}
