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
			Move(transform);
			doubleJump = true; 
		}
		else
		{
			if (doubleJump)
			{
				Move(transform);
				doubleJump = false; 
			}
		}
		
		Move(controller);
	}

}
