using System;
using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    public Text text;

    // Update is called once per frame
    void Update()
    {
        if( Input.GetAxis("Fire1") != 0)
        {
            UserClicked();
        }
    }

    private void UserClicked()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if( Physics.Raycast(ray, out hit) )
        {
            if( hit.transform.CompareTag("Shape"))
            {
                Colour s = hit.transform.GetComponent<Colour>();
                s.ReturnInput(text);
            }
        }
    }
}
