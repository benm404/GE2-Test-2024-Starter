using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creature_generator : MonoBehaviour
{
    [Range(0.0f, 100.0f)]
    public int length;

    public float frequency;
    public float start_angle;
    public float base_size;
    public float multiplier;

    float size;

    [SerializeField] private bool p;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Mathf.Sin(start_angle);

        if (Input.GetKeyDown(KeyCode.P))
        {
            p = !p;
        }

        if (!p)
        {
            for(int i = 0; i <= length; i++)
            {
                Gizmos.DrawWireCube();
            }
        }
    }
}
