using UnityEngine;

public class MissingComponentDemo : MonoBehaviour
{
	private void Start()
	{
		AudioSource audioSource = GetComponent<AudioSource>();
    // empty component check
		if (audioSource != null)
		{
			audioSource.Play();
		}
    else
    {
      Debug.Log("No AudioSource component found on " + gameObject.name);
    }
	}
}
