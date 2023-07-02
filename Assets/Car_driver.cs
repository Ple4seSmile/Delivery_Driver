using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 0f;
    [SerializeField] float moveSpeed = 0f;
 //   private void OnCollisionEnter2D(Collision2D collision2D)
 //   {
 //       Destroy(collision2D.gameObject);
 //   }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);

        

    }
}
