using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cylinder : Shape
{
    [SerializeField] float pauseTimer = 0f;
    internal override void ReturnInput(Text text)
    {
        pauseTimer = 3f;
        base.ReturnInput(text);
    }
    private void Update()
    {
        if (pauseTimer <= 0)
            transform.rotation *= Quaternion.Euler(1f * RotationSpeed, 0, 1f * RotationSpeed);
        else
            pauseTimer -= Time.deltaTime;

    }
}
