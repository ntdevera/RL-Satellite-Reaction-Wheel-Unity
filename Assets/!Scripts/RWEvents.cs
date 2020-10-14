using UnityEngine.UI;
using UnityEngine;
using System.IO;
using System;

public class RWEvents : MonoBehaviour
{
    [Header("Toggle RW")]
    [HideInInspector] public bool on;
    [SerializeField] private GameObject outerSat = null;
    [SerializeField] private GameObject interiorSat = null;
    [SerializeField] private GameObject RW = null;
    [SerializeField] private GameObject nadir = null;
    [SerializeField] private Button RWButton =null;

    [Header("GenCSV")]
    [SerializeField] private GameObject CSVui = null;
    [SerializeField] private TMPro.TextMeshProUGUI fileTxt = null;
    [SerializeField] private Button CSVButton = null;

    private void Awake( ) 
    {
        if( RWButton != null )
        {
            RWButton.onClick.AddListener(RWEvent);
            //CSVButton.onClick.AddListener(CSVEvent);
        }
    }

    private void RWEvent( ) 
    {
        if( on )
        {
            outerSat.SetActive(false);
            interiorSat.SetActive(false);
            nadir.SetActive(false);
            RW.SetActive(true);
            on = false;
        }
        else
        {
            outerSat.SetActive(true);
            interiorSat.SetActive(true);
            nadir.SetActive(true);
            RW.SetActive(false);
            on = true;
        }

    }

    //private void CSVEvent( ) 
    //{
    //    string foldername = @"D:\GenCSV";
    //    Directory.CreateDirectory(foldername);
    //    string fileName = DateTime.Now.ToString("dd MMMM yyyy HH-mm-ss") + ".csv";
    //    string path = Path.Combine(foldername, fileName);
    //    fileTxt.text = path;
    //    if( !File.Exists(path) )
    //    {
    //        using( StreamWriter sw = File.CreateText(path) )
    //        {
    //            sw.WriteLine(string.Join(",", "epoch (ACU Date)",
    //                "GPS_r_eci[0]", "GPS_r_eci[1]", "GPS_r_eci[2]",
    //                "q_e_0", "q_e_1", "q_e_2", "q_e_3",
    //                "q_t_0", "q_t_1", "q_t_2", "q_t_3",
    //                "rw_rpm_1", "rw_rpm_2", "rw_rpm_3", "rw_rpm_4",
    //                "omega_e[0]", "omega_e[1]", "omega_e[2]"));

    //            for( var i = 0; i < TelemetryManager.Instance.CSVLines; i++ )
    //            {
    //                sw.WriteLine(string.Join(",", Convert.ToString(TelemetryManager.Instance.telDateTime[i]),
    //                    Convert.ToString(TelemetryManager.Instance.telPosition[i][0]),
    //                    Convert.ToString(TelemetryManager.Instance.telPosition[i][2]),
    //                    Convert.ToString(TelemetryManager.Instance.telPosition[i][1]),
    //                    Convert.ToString(-TelemetryManager.Instance.telRotation[i][0]),
    //                    Convert.ToString(-TelemetryManager.Instance.telRotation[i][2]),
    //                    Convert.ToString(-TelemetryManager.Instance.telRotation[i][1]),
    //                    Convert.ToString(TelemetryManager.Instance.telRotation[i][3]),
    //                    Convert.ToString(QuickManager.Instance.Q_u2t[0]),
    //                    Convert.ToString(QuickManager.Instance.Q_u2t[1]),
    //                    Convert.ToString(QuickManager.Instance.Q_u2t[2]),
    //                    Convert.ToString(QuickManager.Instance.Q_u2t[3]),
    //                    Convert.ToString(TelemetryManager.Instance.telRW[i][0]),
    //                    Convert.ToString(TelemetryManager.Instance.telRW[i][1]),
    //                    Convert.ToString(TelemetryManager.Instance.telRW[i][2]),
    //                    Convert.ToString(TelemetryManager.Instance.telRW[i][3]),
    //                    Convert.ToString(TelemetryManager.Instance.telRotSpeed[i][0]),
    //                    Convert.ToString(TelemetryManager.Instance.telRotSpeed[i][2]),
    //                    Convert.ToString(TelemetryManager.Instance.telRotSpeed[i][1])));
    //            }
    //        }
    //        CSVui.SetActive(true);
    //    }
    //}
}
