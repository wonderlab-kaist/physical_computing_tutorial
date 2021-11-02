using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class arduino_communication : MonoBehaviour
{
    public string portname;
    public int baudrate;


    private SerialPort m_SerialPort;

    void Start()
    {
        m_SerialPort = new SerialPort(portname, baudrate, Parity.None, 8, StopBits.One);
        m_SerialPort.Open();
    }

    void Update()
    {
        

        string income = m_SerialPort.ReadLine();
        if (income != null) Debug.Log(income);
    }

    void OnApplicationQuit()
    {
        m_SerialPort.Close();
    }

    void SerialPortWrite(string message)
    {
        m_SerialPort.Write(message);
    }
}
