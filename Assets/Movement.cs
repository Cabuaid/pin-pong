using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField,Range(0.0005f,25)] float speed; // speed range 
   [SerializeField]KeyCode up = KeyCode. W; // to make choose a key to moeve
   [SerializeField]KeyCode down = KeyCode.S;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print(speed); 
    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetKey(up)) // to be able to go upp 
            {
            print("go upp");// to be able to go down
            transform.position += new Vector3(0, 1, 0) * speed * Time.deltaTime;

            
            }

        if (Input.GetKey(down)) // to be able to go down
        {
        
            print("go dow");
            transform.position += new Vector3(0, -1, 0) * speed * Time.deltaTime; // to fix the exageret speed problem



        }
        
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }
}
