using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GUIStyle timeStyle;
    public GUIStyle msgStyle;
    private float clearTime;
    const int BLOCKCOUNT = 100;
    private int count = 0;
    bool isGoal = false;

    // Update is called once per frame
    void Update()
    {
        if(count == BLOCKCOUNT)
        {
            isGoal = true;
        }
        if(!isGoal)
        {
            clearTime += Time.deltaTime;
        }
    }
    public int GetCount()
    {
        return count;
    }
    public void AddCount()
    {
        this.count++;
    }
    void OnGUI()
    {
        GUI.Label(new Rect(Screen.width - 250, Screen.height - 40, 100, 100), "Time:" + clearTime.ToString("0.000"), timeStyle);
        if(isGoal)
        {
            GUI.Label(new Rect(10, Screen.height - 40, 100, 100), "Finish!!", msgStyle);
        }
    }
}
