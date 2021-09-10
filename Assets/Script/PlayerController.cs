using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed = 5f;

    Vector2 vec;
    string HORIZONTAL = "Horizontal";
    string VERTICAL = "Vertical";
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        vec.x = Input.GetAxisRaw(HORIZONTAL);
        vec.y = Input.GetAxisRaw(VERTICAL);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + vec * moveSpeed * Time.fixedDeltaTime);
    }
}
