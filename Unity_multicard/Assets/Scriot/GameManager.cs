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
    [Header("動畫元件")]
    public Animator animghost;
    public Animator animcovid19;

    private void Start()
    {
        print("start");
    }

    private void Update()
    {
        

        if(Mathf.Abs(floatingJoystick.Vertical) < 0.5f)
        { 
        covid19.Rotate(0, -floatingJoystick.Horizontal * speed, 0);
            ghost.Rotate(0, -floatingJoystick.Horizontal * speed, 0);

        }
        if (Mathf.Abs(floatingJoystick.Horizontal) < 0.5f)
        {
            covid19.localScale += new Vector3(1, 1, 1)* floatingJoystick.Vertical* size;
            ghost.localScale += new Vector3(1, 1, 1) * floatingJoystick.Vertical * size;

        }

        covid19.localScale = new Vector3(1, 1, 1) * Mathf.Clamp(covid19.localScale.x, 0.5f, 3.5f);
        ghost.localScale = new Vector3(1, 1, 1) * Mathf.Clamp(covid19.localScale.x, 0.5f, 3.5f);

        print(floatingJoystick.Vertical + "," + floatingJoystick.Horizontal);
    }

    public void Playanim(string Name)
    {
        animcovid19.SetTrigger(Name);
        animghost.SetTrigger(Name);
    }
}
