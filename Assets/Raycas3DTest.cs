using UnityEngine;
using UnityEngine.UI;

public class Raycas3DTest : MonoBehaviour
{
    [SerializeField] LayerMask mask;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.up,out hit, 10, mask))
        {
            print("3D object");

        }
    }
}
