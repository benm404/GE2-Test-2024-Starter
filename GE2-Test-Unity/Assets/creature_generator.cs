using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creature_generator : MonoBehaviour
{
    [Range(0.0f, 100.0f)]
    public int length;

    [Range(0, 100)]
    public float frequency;

    [Range(0.0f, 360.0f)]
    public float start_angle;

    [Range(0.0f, 100.0f)]
    public float base_size;

    [Range(0.0f, 100.0f)]
    public float multiplier;

    [SerializeField] private bool p;

    float cube_radius;

    Vector3[] cube_positions;
    Vector3[] cube_sizes;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Mathf.Sin(start_angle * frequency/length);
        cube_positions = new Vector3[length];
        cube_sizes = new Vector3[length];

        cube_radius = Mathf.Sin(multiplier * base_size / frequency);


        if (Input.GetKeyDown(KeyCode.P))
        {
            p = !p;
        }

        if (!p)
        {
            for(int i = 0; i < length; i++)
            {
                cube_positions[i] = new Vector3(transform.position.x, transform.position.y, transform.position.z - base_size * i);
                cube_sizes[i] = new Vector3(cube_radius * i, cube_radius * i, cube_radius * i);
                print(cube_radius);
                
            }
        }
    }

    private void OnDrawGizmos()
    {
        for (int i = 0; i < length; i++)
        {
            Gizmos.color = (Color.red);
            Gizmos.DrawWireCube(cube_positions[i], cube_sizes[i]);
        }
    }
}
