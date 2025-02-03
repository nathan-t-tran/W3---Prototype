using Unity.VisualScripting;
using UnityEngine;

public class PuzzleMatch : MonoBehaviour
{
    public GameObject puzzleSolved;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        puzzleSolved.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.tag == "puzzlePlate") //checks for a specific object type
        {
            //Debug.Log("i have collided with plate");
            puzzleSolved.SetActive(true);
        }
    }

    private void OnCollisionStay (Collision collision)
    {
        
    }

    private void OnCollisionExit (Collision collision)
    {
        //Debug.Log("i am not collided");
        puzzleSolved.SetActive(false);
    }
    
}
