
using UnityEngine;

[CreateAssetMenu]
public class InstanceObject : ScriptableObject {

	public void Call(GameObject instance)
	{
		Instantiate(instance); 
	}
}
