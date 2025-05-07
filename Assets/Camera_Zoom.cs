using UnityEngine;

public class Camera_Zoom : MonoBehaviour
{

    Camera _This_Cam;

    private int _Zoom_Counter;

    private float _Default_Zoom_Field_Of_View;
    private float _Medium_Zoom_Field_Of_View;
    private float _Close_Zoom_Field_Of_View;

    void Start()
    {
        _This_Cam = GetComponent<Camera>();
        _Default_Zoom_Field_Of_View = 60;
        _Medium_Zoom_Field_Of_View = 20;
        _Close_Zoom_Field_Of_View = 3.3f;
        Set_Default_Zoom();
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Mouse1))
            Check_Zoom();

    }

    void Check_Zoom()
    {

        _Zoom_Counter++;

        switch (_Zoom_Counter)
        {
            case 1:
                Set_Medium_Zoom();
                break;
            case 2:
                Set_Close_Zoom();
                break;
            default:
                _Zoom_Counter = 0;
                Set_Default_Zoom();
                break;
        }

    }

    void Set_Default_Zoom()
    {
        _This_Cam.fieldOfView = _Default_Zoom_Field_Of_View;
    }

    void Set_Medium_Zoom()
    {
        _This_Cam.fieldOfView = _Medium_Zoom_Field_Of_View;
    }

    void Set_Close_Zoom()
    {
        _This_Cam.fieldOfView = _Close_Zoom_Field_Of_View;
    }

}