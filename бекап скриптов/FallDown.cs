using UnityEngine;
using UnityEngine.UI;
public class FallDown : MonoBehaviour
{
    [SerializeField]
    public static int score = 0;
    private float FallSpeed = 3f;
    private Text txt;
    void Start()
    {
        txt = GameObject.Find("Text").GetComponent<Text>();
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
        transform.position -= new Vector3(0, FallSpeed * Time.deltaTime, 0);
    }
}
