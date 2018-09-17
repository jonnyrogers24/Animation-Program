using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class MovePatternNotGrounded : ScriptableObject 
{
    public void Invoke(CharacterController controller, Transform transform)
    {
        MoveT(transform);
        MoveC(controller);
    }

    private void MoveC(CharacterController controller)
    {
        throw new System.NotImplementedException();
    }

    private void MoveT(Transform transform)
    {
        throw new System.NotImplementedException();
    }
}
