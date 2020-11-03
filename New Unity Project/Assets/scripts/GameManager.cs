using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header ("獅子")]
    public Transform lion;
    [Header ("企鵝")]
    public Transform penguin;
    [Header("joystick")]
    public FixedJoystick joystick;
    [Header("旋轉速度"),Range(0.1f,20f)]
    public float turn = 1.5f;
    [Header("縮放"), Range(0f, 5f)]
    public float size = 0.3f;
    private void Start()
    {
        print("開始事件");   
    }
    private void Update()
    {
        print("更新事件");
        print(joystick.Vertical);
        lion.Rotate(0, joystick.Horizontal*turn , 0);
        penguin.Rotate(0, joystick.Horizontal * turn, 0);
        lion.localScale += new Vector3(1, 1, 1) * joystick.Vertical*size;
    }
}
