using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RunCountdown : MonoBehaviour
{
  private Text label; 
  
  IEnumerator Start()
  {
    
    label = GetComponent<Text>();

    int number = 1000;
    
    while (number > 0)
    {
      yield return new WaitForSeconds(1);
      label.text = number.ToString();
      number--; 
    }

    label.text = ""; 
    yield return new WaitForSeconds(1);
    label.text = "GO!";
  }
}
