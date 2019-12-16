/* ***************************************************************
 * 프로그램 명 : InfraredSourceManager.cs
 * 작성자 : 신은지, 최세화 (류서현, 이송이, 최은정, 홍예지) + 오픈소스 - kinect for unity
 * 최조 작성일 : 2019년 11월 14일
 * 최종 작성일 : 2019년 12월 15일
 * 프로그램 설명 : 적외선을 이용, 밀도 등을 체크하여 사용자 몸을 인식할 때 부분부분이 정밀히 상호작용하면서 움직이게 도와준다. 
 * *************************************************************** */
using UnityEngine;
using System.Collections;
using Windows.Kinect;

public class InfraredSourceManager : MonoBehaviour 
{
    private KinectSensor _Sensor;
    private InfraredFrameReader _Reader;
    private ushort[] _Data;
    private byte[] _RawData;
    
    // I'm not sure this makes sense for the Kinect APIs
    // Instead, this logic should be in the VIEW
    private Texture2D _Texture;

    public Texture2D GetInfraredTexture()
    {
        return _Texture;
    }
    
    void Start()
    {
        _Sensor = KinectSensor.GetDefault();
        if (_Sensor != null) 
        {
            _Reader = _Sensor.InfraredFrameSource.OpenReader();
            var frameDesc = _Sensor.InfraredFrameSource.FrameDescription;
            _Data = new ushort[frameDesc.LengthInPixels];
            _RawData = new byte[frameDesc.LengthInPixels * 4];
            _Texture = new Texture2D(frameDesc.Width, frameDesc.Height, TextureFormat.BGRA32, false);
            
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
                frame.CopyFrameDataToArray(_Data);
                
                int index = 0;
                foreach(var ir in _Data)
                {
                    byte intensity = (byte)(ir >> 8);
                    _RawData[index++] = intensity;
                    _RawData[index++] = intensity;
                    _RawData[index++] = intensity;
                    _RawData[index++] = 255; // Alpha
                }
                
                _Texture.LoadRawTextureData(_RawData);
                _Texture.Apply();
                
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
