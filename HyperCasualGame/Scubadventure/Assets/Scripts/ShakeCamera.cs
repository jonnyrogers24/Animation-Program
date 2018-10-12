using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeCamera : MonoBehaviour
{
    public float duration = .03f;
    public float magnitude = .03f; 
    
    public IEnumerator Shake()
    {
        Vector3 originalPosition = transform.localPosition;
        float elapsed = 0.0f;

        while (elapsed < duration)
        {
            float x = Random.Range(-1f, 1f) * magnitude; 
            float y = Random.Range(-1f, 1f) * magnitude;
            
            transform.localPosition = new Vector3(originalPosition.x + x,originalPosition.y +y, originalPosition.z);
            elapsed += Time.deltaTime;
            yield return null; 
        }

        transform.localPosition = originalPosition; 
    }
}
