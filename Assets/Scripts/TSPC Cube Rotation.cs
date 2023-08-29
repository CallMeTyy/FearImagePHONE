using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TSPCCubeRotation : MonoBehaviour
{
    public bool Right;
    public bool Left;
    public bool Stop;
    [HideInInspector] public Color red = Color.red;

    void Start()
    {
        Right = true;
    }

    void Update()
    {

        if (!Stop)
        {
            if (Left)
            {
                transform.Rotate(0, 30 * Time.deltaTime, 0, Space.Self);
            }
            else if (Right)
            {
                transform.Rotate(0, -30 * Time.deltaTime, 0, Space.Self);
            }
        }
    }
}
