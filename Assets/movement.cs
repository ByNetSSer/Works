using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    public int direccionx = 1;
    public int direcciony = 1;
    public float g;
    private Transform _TRansform;
    private SpriteRenderer renderizado;
    // Start is called before the first frame update
    void Start()
    {
        _TRansform = GetComponent<Transform>();
        renderizado = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        _TRansform.position = new Vector2(_TRansform.position.x + g * direccionx * Time.deltaTime, _TRansform.position.y);
        if (_TRansform.position.x <= -6.50f)
        {
            renderizado.color = new Color(Random.Range(1, 100) / 255.0f, Random.Range(1, 100) / 255.0f, Random.Range(1, 100) / 255.0f);
            direccionx = 1;
            renderizado.flipX = false;
        }
        else if (transform.position.x >= 6.50f)
        {
            direccionx = -1;
            renderizado.color = new Color(Random.Range(1, 100) / 255.0f, Random.Range(1, 100) / 255.0f, Random.Range(1, 100) / 255.0f);
            renderizado.flipX = true;
        }
        _TRansform.position = new Vector2(_TRansform.position.x, _TRansform.position.y + g * direcciony * Time.deltaTime);
        if (_TRansform.position.y <= -4.00f)
        {
            direcciony = 1;
            renderizado.flipY = false;
            renderizado.color = new Color(Random.Range(1, 100) / 255.0f, Random.Range(1, 100) / 255.0f, Random.Range(1, 100) / 255.0f);
        }
        else if (transform.position.y >= 4.00f)
        {
            renderizado.color = new Color(Random.Range(1, 100) / 255.0f, Random.Range(1, 100) / 255.0f, Random.Range(1, 100) / 255.0f);
            direcciony = -1;
            renderizado.flipY = true;
        }

    }
}


