using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(NavMeshAgent))]
public class AIAgent : MonoBehaviour
{
	private NavMeshAgent agent;
	public Transform Destination;
	public Transform PostPoint;
	private Transform finalDesination; 

	
	private void Start ()
	{
		agent = GetComponent<NavMeshAgent>();
		finalDesination = transform; 
	}

	private void OnTriggerEnter(Collider obj)
	{
		if (obj.transform == Destination)
			finalDesination = Destination; 
	}
	private void OnTriggerExit(Collider obj)
	{
		finalDesination = PostPoint; 
	}

	private void Update()
	{
		agent.destination = finalDesination.position;
	}
}
