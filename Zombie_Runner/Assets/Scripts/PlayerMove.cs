using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float playerSpeed = 5f;
    public float leftrRightSpeed = 3f;

    void Update()
    {
        /* Manual Forward Movment...

         if (Input.GetKey(KeyCode.Space))
         {
             transform.Translate(playerSpeed * Time.deltaTime * Vector3.forward, Space.World);
         }
        */

        transform.Translate(playerSpeed * Time.deltaTime * Vector3.forward, Space.World);

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x > LevelBounds.leftBounds)
            {
                transform.Translate(playerSpeed * 1 * Time.deltaTime * Vector3.left, Space.World);
            }
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < LevelBounds.rightBounds)
            {
                transform.Translate(playerSpeed * 1 * Time.deltaTime * Vector3.right, Space.World);
            }
        }
    }
}
