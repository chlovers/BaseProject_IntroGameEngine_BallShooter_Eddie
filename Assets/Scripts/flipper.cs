using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flipper : MonoBehaviour
{


    // Update is called once per frame
    private void FixedUpdate()
    {
        transform.Rotate(-2f, 0, 0 * Time.fixedDeltaTime);
    }
}
