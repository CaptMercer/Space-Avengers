using UnityEngine;
using UnityEngine.UI;

public class FallDown_Gold : MonoBehaviour
{
    [SerializeField]
    public static int score = 0;
    private float FallSpeed = 3f;
    private Text txt;
    void Start()
    {
           txt = GameObject.Find("Gold").GetComponent<Gold>();
    }
    void Update()
    {
         if (transform.position.y < -3.8f)
        {
            Destroy(gameObject);
		}
		    if (!Player.lose)
            {
                score++;
                txt.text ="Score:" + score.ToString();
            }
    }
}
