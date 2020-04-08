using UnityEngine;
using UnityEngine.UI;

public class FallDown_Gold : MonoBehaviour
{
    [SerializeField]
    public static int score = 0;
    private float FallSpeed = 3f;
    void Update()
    {
         if (transform.position.y < -3.8f)
        {
            Destroy(gameObject);
		}
	transform.position -= new Vector3(0, FallSpeed * Time.deltaTime, 0);
    }
		  void OnTriggerEnter2D (Collider2D Other)
    {
		if (Other.gameObject.tag == "Player")
		{
		  Destroy(gameObject);
		}
	}
}