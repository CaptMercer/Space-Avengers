using UnityEngine;
using UnityEngine.UI;
public class FallDown : MonoBehaviour
{
    [SerializeField]
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
		if (Other.gameObject.tag == "SHOOT")
		{
		  Destroy(gameObject);
		}
	}
}
//ssssss
