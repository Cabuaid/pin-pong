using UnityEngine;
using TMPro;
public class GoalManager : MonoBehaviour
{

    //[SerializeField] 

    [SerializeField] TMP_Text goalText;
    [SerializeField] public int player1Goal = 0; // variavel to player 1 text
    [SerializeField] public int player2Goal = 0; //variavel to player 2 text





    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {




    }


    // Update is called once per frame
    void Update()
    {
        goalText.text = $"{player1Goal} - {player2Goal}"; // make variavel for chance the text

       

    }
}
    