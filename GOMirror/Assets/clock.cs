using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class clock : MonoBehaviour { 

    public TextMesh Clock;
    public TextMesh Date;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DateTime time = DateTime.Now;
        Clock.text = time.Hour + ":" + String.Format("{0:00}", time.Minute) + ":" + String.Format("{0:00}", time.Second);
        Date.text = time.ToLongDateString();
    }
}
