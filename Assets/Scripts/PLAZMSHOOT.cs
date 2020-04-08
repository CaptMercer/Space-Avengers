using UnityEngine;
using UnityEngine.UI;

public class PLAZMSHOOT : MonoBehaviour
{
    [SerializeField]
    public static int score = 0;
    private float ShootSpeed = 9f;
    void Update()
    {
         if (transform.position.y > 5.4f)
        {
            Destroy(gameObject);
		}
	transform.position += new Vector3(0, ShootSpeed * Time.deltaTime, 0);
    }
		  void OnTriggerEnter2D (Collider2D Other)
   {
		if (Other.gameObject.tag == "Bomb")
		{
		  Destroy(gameObject);
		}
	}
}

