using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class arduino_communication : MonoBehaviour
{
    public string portname;
    public int baudrate;

    Vector3 angles;


    private SerialPort m_SerialPort;

    void Start()
    {
        //Debug.Log("start!!:");
        
        m_SerialPort = new SerialPort(portname, baudrate, Parity.None, 8, StopBits.One);
        m_SerialPort.ReadTimeout = 50;
        m_SerialPort.WriteTimeout = 500;
        m_SerialPort.Open();
    }

    void Update()
    {
        

        string income = m_SerialPort.ReadLine();
        //if (income != null) Debug.Log(income);


        angles = new Vector3(float.Parse(income.Split(':')[0]), float.Parse(income.Split(':')[1]), float.Parse(income.Split(':')[2]));
    }

    void OnApplicationQuit()
    {
        m_SerialPort.Close();
    }

    void SerialPortWrite(string message)
    {
        m_SerialPort.Write(message);
    }

    public Vector3 getAngles()
    {
        return angles;
    }
}
