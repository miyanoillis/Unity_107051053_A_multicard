using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("物件")]
    public Transform ghost;
    public Transform covid19;
    [Header("控制桿")]
    public FloatingJoystick floatingJoystick;
    [Header("速度"), Range(0.1f, 10f)]
    public float speed = 10f;
    [Header("大小"), Range(0.1f, 1f)]
    public float size = 0.01f;

    private void Start()
    {
        print("start");
    }

    private void Update()
    {
        if(Mathf.Abs(floatingJoystick.Vertical) < 0.5f)
        { 
        covid19.Rotate(0, -floatingJoystick.Horizontal * speed, 0);
        }
        if (Mathf.Abs(floatingJoystick.Horizontal) < 0.5f)
        {
            covid19.localScale += new Vector3(1, 1, 1)* floatingJoystick.Vertical* size;
        }
        

        print(floatingJoystick.Vertical + "," + floatingJoystick.Horizontal);
    }
}
