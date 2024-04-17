//BU KOMUT DOSYAMIZIN(PlayerControllerX) HANGI PAKETLERI KULLANDIGINI SOYLER.
//USING(KULLANMAK),
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//UNITY MonoBehavior SINIFI,HER BIR UNITY BILESENININ TURETILDIGI TEMEL BIR SINIFTIR.
//BIR BILESEN MonoBehavior SINIFINDAN TURETILMEK ZORUNDADIR.
//PUBLIC(HERKESE ACIK) CLASS(SINIF) PlayerControllerX(KOMUT DOSYAMIZIN ADI) : MonoBehaviour(UNITY SINIFI)
public class PlayerControllerX : MonoBehaviour
{
    //HIZ DEGISKENI
    //PUBLIC(HERKESE ACIK) FLOAT(ONDALIKLI SAYI) SPEED(HIZ DEGISKENIMIZIN ADI) = 5.0f(FLOAT(ONDALIKLI SAYI))
    //-------------------------------------------------------------------------------
    //PROJEMIZIN EN SON ASAMASINA GELDIK.PUBLIC(HERKESE ACIK) OLAN DEGISKENLERI PRIVATE(OZEL,GIZLI) YAPACAGIZ.
    private float speed = 5.0f;
    //DONUS HIZI DEGISKENI
    //PUBLIC(HERKESE ACIK) FLOAT(ONDALIKLI SAYI) ROTATIONSPEED(DONUS HIZI(DEGISKENIMIZIN ADI)
    private float rotationSpeed;
    //DIKEY GIRIS DEGISKENI
    //PUBLIC(HERKESE ACIK) FLOAT(ONDALIKLI SAYI) VERTICALINPUT((DIKEYGIRIS)DEGISKENIMIZIN ADI);
    private float verticalInput;

    void Update()
    {
        //VerticalInput(DIKEY GIRIS DEGISKENIMIZ) = Input(GIRIS YONETICISI).GetAxis[EKSENI AL]("Vertical(DIKEY EKSEN)");
        verticalInput = Input.GetAxis("Vertical");

        //UCAGIMIZI ILERI DOGRU HAREKET ETTIRECEK KOD SATIRI.
        //transform(ARACIN TRANSFORMU).Translate(TASIMAK,YER DEGISTIRMEK)(VECTOR3(3D(x,y,z)).FORWARD(ILERI) * Time.deltaTime(ZAMAN FARKI)* SPEED(HIZ DEGISKENI));
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        //------------------------------------------------------------------------
        //UCAGIN OYUNUMDA SAGA VE SOLA GITMESINE GEREK YOK.
        //transform.Translate(Vector3.right * Time.deltaTime * rotationSpeed);
        //-----------------------------------------------------------------
        //ANAHTAR KELIMELER HAYATIMIZI KOLAYLASTIRIR: ORN:FORWARD(ILERI),RIGHT(SAG),UP(YUKARI)
        //ASAGI YON TUSUNA BASTIGIMDA UCAK YUKARI,YUKARI YON TUSUNA BASTIGIMDA UCAK ASAGI GIDIYORDU.ISTEDIGIMIN TAM TERSI HAREKET VARDI.
        ////GERI BASTIGINDA "OK TUSUNA" VEYA "S"(S TUSU) ILERI GIRIS NEGATIFE(-1) DONER.
        //ILERI BASTIGINDA "OK TUSU" VEYA "W"(W TUSU) ILERI GIRIS POZITIFE(+1) DONER.
        //COZUM:EGER BEN -1 ILE CARPARSAM.ASAGI YON TUSUNA BASTIGIMDA UCAK ASAGI,YUKARI YON TUSUNA BASTIGIMDA UCAK YUKARI GIDER..ISTEDIGIM DE TAM BU.
        //ORN:ASAGI YON TUSUNA BASTIGIMDA VERTICALINPUT -1 DEGERINI ALIR.EGER BEN BIR DAHA -1 ILE CARPARSAM -*-= + YAPACAGI ICIN.BU SORUNU COZMUS OLURUM.
        //----------------------------------------------------------------------------------------------------------
        //transform(ARACIN TRANSFORMU).Rotate(DONMEK)(VECTOR3(3D(x,y,z)).RIGHT(SAG) * Time.deltaTime(ZAMAN FARKI)* ROTATIONSPEED(DONUSHIZI DEGISKENI) * verticalInput(DIKEY GIRIS DEGISKENI) * -1(EKSI*EKSI=ARTI MANTIGI));
        //NIYE RIGHT KULLANDIK?UP KULLANMADIK?SONUCTA UCAGI YUKARI VE ASAGI HAREKET ETTIRECEGIM.
        transform.Rotate(Vector3.right * Time.deltaTime * rotationSpeed * verticalInput * -1);
    }
}
