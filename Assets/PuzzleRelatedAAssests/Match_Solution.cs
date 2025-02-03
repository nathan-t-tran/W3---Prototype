using UnityEngine;

public class Match_Solution : MonoBehaviour
{
    public GameObject match_one;
    public GameObject match_two;
    public GameObject match_three;
    public GameObject match_four;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (match_one.activeInHierarchy && match_two.activeInHierarchy && match_three.activeInHierarchy && match_four.activeInHierarchy)
        {
            Destroy(gameObject);
        }
    }
}
