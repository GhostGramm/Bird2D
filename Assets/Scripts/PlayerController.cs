using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private int speed;
    [SerializeField] private bool canMove = false;
    [SerializeField] float border;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
            Move();
    }

    public void Move()
    {
        float InputY = Input.GetAxis("Vertical");
        transform.position += Vector3.up * InputY * speed * Time.deltaTime;

        float clampY = Mathf.Clamp(transform.position.y, -border, border);
        transform.position = new Vector3(transform.position.x, clampY, transform.position.z);
    }
}
