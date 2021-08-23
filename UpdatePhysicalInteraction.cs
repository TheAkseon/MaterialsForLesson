using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdatePhysicalInteraction : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent(out Arch arch))
        {
            Destroy(arch.gameObject);
        }
    }
}
