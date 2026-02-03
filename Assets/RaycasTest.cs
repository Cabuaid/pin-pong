using UnityEngine;

public class RaycasTest : MonoBehaviour
{
    [SerializeField]LayerMask mask;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up,10,mask );
        if(hit)
        {

            print("touched" + hit.transform.name);
        }
    
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawRay(transform.position, transform.up * 10);
    }


}
