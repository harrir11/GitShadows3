using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour
{
    private Vector2 target = new Vector2(4.5f, -8);

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if(Input.GetMouseButtonDown(0)) {
            target = new Vector2(mousePos.x, -8);
        }

        transform.position = Vector2.MoveTowards(transform.position, target, Time.deltaTime * 5f);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.gameObject.name + " : " + gameObject.name + " : " + Time.time);
        Debug.Log("Press space bar to move curtain");
    }
}
