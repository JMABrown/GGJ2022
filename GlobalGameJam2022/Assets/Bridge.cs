using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour
{
    public bool collisionDetected = false;
    

    private void Update()
    {
        if (collisionDetected)
        {
            transform.Rotate(0, 0, 30 * Time.deltaTime);

            if (transform.rotation.eulerAngles.z >= 100) collisionDetected = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.layer == LayerMask.GetMask("Bullet")) collisionDetected = true;
    }

    public void SetCollision(bool active)
    {
        collisionDetected = active;
    }
}
