using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MovePatternDual")]
public class MovePatternDual : MovePattern
{
	private bool doubleJump; 
	
	public override void Invoke(CharacterController controller, Transform transform)
	{
		if (controller.isGrounded)
		{
			MoveT(transform);
			doubleJump = true; 
		}
		else
		{
			if (doubleJump)
			{
				MoveT(transform);
				doubleJump = false; 
			}
		}
		
		MoveC(controller);
	}

}
