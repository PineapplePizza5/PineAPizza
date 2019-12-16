/* ***************************************************************
 * 프로그램 명 : BodySourceManager.cs
 * 작성자 : 신은지 (류서현, 이송이, 최세화, 최은정, 홍예지) + 오픈소스 - kinect for unity
 * 최조 작성일 : 2019년 11월 14일
 * 최종 작성일 : 2019년 12월 15일
 * 프로그램 설명 : 전역변수로 게임 성공 여부를 체크하며, 키넥트 센서를 인식하여 사용자 몸을 받아들인다
 * *************************************************************** */
using UnityEngine;
using System.Collections;
using Windows.Kinect;

public class BodySourceManager : MonoBehaviour 
{
    private KinectSensor _Sensor;
    private BodyFrameReader _Reader;
    private Body[] _Data = null;
    public static int hit_count = 0; // 게임에서 몇개 성공했는지 체크
    public static int check = 1; // 게임 성공햇는지 체크 

    public Body[] GetData()
    {
        return _Data;
    }
    

    void Start () 
    {
        _Sensor = KinectSensor.GetDefault();

        if (_Sensor != null)
        {
            _Reader = _Sensor.BodyFrameSource.OpenReader();
            
            if (!_Sensor.IsOpen)
            {
                _Sensor.Open();
            }
        }   
    }
    
    void Update () 
    {
        if (_Reader != null)
        {
            var frame = _Reader.AcquireLatestFrame();
            if (frame != null)
            {
                if (_Data == null)
                {
                    _Data = new Body[_Sensor.BodyFrameSource.BodyCount];
                }
                
                frame.GetAndRefreshBodyData(_Data);
                
                frame.Dispose();
                frame = null;
            }
        }

    }
    
    void OnApplicationQuit()
    {
        if (_Reader != null)
        {
            _Reader.Dispose();
            _Reader = null;
        }
        
        if (_Sensor != null)
        {
            if (_Sensor.IsOpen)
            {
                _Sensor.Close();
            }
            
            _Sensor = null;
        }
    }
}
