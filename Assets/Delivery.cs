using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool holdPackage = false;
    [SerializeField] float dissapearTime;
    [SerializeField] Color32 hasNoPackageColor = new Color32(255, 255, 255, 255);
    [SerializeField] Color32 hasPackageColor = new Color32(255, 255, 255, 255);

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && holdPackage == false)
        {
            Debug.Log("Package is picked up");
            holdPackage = true;
            Destroy(other.gameObject, dissapearTime);
            spriteRenderer.color = hasPackageColor;
        }
        else if (other.tag == "Package" && holdPackage == true)
        {
            Debug.Log("You already picked up a Package!");
        }
        if (other.tag == "Customer" && holdPackage == true)
        {
            Debug.Log("Packge got deliverd");
            holdPackage = false;
            spriteRenderer.color = hasNoPackageColor;
        }
        else if (other.tag == "Customer" && holdPackage == false)
        {
            Debug.Log("You got no Package yet!");
        }
    }
}
