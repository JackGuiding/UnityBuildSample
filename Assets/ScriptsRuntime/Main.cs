using System.Runtime.InteropServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BuildSample;

// using UnityEditor;

public class Main : MonoBehaviour
{

    [DllImport("mathlib.dll", EntryPoint = "myadd")]
    public static extern int CSAdd(int a, int b);

    // Start is called before the first frame update
    void Start()
    {

        int res = CSAdd(1, 5);

        MyGame myGame = new MyGame();
        
        Debug.Log(res);
        Debug.Log("Hello");
        // Debug.Log(EditorApplication.isPlaying);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
