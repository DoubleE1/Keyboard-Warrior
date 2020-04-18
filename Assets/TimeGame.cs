using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeGame : MonoBehaviour
{
    int roundStartDelayTime = 3;
    float roundStartTime;
    int waitTime;
    bool roundStarted;

    // Start is called before the first frame update
    void Start()
    {
        print("Welcome to Timer Game! Try your best to guest the allocated time and press Space.");
        Invoke("SetRandomTime", roundStartDelayTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && roundStarted){
            InputReceived();
        }
    }

    void InputReceived() {
        roundStarted = false;
        float playerWaitTime = Time.time - roundStartTime;
        //duration between required wait time and  the player's wait time
        //float gapTime = Mathf.Abs(waitTime - playerWaitTime);
        float gapTime = waitTime - playerWaitTime;

        if(gapTime <= 0) {
            print("You have waiting too long.");
        } else {
            gapTime = Mathf.Abs(gapTime);
            print("You have waited for: " + playerWaitTime + " second. That's " + gapTime + " second off." + GenerateMessage(gapTime));
        }
        
        Invoke("SetRandomTime", roundStartDelayTime);
    }

    string GenerateMessage(float gapTime) {
        string message = "";
        if(gapTime < .25f){
            message = "Excellent!";
        } else if (gapTime < .75f){
            message = "Very Good!";
        } else if (gapTime < 1.50f){
            message = "Nice Try!";
        } else if (gapTime < 2.50f){
            message = "Too Soon!";
        } else {
            message = "Aweful";
        }

        return message;
    }

    void SetRandomTime()
    {
        waitTime = Random.Range(5,10);
        roundStartTime = Time.time;
        roundStarted = true;
        print("Wait for: " + waitTime);
    }
}
