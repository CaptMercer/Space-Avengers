using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Transform player;
    //public Transform Deadplayer;
    [SerializeField]
    private float speed = 10f;
	public Transform Point1,Point2,Point3,Point4;
   private AudioSource AudioM;
  void Start()
    {
        AudioM = GetComponent<AudioSource>();
		
   }
    void Update()
    {
        if (Player.lose == true)
       {
                   AudioM.Stop();
       }
    }
    void OnMouseDrag()
    {
        if (!Player.lose)
        {
            Vector3 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			MousePos.x = MousePos.x > Point2.position.x ?  Point2.position.x : MousePos.x;
            MousePos.x = MousePos.x < Point1.position.x ? Point1.position.x : MousePos.x;
			MousePos.y = MousePos.y <Point1.position.y ?  Point1.position.y : MousePos.y;
            MousePos.y = MousePos.y > Point4.position.y ? Point4.position.y : MousePos.y;
           // MousePos.x = MousePos.x > 6f ? 6f : MousePos.x;
          //  MousePos.x = MousePos.x < -6.1f ? -6.1f : MousePos.x;
            player.position = Vector2.MoveTowards(player.position, new Vector2(MousePos.x, MousePos.y), speed * Time.deltaTime);
        }
    }
}
