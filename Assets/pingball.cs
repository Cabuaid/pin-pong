using UnityEngine;

public class pingball : MonoBehaviour
{

    [SerializeField, Range(0.5f, 10)] float speed; // speed range (to canchage it more easy in unity)
    Vector3 dir = Vector3.right; 


    GoalManager goal; // refernce to points script


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        goal = FindAnyObjectByType<GoalManager>(); // help to count the points
        ResetBall();
        

    }


    void ResetBall()
    {
        transform.position = new Vector3(0, 0, 0); // make the ball choose a random direction
        int randomValue = Random.Range(0, 2);

        if (randomValue == 0) // make it choose rith
        {
            dir = Vector3.right;
        }

        else if (randomValue == 1) //make it choose left
        {
            dir = Vector3.left;
        }


        float yDir = Random.Range(-1, 1f); // make it also go uop or down

        dir.y = yDir; // idk but it help the other thing

        

    }

    // Update is called once per frame
    void Update()
    {

        transform.position += dir * speed * Time.deltaTime;


        if (transform.position.x > 12 || transform.position.x < -12)
        {
            print("reset");

             


            if (transform.position.x > 0) //give player2 1 point 
            {
                goal.player2Goal += 1;
            }

            else // give player1 1 point
            {
                goal.player1Goal += 1;
            }

            ResetBall();
        }





    }






    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.GetComponent<Movement>() == true)
        {
            print("kollision with" + collision.gameObject.name); //compare colisoon object
           
            dir.x *= -1;
            speed *= 1.20f;
        
        }
        if(collision.CompareTag("wall"))
        {
            print("find a wall");
            dir.y *= -1;  // coliison with wall
            speed *= 1.20f; //increment speed
        }




        // totaly uselees here but  can help in the future

        if (collision.CompareTag("point")) // in case i need  a wall for the goals
        {
            print("player1Goal");




        }

        if (collision.CompareTag("point2"))
        {
            print("player2Goal");

        }
        



    }
    













}












