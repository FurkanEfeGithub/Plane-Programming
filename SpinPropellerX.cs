using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    //PERVANE HIZI DEGISKENI
    //PUBLIC(HERKESE ACIK) FLOAT(ONDALIKLI SAYI) propollorSpeed(PERVANE HIZI (DEGISKENIMIZIN ADI)) = 1000f(FLOAT(ONDALIKLI SAYI))
    private float propollorSpeed = 1000.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    //VOID(BOSLUK):BURASININ FONKSIYON IFADESI OLDUGUNU SOYLER.
    //YANI UPDATE() BIR FONKSIYON.
    //HER KAREDE BIR(saniyede 60 kez) CAGRILAN BU FONKSIYON,OYUN MEKANIGI GUNCELLEMELERI ICIN KULLANILIR.
    //ORN:KARAKTERIN HARAKETI VEYA DUSMANLARIN POZISYONU GIBI.SUREKLI KONTROL EDER.
    //UCAGIMIZ 1 SANIYE ICINDE 60 METRE(60 ADET) HAREKET EDECEK.
    void Update()
    {   //transform(PERVANENIN TRANSFORMU).Rotate(DONMEK)(X,Y,Z);
        //transform.Rotate(0,0,1);
        //----------------------------------------------------------------
//transform(PERVANENIN TRANSFORMU).Rotate(DONMEK)(VECTOR3(3D(x,y,z)).FORWARD(ILERI) * Time.deltaTime(ZAMAN FARKI)*propollorSpeed(PERVANE HIZI DEGISKENI));
        transform.Rotate(Vector3.forward * Time.deltaTime * propollorSpeed);  
    }
}
