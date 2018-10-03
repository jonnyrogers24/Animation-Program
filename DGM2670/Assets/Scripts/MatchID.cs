using UnityEngine;
using UnityEngine.Events;

public class MatchID : MonoBehaviour
{

    public NameID ID;
    public UnityEvent OnMatch; 
   
    public void Invoke(NameID id)
        {
            if (id == ID)
            {
                OnMatch.Invoke();
                print("MATCH!");
            }
        }
}
