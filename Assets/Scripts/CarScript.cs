using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 2f;
    public float max = 12f;
    public float min = 8f;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }
    private void Start()
    {
        speed = Random.Range(max, min);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);
        
    }
    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.tag == "Player")
        {
            Destroy(target.gameObject);
        }
    }
}
