using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 처음에 한 번 메시지 표시
        Debug.Log("[Start]");
    }

    // Update is called once per frame
    void Update()
    {
        // Space 키가 눌리고 있는 동안 메시지 표시
        if(Input.GetKey(KeyCode.Space))
        {
            Debug.Log("[Update] Space key pressed");
        }
    }
}
