using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weekdayscript : MonoBehaviour
{

    public string[] task;
    // Start is called before the first frame update
    void Start()
    {
   
        task = new string[7];
        task[0] = "Monday - Get out of bed";
        task[1] = "Tuesday - Play video games";
        task[2] = "Wednesday - Do homework";
        task[3] = "Thursday - Work";
        task[4] = "Friday - Work even more";
        task[5] = "Saturday - Relax";
        task[6] = "Sunday - Get ready to do it all again";
    }

    // Update is called once per frame
    void Update()
    {
        sayTask(task.Length);
    }

    public void sayTask(int arraylength){
        
        for(int i = 0; i < arraylength; i++){
            Debug.Log(task[i]);
        
        }


    }
}
