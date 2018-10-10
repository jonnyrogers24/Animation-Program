using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

public class MatchID : MonoBehaviour
{

    public NameID ID;
    public UnityEvent OnMatch;

    private void OnTriggerEnter(Collider other)
    {
        var id = other.GetComponent<ObjectID>().ID;
           Call(id);
    }

    public void Call(NameID id)
        {
            if (id == ID)
            {
                OnMatch.Invoke();
                print("MATCH!");
            }
        }
}
