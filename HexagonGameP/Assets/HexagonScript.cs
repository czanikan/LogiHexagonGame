using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexagonScript : MonoBehaviour
{

    public float shrink = 3f;

    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.transform.Rotate(Vector3.forward * Random.Range(0, 360));
        transform.localScale = Vector3.one * 10f;
    }

    void Update()
    {
        transform.localScale -= Vector3.one * shrink * Time.deltaTime;
        if (transform.localScale.x <= 0.05f)
        {
            Destroy(gameObject);
        }
    }
}
