using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button2 : MonoBehaviour
{
    public float indent = 200;

    private void OnMouseEnter()
    {
        Vector3 position = transform.position;
        position.x = transform.position.x + indent;
        transform.position = position;
    }

    private void OnMouseExit()
    {
        Vector3 position = transform.position;
        position.x = transform.position.x - indent;
        transform.position = position;
    }

    void Update()
    {
        
    }

    public void OnClick()
    {

    }

}
