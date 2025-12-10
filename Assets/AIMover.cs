using UnityEngine;
using UnityEngine.AI; 

public class AIMover : MonoBehaviour
{
    public Transform targetDestination; 
    
    private NavMeshAgent myAgent;

    void Start()
    {
        //Get your own NavMeshAgent component
        myAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        // Tell the AI ​​in every frame: Go to the location of the target
        if (targetDestination != null)
        {
            myAgent.SetDestination(targetDestination.position);
        }
    }
}