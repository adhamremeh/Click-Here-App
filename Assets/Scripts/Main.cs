using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{

    private int JustPress;
    private int No_heart;
    private int rotator;
    private int score;

    public GameObject Camera;

    public Color color;

    //for saying no heart
    public GameObject NO_heart;
    public GameObject why_did_u_press_again;
    public GameObject Do_u_remember;

    //for saying just press the button
    public GameObject LookToInvisible;
    public GameObject JustPressTheButton;
    public GameObject PressAgainPLZ;
    public GameObject DidUPressHere;

    //showing that's not the right button 
    public GameObject This_is_Not_Right_UP_T;
    public GameObject This_is_Not_Right_Down_T;

    //Hide the button and make a loop
    public GameObject Loop;
    public GameObject Button_To_Hide;

    //Arrow to rotate 
    public GameObject Rotator;
    public GameObject Rotator_Text;

    public GameObject RateGame;

    public GameObject UP_right_B;
    public GameObject UP_left_B;
    public GameObject Middle_right_B;
    public GameObject Middle_left_B;
    public GameObject Down_right_B;
    public GameObject Down_left_B;

    public GameObject UP_right_Arrow1;
    public GameObject UP_left_Arrow1;
    public GameObject Middle_right_Arrow1;
    public GameObject Middle_left_Arrow1;
    public GameObject Down_right_Arrow1;
    public GameObject Down_left_Arrow1;

    public GameObject UP_right_Arrow2;
    public GameObject UP_left_Arrow2;
    public GameObject Middle_right_Arrow2;
    public GameObject Middle_left_Arrow2;
    public GameObject Down_right_Arrow2;
    public GameObject Down_left_Arrow2;

    public GameObject UP_right_Arrow3;
    public GameObject UP_left_Arrow3;
    public GameObject Middle_right_Arrow3;
    public GameObject Middle_left_Arrow3;
    public GameObject Down_right_Arrow3;
    public GameObject Down_left_Arrow3;

    public GameObject UP_right_Arrow4;
    public GameObject UP_left_Arrow4;
    public GameObject Middle_right_Arrow4;
    public GameObject Middle_left_Arrow4;
    public GameObject Down_right_Arrow4;
    public GameObject Down_left_Arrow4;

    private int Show_button;
    private int Show_arrow;
    private int Show_nothing_loop;

    public Text Score;
    public GameObject Score_Object;
    // Start is called before the first frame update
    void Start()
    {
        Camera.GetComponent<ADmanager>().Ad();
        Show_button = Random.Range(1, 7);
        if (Show_button == 1)
        {
            UP_right_B.SetActive(true);
        }
        else if (Show_button == 2)
        {
            UP_left_B.SetActive(true);
        }
        else if (Show_button == 3)
        {
            Middle_right_B.SetActive(true);
        }
        else if (Show_button == 4)
        {
            Middle_left_B.SetActive(true);
        }
        else if (Show_button == 5)
        {
            Down_right_B.SetActive(true);
        }
        else if (Show_button == 6)
        {
            Down_left_B.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = score.ToString();
        Show_button = Random.Range(1, 7);
        Show_arrow = Random.Range(1, 5);
        if (Show_nothing_loop == 1)
        {
            Button_To_Hide.SetActive(false);
        }
        Rotator.transform.Rotate(0, 0, 2);
        Rotator_Text.transform.Rotate(0, 0, 2);
        if (rotator == 1)
        {
            Camera.transform.Rotate(0, 0, 2);
        }


    }

    //send the camera to heart 
    public void Invisible_Button()
    {
        Camera.transform.position = new Vector3(-10f, 0 , -10); 
    }
    //send the camera back from heart
    public void Heart_Button()
    {
        Camera.transform.position = new Vector3(0, 0, -10);
    }
    //saying no heart here
    public void No_Heart()
    {
        No_heart++;
        if (No_heart == 1)
        {
            NO_heart.SetActive(true);
        }
        else if (No_heart == 2)
        {
            NO_heart.SetActive(false);
            why_did_u_press_again.SetActive(true);
        }
        else if (No_heart >= 3)
        {
            NO_heart.SetActive(false);
            why_did_u_press_again.SetActive(false);
            Do_u_remember.SetActive(true);
        }
    }
    //showing arrows to button which shows *just press the button* middle-left
    public void Look_to_Invisible()
    {
        LookToInvisible.SetActive(true);
    }
    //showing *just press the button*
    public void Just_press_the_Button()
    {
        if (JustPress < 1)
        {
            JustPress++;
        }
        if (JustPress == 1)
        {
            JustPressTheButton.SetActive(true);
        }
        
    }
    //showing that's not the right button UP
    public void This_is_Not_Right_UP()
    {
        This_is_Not_Right_UP_T.SetActive(true);
    }
    //showing that's not the right button Down
    public void This_is_Not_Right_Down()
    {
        This_is_Not_Right_Down_T.SetActive(true);
    }
    //make the dark mode
    public void DarkMode()
    {
        Camera.GetComponent<Camera>().backgroundColor = color;
    }
    //Loop and stuck
    public void LOOP()
    {
        Loop.SetActive(true);
        Score_Object.SetActive(false);
        Show_nothing_loop = 1;
    }
    //rotate the camera
    public void rotate()
    {
        rotator = 1;
    }
    //rate this game plz
    public void Rate()
    {
        RateGame.SetActive(true);
    }
    public void GoRate()
    {
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.RedBread.ClickHere");
    }

    public void UP_right()
    {
        score++;
        rotator = 0;
        Camera.transform.SetPositionAndRotation(Camera.transform.position, Quaternion.Euler(0,0,0));
        if (Show_button == 2)
        {
            if (Show_arrow == 1)
            {
                UP_left_Arrow1.SetActive(true);
                UP_left_Arrow2.SetActive(false);
                UP_left_Arrow3.SetActive(false);
                UP_left_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 2)
            {
                UP_left_Arrow1.SetActive(false);
                UP_left_Arrow2.SetActive(true);
                UP_left_Arrow3.SetActive(false);
                UP_left_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 3)
            {
                UP_left_Arrow1.SetActive(false);
                UP_left_Arrow2.SetActive(false);
                UP_left_Arrow3.SetActive(true);
                UP_left_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 4)
            {
                UP_left_Arrow1.SetActive(false);
                UP_left_Arrow2.SetActive(false);
                UP_left_Arrow3.SetActive(false);
                UP_left_Arrow4.SetActive(true);
            }
            UP_right_B.SetActive(false);
            UP_left_B.SetActive(true);
            Middle_right_B.SetActive(false);
            Middle_left_B.SetActive(false);
            Down_right_B.SetActive(false);
            Down_left_B.SetActive(false);
        }
        else if (Show_button == 3)
        {
            if (Show_arrow == 1)
            {
                Middle_right_Arrow1.SetActive(true);
                Middle_right_Arrow2.SetActive(false);
                Middle_right_Arrow3.SetActive(false);
                Middle_right_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 2)
            {
                Middle_right_Arrow1.SetActive(false);
                Middle_right_Arrow2.SetActive(true);
                Middle_right_Arrow3.SetActive(false);
                Middle_right_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 3)
            {
                Middle_right_Arrow1.SetActive(false);
                Middle_right_Arrow2.SetActive(false);
                Middle_right_Arrow3.SetActive(true);
                Middle_right_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 4)
            {
                Middle_right_Arrow1.SetActive(false);
                Middle_right_Arrow2.SetActive(false);
                Middle_right_Arrow3.SetActive(false);
                Middle_right_Arrow4.SetActive(true);
            }
            UP_right_B.SetActive(false);
            UP_left_B.SetActive(false);
            Middle_right_B.SetActive(true);
            Middle_left_B.SetActive(false);
            Down_right_B.SetActive(false);
            Down_left_B.SetActive(false);
        }
        else if (Show_button == 4)
        {
            if (Show_arrow == 1)
            {
                Middle_left_Arrow1.SetActive(true);
                Middle_left_Arrow2.SetActive(false);
                Middle_left_Arrow3.SetActive(false);
                Middle_left_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 2)
            {
                Middle_left_Arrow1.SetActive(false);
                Middle_left_Arrow2.SetActive(true);
                Middle_left_Arrow3.SetActive(false);
                Middle_left_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 3)
            {
                Middle_left_Arrow1.SetActive(false);
                Middle_left_Arrow2.SetActive(false);
                Middle_left_Arrow3.SetActive(true);
                Middle_left_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 4)
            {
                Middle_left_Arrow1.SetActive(false);
                Middle_left_Arrow2.SetActive(false);
                Middle_left_Arrow3.SetActive(false);
                Middle_left_Arrow4.SetActive(true);
            }
            UP_right_B.SetActive(false);
            UP_left_B.SetActive(false);
            Middle_right_B.SetActive(false);
            Middle_left_B.SetActive(true);
            Down_right_B.SetActive(false);
            Down_left_B.SetActive(false);
        }
        else if (Show_button == 5)
        {
            if (Show_arrow == 1)
            {
                Down_right_Arrow1.SetActive(true);
                Down_right_Arrow2.SetActive(false);
                Down_right_Arrow3.SetActive(false);
                Down_right_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 2)
            {
                Down_right_Arrow1.SetActive(false);
                Down_right_Arrow2.SetActive(true);
                Down_right_Arrow3.SetActive(false);
                Down_right_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 3)
            {
                Down_right_Arrow1.SetActive(false);
                Down_right_Arrow2.SetActive(false);
                Down_right_Arrow3.SetActive(true);
                Down_right_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 4)
            {
                Down_right_Arrow1.SetActive(false);
                Down_right_Arrow2.SetActive(false);
                Down_right_Arrow3.SetActive(false);
                Down_right_Arrow4.SetActive(true);
            }
            UP_right_B.SetActive(false);
            UP_left_B.SetActive(false);
            Middle_right_B.SetActive(false);
            Middle_left_B.SetActive(false);
            Down_right_B.SetActive(true);
            Down_left_B.SetActive(false);
        }
        else if (Show_button == 6)
        {
            if (Show_arrow == 1)
            {
                Down_left_Arrow1.SetActive(true);
                Down_left_Arrow2.SetActive(false);
                Down_left_Arrow3.SetActive(false);
                Down_left_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 2)
            {
                Down_left_Arrow1.SetActive(false);
                Down_left_Arrow2.SetActive(true);
                Down_left_Arrow3.SetActive(false);
                Down_left_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 3)
            {
                Down_left_Arrow1.SetActive(false);
                Down_left_Arrow2.SetActive(false);
                Down_left_Arrow3.SetActive(true);
                Down_left_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 4)
            {
                Down_left_Arrow1.SetActive(false);
                Down_left_Arrow2.SetActive(false);
                Down_left_Arrow3.SetActive(false);
                Down_left_Arrow4.SetActive(true);
            }
            UP_right_B.SetActive(false);
            UP_left_B.SetActive(false);
            Middle_right_B.SetActive(false);
            Middle_left_B.SetActive(false);
            Down_right_B.SetActive(false);
            Down_left_B.SetActive(true);
        }
    }
    public void UP_left()
    {
        score++;
        if (Show_button == 1)
        {
            if (Show_arrow == 1)
            {
                UP_right_Arrow1.SetActive(true);
                UP_right_Arrow2.SetActive(false);
                UP_right_Arrow3.SetActive(false);
                UP_right_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 2)
            {
                UP_right_Arrow1.SetActive(false);
                UP_right_Arrow2.SetActive(true);
                UP_right_Arrow3.SetActive(false);
                UP_right_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 3)
            {
                UP_right_Arrow1.SetActive(false);
                UP_right_Arrow2.SetActive(false);
                UP_right_Arrow3.SetActive(true);
                UP_right_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 4)
            {
                UP_right_Arrow1.SetActive(false);
                UP_right_Arrow2.SetActive(false);
                UP_right_Arrow3.SetActive(false);
                UP_right_Arrow4.SetActive(true);
            }
            UP_right_B.SetActive(true);
            UP_left_B.SetActive(false);
            Middle_right_B.SetActive(false);
            Middle_left_B.SetActive(false);
            Down_right_B.SetActive(false);
            Down_left_B.SetActive(false);
        }
        else if (Show_button == 3)
        {
            if (Show_arrow == 1)
            {
                Middle_right_Arrow1.SetActive(true);
                Middle_right_Arrow2.SetActive(false);
                Middle_right_Arrow3.SetActive(false);
                Middle_right_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 2)
            {
                Middle_right_Arrow1.SetActive(false);
                Middle_right_Arrow2.SetActive(true);
                Middle_right_Arrow3.SetActive(false);
                Middle_right_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 3)
            {
                Middle_right_Arrow1.SetActive(false);
                Middle_right_Arrow2.SetActive(false);
                Middle_right_Arrow3.SetActive(true);
                Middle_right_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 4)
            {
                Middle_right_Arrow1.SetActive(false);
                Middle_right_Arrow2.SetActive(false);
                Middle_right_Arrow3.SetActive(false);
                Middle_right_Arrow4.SetActive(true);
            }
            UP_right_B.SetActive(false);
            UP_left_B.SetActive(false);
            Middle_right_B.SetActive(true);
            Middle_left_B.SetActive(false);
            Down_right_B.SetActive(false);
            Down_left_B.SetActive(false);
        }
        else if (Show_button == 4)
        {
            if (Show_arrow == 1)
            {
                Middle_left_Arrow1.SetActive(true);
                Middle_left_Arrow2.SetActive(false);
                Middle_left_Arrow3.SetActive(false);
                Middle_left_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 2)
            {
                Middle_left_Arrow1.SetActive(false);
                Middle_left_Arrow2.SetActive(true);
                Middle_left_Arrow3.SetActive(false);
                Middle_left_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 3)
            {
                Middle_left_Arrow1.SetActive(false);
                Middle_left_Arrow2.SetActive(false);
                Middle_left_Arrow3.SetActive(true);
                Middle_left_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 4)
            {
                Middle_left_Arrow1.SetActive(false);
                Middle_left_Arrow2.SetActive(false);
                Middle_left_Arrow3.SetActive(false);
                Middle_left_Arrow4.SetActive(true);
            }
            UP_right_B.SetActive(false);
            UP_left_B.SetActive(false);
            Middle_right_B.SetActive(false);
            Middle_left_B.SetActive(true);
            Down_right_B.SetActive(false);
            Down_left_B.SetActive(false);
        }
        else if (Show_button == 5)
        {
            if (Show_arrow == 1)
            {
                Down_right_Arrow1.SetActive(true);
                Down_right_Arrow2.SetActive(false);
                Down_right_Arrow3.SetActive(false);
                Down_right_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 2)
            {
                Down_right_Arrow1.SetActive(false);
                Down_right_Arrow2.SetActive(true);
                Down_right_Arrow3.SetActive(false);
                Down_right_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 3)
            {
                Down_right_Arrow1.SetActive(false);
                Down_right_Arrow2.SetActive(false);
                Down_right_Arrow3.SetActive(true);
                Down_right_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 4)
            {
                Down_right_Arrow1.SetActive(false);
                Down_right_Arrow2.SetActive(false);
                Down_right_Arrow3.SetActive(false);
                Down_right_Arrow4.SetActive(true);
            }
            UP_right_B.SetActive(false);
            UP_left_B.SetActive(false);
            Middle_right_B.SetActive(false);
            Middle_left_B.SetActive(false);
            Down_right_B.SetActive(true);
            Down_left_B.SetActive(false);
        }
        else if (Show_button == 6)
        {
            if (Show_arrow == 1)
            {
                Down_left_Arrow1.SetActive(true);
                Down_left_Arrow2.SetActive(false);
                Down_left_Arrow3.SetActive(false);
                Down_left_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 2)
            {
                Down_left_Arrow1.SetActive(false);
                Down_left_Arrow2.SetActive(true);
                Down_left_Arrow3.SetActive(false);
                Down_left_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 3)
            {
                Down_left_Arrow1.SetActive(false);
                Down_left_Arrow2.SetActive(false);
                Down_left_Arrow3.SetActive(true);
                Down_left_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 4)
            {
                Down_left_Arrow1.SetActive(false);
                Down_left_Arrow2.SetActive(false);
                Down_left_Arrow3.SetActive(false);
                Down_left_Arrow4.SetActive(true);
            }
            UP_right_B.SetActive(false);
            UP_left_B.SetActive(false);
            Middle_right_B.SetActive(false);
            Middle_left_B.SetActive(false);
            Down_right_B.SetActive(false);
            Down_left_B.SetActive(true);
        }
    }
    public void Middle_right()
    {
        score++;
        if (Show_button == 2)
        {
            if (Show_arrow == 1)
            {
                UP_left_Arrow1.SetActive(true);
                UP_left_Arrow2.SetActive(false);
                UP_left_Arrow3.SetActive(false);
                UP_left_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 2)
            {
                UP_left_Arrow1.SetActive(false);
                UP_left_Arrow2.SetActive(true);
                UP_left_Arrow3.SetActive(false);
                UP_left_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 3)
            {
                UP_left_Arrow1.SetActive(false);
                UP_left_Arrow2.SetActive(false);
                UP_left_Arrow3.SetActive(true);
                UP_left_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 4)
            {
                UP_left_Arrow1.SetActive(false);
                UP_left_Arrow2.SetActive(false);
                UP_left_Arrow3.SetActive(false);
                UP_left_Arrow4.SetActive(true);
            }
            UP_right_B.SetActive(false);
            UP_left_B.SetActive(true);
            Middle_right_B.SetActive(false);
            Middle_left_B.SetActive(false);
            Down_right_B.SetActive(false);
            Down_left_B.SetActive(false);
        }
        else if (Show_button == 1)
        {
            if (Show_arrow == 1)
            {
                UP_right_Arrow1.SetActive(true);
                UP_right_Arrow2.SetActive(false);
                UP_right_Arrow3.SetActive(false);
                UP_right_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 2)
            {
                UP_right_Arrow1.SetActive(false);
                UP_right_Arrow2.SetActive(true);
                UP_right_Arrow3.SetActive(false);
                UP_right_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 3)
            {
                UP_right_Arrow1.SetActive(false);
                UP_right_Arrow2.SetActive(false);
                UP_right_Arrow3.SetActive(true);
                UP_right_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 4)
            {
                UP_right_Arrow1.SetActive(false);
                UP_right_Arrow2.SetActive(false);
                UP_right_Arrow3.SetActive(false);
                UP_right_Arrow4.SetActive(true);
            }
            UP_right_B.SetActive(true);
            UP_left_B.SetActive(false);
            Middle_right_B.SetActive(false);
            Middle_left_B.SetActive(false);
            Down_right_B.SetActive(false);
            Down_left_B.SetActive(false);
        }
        else if (Show_button == 4)
        {
            if (Show_arrow == 1)
            {
                Middle_left_Arrow1.SetActive(true);
                Middle_left_Arrow2.SetActive(false);
                Middle_left_Arrow3.SetActive(false);
                Middle_left_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 2)
            {
                Middle_left_Arrow1.SetActive(false);
                Middle_left_Arrow2.SetActive(true);
                Middle_left_Arrow3.SetActive(false);
                Middle_left_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 3)
            {
                Middle_left_Arrow1.SetActive(false);
                Middle_left_Arrow2.SetActive(false);
                Middle_left_Arrow3.SetActive(true);
                Middle_left_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 4)
            {
                Middle_left_Arrow1.SetActive(false);
                Middle_left_Arrow2.SetActive(false);
                Middle_left_Arrow3.SetActive(false);
                Middle_left_Arrow4.SetActive(true);
            }
            UP_right_B.SetActive(false);
            UP_left_B.SetActive(false);
            Middle_right_B.SetActive(false);
            Middle_left_B.SetActive(true);
            Down_right_B.SetActive(false);
            Down_left_B.SetActive(false);
        }
        else if (Show_button == 5)
        {
            if (Show_arrow == 1)
            {
                Down_right_Arrow1.SetActive(true);
                Down_right_Arrow2.SetActive(false);
                Down_right_Arrow3.SetActive(false);
                Down_right_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 2)
            {
                Down_right_Arrow1.SetActive(false);
                Down_right_Arrow2.SetActive(true);
                Down_right_Arrow3.SetActive(false);
                Down_right_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 3)
            {
                Down_right_Arrow1.SetActive(false);
                Down_right_Arrow2.SetActive(false);
                Down_right_Arrow3.SetActive(true);
                Down_right_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 4)
            {
                Down_right_Arrow1.SetActive(false);
                Down_right_Arrow2.SetActive(false);
                Down_right_Arrow3.SetActive(false);
                Down_right_Arrow4.SetActive(true);
            }
            UP_right_B.SetActive(false);
            UP_left_B.SetActive(false);
            Middle_right_B.SetActive(false);
            Middle_left_B.SetActive(false);
            Down_right_B.SetActive(true);
            Down_left_B.SetActive(false);
        }
        else if (Show_button == 6)
        {
            if (Show_arrow == 1)
            {
                Down_left_Arrow1.SetActive(true);
                Down_left_Arrow2.SetActive(false);
                Down_left_Arrow3.SetActive(false);
                Down_left_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 2)
            {
                Down_left_Arrow1.SetActive(false);
                Down_left_Arrow2.SetActive(true);
                Down_left_Arrow3.SetActive(false);
                Down_left_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 3)
            {
                Down_left_Arrow1.SetActive(false);
                Down_left_Arrow2.SetActive(false);
                Down_left_Arrow3.SetActive(true);
                Down_left_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 4)
            {
                Down_left_Arrow1.SetActive(false);
                Down_left_Arrow2.SetActive(false);
                Down_left_Arrow3.SetActive(false);
                Down_left_Arrow4.SetActive(true);
            }
            UP_right_B.SetActive(false);
            UP_left_B.SetActive(false);
            Middle_right_B.SetActive(false);
            Middle_left_B.SetActive(false);
            Down_right_B.SetActive(false);
            Down_left_B.SetActive(true);
        }
    }
    public void Middle_left()
    {
        score++;
        if (JustPress > 0)
        {
            JustPress++;
        }

        if (Show_button == 2)
        {
            if (Show_arrow == 1)
            {
                UP_left_Arrow1.SetActive(true);
                UP_left_Arrow2.SetActive(false);
                UP_left_Arrow3.SetActive(false);
                UP_left_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 2)
            {
                UP_left_Arrow1.SetActive(false);
                UP_left_Arrow2.SetActive(true);
                UP_left_Arrow3.SetActive(false);
                UP_left_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 3)
            {
                UP_left_Arrow1.SetActive(false);
                UP_left_Arrow2.SetActive(false);
                UP_left_Arrow3.SetActive(true);
                UP_left_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 4)
            {
                UP_left_Arrow1.SetActive(false);
                UP_left_Arrow2.SetActive(false);
                UP_left_Arrow3.SetActive(false);
                UP_left_Arrow4.SetActive(true);
            }
            UP_right_B.SetActive(false);
            UP_left_B.SetActive(true);
            Middle_right_B.SetActive(false);
            Middle_left_B.SetActive(false);
            Down_right_B.SetActive(false);
            Down_left_B.SetActive(false);
        }
        else if (Show_button == 3)
        {
            if (Show_arrow == 1)
            {
                Middle_right_Arrow1.SetActive(true);
                Middle_right_Arrow2.SetActive(false);
                Middle_right_Arrow3.SetActive(false);
                Middle_right_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 2)
            {
                Middle_right_Arrow1.SetActive(false);
                Middle_right_Arrow2.SetActive(true);
                Middle_right_Arrow3.SetActive(false);
                Middle_right_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 3)
            {
                Middle_right_Arrow1.SetActive(false);
                Middle_right_Arrow2.SetActive(false);
                Middle_right_Arrow3.SetActive(true);
                Middle_right_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 4)
            {
                Middle_right_Arrow1.SetActive(false);
                Middle_right_Arrow2.SetActive(false);
                Middle_right_Arrow3.SetActive(false);
                Middle_right_Arrow4.SetActive(true);
            }
            UP_right_B.SetActive(false);
            UP_left_B.SetActive(false);
            Middle_right_B.SetActive(true);
            Middle_left_B.SetActive(false);
            Down_right_B.SetActive(false);
            Down_left_B.SetActive(false);
        }
        else if (Show_button == 1)
        {
            if (Show_arrow == 1)
            {
                UP_right_Arrow1.SetActive(true);
                UP_right_Arrow2.SetActive(false);
                UP_right_Arrow3.SetActive(false);
                UP_right_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 2)
            {
                UP_right_Arrow1.SetActive(false);
                UP_right_Arrow2.SetActive(true);
                UP_right_Arrow3.SetActive(false);
                UP_right_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 3)
            {
                UP_right_Arrow1.SetActive(false);
                UP_right_Arrow2.SetActive(false);
                UP_right_Arrow3.SetActive(true);
                UP_right_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 4)
            {
                UP_right_Arrow1.SetActive(false);
                UP_right_Arrow2.SetActive(false);
                UP_right_Arrow3.SetActive(false);
                UP_right_Arrow4.SetActive(true);
            }
            UP_right_B.SetActive(true);
            UP_left_B.SetActive(false);
            Middle_right_B.SetActive(false);
            Middle_left_B.SetActive(false);
            Down_right_B.SetActive(false);
            Down_left_B.SetActive(false);
        }
        else if (Show_button == 5)
        {
            if (Show_arrow == 1)
            {
                Down_right_Arrow1.SetActive(true);
                Down_right_Arrow2.SetActive(false);
                Down_right_Arrow3.SetActive(false);
                Down_right_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 2)
            {
                Down_right_Arrow1.SetActive(false);
                Down_right_Arrow2.SetActive(true);
                Down_right_Arrow3.SetActive(false);
                Down_right_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 3)
            {
                Down_right_Arrow1.SetActive(false);
                Down_right_Arrow2.SetActive(false);
                Down_right_Arrow3.SetActive(true);
                Down_right_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 4)
            {
                Down_right_Arrow1.SetActive(false);
                Down_right_Arrow2.SetActive(false);
                Down_right_Arrow3.SetActive(false);
                Down_right_Arrow4.SetActive(true);
            }
            UP_right_B.SetActive(false);
            UP_left_B.SetActive(false);
            Middle_right_B.SetActive(false);
            Middle_left_B.SetActive(false);
            Down_right_B.SetActive(true);
            Down_left_B.SetActive(false);
        }
        else if (Show_button == 6)
        {
            if (Show_arrow == 1)
            {
                Down_left_Arrow1.SetActive(true);
                Down_left_Arrow2.SetActive(false);
                Down_left_Arrow3.SetActive(false);
                Down_left_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 2)
            {
                Down_left_Arrow1.SetActive(false);
                Down_left_Arrow2.SetActive(true);
                Down_left_Arrow3.SetActive(false);
                Down_left_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 3)
            {
                Down_left_Arrow1.SetActive(false);
                Down_left_Arrow2.SetActive(false);
                Down_left_Arrow3.SetActive(true);
                Down_left_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 4)
            {
                Down_left_Arrow1.SetActive(false);
                Down_left_Arrow2.SetActive(false);
                Down_left_Arrow3.SetActive(false);
                Down_left_Arrow4.SetActive(true);
            }
            UP_right_B.SetActive(false);
            UP_left_B.SetActive(false);
            Middle_right_B.SetActive(false);
            Middle_left_B.SetActive(false);
            Down_right_B.SetActive(false);
            Down_left_B.SetActive(true);
        }
    }
    public void Down_right()
    {
        score++;
        if (Show_button == 2)
        {
            if (Show_arrow == 1)
            {
                UP_left_Arrow1.SetActive(true);
                UP_left_Arrow2.SetActive(false);
                UP_left_Arrow3.SetActive(false);
                UP_left_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 2)
            {
                UP_left_Arrow1.SetActive(false);
                UP_left_Arrow2.SetActive(true);
                UP_left_Arrow3.SetActive(false);
                UP_left_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 3)
            {
                UP_left_Arrow1.SetActive(false);
                UP_left_Arrow2.SetActive(false);
                UP_left_Arrow3.SetActive(true);
                UP_left_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 4)
            {
                UP_left_Arrow1.SetActive(false);
                UP_left_Arrow2.SetActive(false);
                UP_left_Arrow3.SetActive(false);
                UP_left_Arrow4.SetActive(true);
            }
            UP_right_B.SetActive(false);
            UP_left_B.SetActive(true);
            Middle_right_B.SetActive(false);
            Middle_left_B.SetActive(false);
            Down_right_B.SetActive(false);
            Down_left_B.SetActive(false);
        }
        else if (Show_button == 3)
        {
            if (Show_arrow == 1)
            {
                Middle_right_Arrow1.SetActive(true);
                Middle_right_Arrow2.SetActive(false);
                Middle_right_Arrow3.SetActive(false);
                Middle_right_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 2)
            {
                Middle_right_Arrow1.SetActive(false);
                Middle_right_Arrow2.SetActive(true);
                Middle_right_Arrow3.SetActive(false);
                Middle_right_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 3)
            {
                Middle_right_Arrow1.SetActive(false);
                Middle_right_Arrow2.SetActive(false);
                Middle_right_Arrow3.SetActive(true);
                Middle_right_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 4)
            {
                Middle_right_Arrow1.SetActive(false);
                Middle_right_Arrow2.SetActive(false);
                Middle_right_Arrow3.SetActive(false);
                Middle_right_Arrow4.SetActive(true);
            }
            UP_right_B.SetActive(false);
            UP_left_B.SetActive(false);
            Middle_right_B.SetActive(true);
            Middle_left_B.SetActive(false);
            Down_right_B.SetActive(false);
            Down_left_B.SetActive(false);
        }
        else if (Show_button == 4)
        {
            if (Show_arrow == 1)
            {
                Middle_left_Arrow1.SetActive(true);
                Middle_left_Arrow2.SetActive(false);
                Middle_left_Arrow3.SetActive(false);
                Middle_left_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 2)
            {
                Middle_left_Arrow1.SetActive(false);
                Middle_left_Arrow2.SetActive(true);
                Middle_left_Arrow3.SetActive(false);
                Middle_left_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 3)
            {
                Middle_left_Arrow1.SetActive(false);
                Middle_left_Arrow2.SetActive(false);
                Middle_left_Arrow3.SetActive(true);
                Middle_left_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 4)
            {
                Middle_left_Arrow1.SetActive(false);
                Middle_left_Arrow2.SetActive(false);
                Middle_left_Arrow3.SetActive(false);
                Middle_left_Arrow4.SetActive(true);
            }
            UP_right_B.SetActive(false);
            UP_left_B.SetActive(false);
            Middle_right_B.SetActive(false);
            Middle_left_B.SetActive(true);
            Down_right_B.SetActive(false);
            Down_left_B.SetActive(false);
        }
        else if (Show_button == 1)
        {
            if (Show_arrow == 1)
            {
                UP_right_Arrow1.SetActive(true);
                UP_right_Arrow2.SetActive(false);
                UP_right_Arrow3.SetActive(false);
                UP_right_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 2)
            {
                UP_right_Arrow1.SetActive(false);
                UP_right_Arrow2.SetActive(true);
                UP_right_Arrow3.SetActive(false);
                UP_right_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 3)
            {
                UP_right_Arrow1.SetActive(false);
                UP_right_Arrow2.SetActive(false);
                UP_right_Arrow3.SetActive(true);
                UP_right_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 4)
            {
                UP_right_Arrow1.SetActive(false);
                UP_right_Arrow2.SetActive(false);
                UP_right_Arrow3.SetActive(false);
                UP_right_Arrow4.SetActive(true);
            }
            UP_right_B.SetActive(true);
            UP_left_B.SetActive(false);
            Middle_right_B.SetActive(false);
            Middle_left_B.SetActive(false);
            Down_right_B.SetActive(false);
            Down_left_B.SetActive(false);
        }
        else if (Show_button == 6)
        {
            if (Show_arrow == 1)
            {
                Down_left_Arrow1.SetActive(true);
                Down_left_Arrow2.SetActive(false);
                Down_left_Arrow3.SetActive(false);
                Down_left_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 2)
            {
                Down_left_Arrow1.SetActive(false);
                Down_left_Arrow2.SetActive(true);
                Down_left_Arrow3.SetActive(false);
                Down_left_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 3)
            {
                Down_left_Arrow1.SetActive(false);
                Down_left_Arrow2.SetActive(false);
                Down_left_Arrow3.SetActive(true);
                Down_left_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 4)
            {
                Down_left_Arrow1.SetActive(false);
                Down_left_Arrow2.SetActive(false);
                Down_left_Arrow3.SetActive(false);
                Down_left_Arrow4.SetActive(true);
            }
            UP_right_B.SetActive(false);
            UP_left_B.SetActive(false);
            Middle_right_B.SetActive(false);
            Middle_left_B.SetActive(false);
            Down_right_B.SetActive(false);
            Down_left_B.SetActive(true);
        }
    }
    public void Down_left()
    {
        score++;
        if (Show_button == 2)
        {
            if (Show_arrow == 1)
            {
                UP_left_Arrow1.SetActive(true);
                UP_left_Arrow2.SetActive(false);
                UP_left_Arrow3.SetActive(false);
                UP_left_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 2)
            {
                UP_left_Arrow1.SetActive(false);
                UP_left_Arrow2.SetActive(true);
                UP_left_Arrow3.SetActive(false);
                UP_left_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 3)
            {
                UP_left_Arrow1.SetActive(false);
                UP_left_Arrow2.SetActive(false);
                UP_left_Arrow3.SetActive(true);
                UP_left_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 4)
            {
                UP_left_Arrow1.SetActive(false);
                UP_left_Arrow2.SetActive(false);
                UP_left_Arrow3.SetActive(false);
                UP_left_Arrow4.SetActive(true);
            }
            UP_right_B.SetActive(false);
            UP_left_B.SetActive(true);
            Middle_right_B.SetActive(false);
            Middle_left_B.SetActive(false);
            Down_right_B.SetActive(false);
            Down_left_B.SetActive(false);
        }
        else if (Show_button == 3)
        {
            if (Show_arrow == 1)
            {
                Middle_right_Arrow1.SetActive(true);
                Middle_right_Arrow2.SetActive(false);
                Middle_right_Arrow3.SetActive(false);
                Middle_right_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 2)
            {
                Middle_right_Arrow1.SetActive(false);
                Middle_right_Arrow2.SetActive(true);
                Middle_right_Arrow3.SetActive(false);
                Middle_right_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 3)
            {
                Middle_right_Arrow1.SetActive(false);
                Middle_right_Arrow2.SetActive(false);
                Middle_right_Arrow3.SetActive(true);
                Middle_right_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 4)
            {
                Middle_right_Arrow1.SetActive(false);
                Middle_right_Arrow2.SetActive(false);
                Middle_right_Arrow3.SetActive(false);
                Middle_right_Arrow4.SetActive(true);
            }
            UP_right_B.SetActive(false);
            UP_left_B.SetActive(false);
            Middle_right_B.SetActive(true);
            Middle_left_B.SetActive(false);
            Down_right_B.SetActive(false);
            Down_left_B.SetActive(false);
        }
        else if (Show_button == 4)
        {
            if (Show_arrow == 1)
            {
                Middle_left_Arrow1.SetActive(true);
                Middle_left_Arrow2.SetActive(false);
                Middle_left_Arrow3.SetActive(false);
                Middle_left_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 2)
            {
                Middle_left_Arrow1.SetActive(false);
                Middle_left_Arrow2.SetActive(true);
                Middle_left_Arrow3.SetActive(false);
                Middle_left_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 3)
            {
                Middle_left_Arrow1.SetActive(false);
                Middle_left_Arrow2.SetActive(false);
                Middle_left_Arrow3.SetActive(true);
                Middle_left_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 4)
            {
                Middle_left_Arrow1.SetActive(false);
                Middle_left_Arrow2.SetActive(false);
                Middle_left_Arrow3.SetActive(false);
                Middle_left_Arrow4.SetActive(true);
            }
            UP_right_B.SetActive(false);
            UP_left_B.SetActive(false);
            Middle_right_B.SetActive(false);
            Middle_left_B.SetActive(true);
            Down_right_B.SetActive(false);
            Down_left_B.SetActive(false);
        }
        else if (Show_button == 5)
        {
            if (Show_arrow == 1)
            {
                Down_right_Arrow1.SetActive(true);
                Down_right_Arrow2.SetActive(false);
                Down_right_Arrow3.SetActive(false);
                Down_right_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 2)
            {
                Down_right_Arrow1.SetActive(false);
                Down_right_Arrow2.SetActive(true);
                Down_right_Arrow3.SetActive(false);
                Down_right_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 3)
            {
                Down_right_Arrow1.SetActive(false);
                Down_right_Arrow2.SetActive(false);
                Down_right_Arrow3.SetActive(true);
                Down_right_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 4)
            {
                Down_right_Arrow1.SetActive(false);
                Down_right_Arrow2.SetActive(false);
                Down_right_Arrow3.SetActive(false);
                Down_right_Arrow4.SetActive(true);
            }
            UP_right_B.SetActive(false);
            UP_left_B.SetActive(false);
            Middle_right_B.SetActive(false);
            Middle_left_B.SetActive(false);
            Down_right_B.SetActive(true);
            Down_left_B.SetActive(false);
        }
        else if (Show_button == 1)
        {
            if (Show_arrow == 1)
            {
                UP_right_Arrow1.SetActive(true);
                UP_right_Arrow2.SetActive(false);
                UP_right_Arrow3.SetActive(false);
                UP_right_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 2)
            {
                UP_right_Arrow1.SetActive(false);
                UP_right_Arrow2.SetActive(true);
                UP_right_Arrow3.SetActive(false);
                UP_right_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 3)
            {
                UP_right_Arrow1.SetActive(false);
                UP_right_Arrow2.SetActive(false);
                UP_right_Arrow3.SetActive(true);
                UP_right_Arrow4.SetActive(false);
            }
            else if (Show_arrow == 4)
            {
                UP_right_Arrow1.SetActive(false);
                UP_right_Arrow2.SetActive(false);
                UP_right_Arrow3.SetActive(false);
                UP_right_Arrow4.SetActive(true);
            }
            UP_right_B.SetActive(true);
            UP_left_B.SetActive(false);
            Middle_right_B.SetActive(false);
            Middle_left_B.SetActive(false);
            Down_right_B.SetActive(false);
            Down_left_B.SetActive(false);
        }
    }

}