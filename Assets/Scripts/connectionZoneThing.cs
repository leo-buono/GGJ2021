using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class connectionZoneThing : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        GameObject gameObj = collision.gameObject;
        if (gameObj.layer == 8)
        {

        }
    }
}
