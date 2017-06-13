using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class ArduinoController : MonoBehaviour {
    public string com;
	// Use this for initialization
	void Start () {
        SerialPort port = new SerialPort(com, 9600);
        port.Open();
        while (true)
        {
            string s = port.ReadLine();
            if (s.Equals("exit"))
            {
                break;
            }
            port.Write(s + '\n');
        }
        port.Close();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
