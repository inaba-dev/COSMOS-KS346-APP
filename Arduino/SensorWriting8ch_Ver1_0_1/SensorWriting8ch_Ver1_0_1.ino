#include <SoftwareSerial.h>

//　RX(受信)を8ピン,TX(送信)を9ピンに設定
SoftwareSerial SensorSerial(8, 9); // RX, TX

byte g_recvHostDatas[60];
int  g_recvHostLen = 0;

byte g_recvSensorDatas[60];
int  g_recvSensorLen = 0;

void setup() 
{
  Serial.begin(38400);  
  SensorSerial.begin(38400);
  
  //　8ピン　プルアップ設定
  //pinMode(8,INPUT_PULLUP);

  //　セレクト信号
  pinMode(4,OUTPUT);
  pinMode(5,OUTPUT);
  pinMode(6,OUTPUT);

  //pinMode(13,OUTPUT);
  //digitalWrite(13, HIGH);   
}

void loop() 
{
  byte data;

  delay(10);
 
  ////////////////////
  // PCからコマンド受信
  ////////////////////

  g_recvHostLen = 0;
  while(Serial.available() > 0)
  {
    data = Serial.read(); 

    g_recvHostDatas[g_recvHostLen] = data;            
    g_recvHostLen++; 

    delay(1);

    // 50バイト以上の場合は中断 
    if(g_recvHostLen >= 50) break;
  }

  ////////////////////
  // データ解析＆処理
  ////////////////////

  if(g_recvHostLen > 0)
  {
    //--------------------
    // セレクタ処理
    //--------------------

    if(parsePacketSelect())
    {
      /// セレクタの処理
      processSelect();

      // セレクタの応答送信
      sendPacketSelect();
    }

    //--------------------
    // センサ処理
    //--------------------

    else if(parsePacketSensor())
    {
      /// センサの処理
      processSensor();

      // センサの応答送信
      sendPacketSensor();
    }
  }
}

//**********************************************************************************
//   Arduino⇔センサの処理
//**********************************************************************************

/// センサのヘッダー解析

bool parsePacketSensor()
{
  // ヘッターの確認
  if (g_recvHostDatas[0] != 0x40) return false;
//  if (g_recvHostDatas[1] != 0x40) return false;

  return true;
}

/// センサとの送受信

void processSensor()
{
  byte _data;

  SensorSerial.write(g_recvHostDatas, g_recvHostLen);
  SensorSerial.flush();

  delay(200);

  g_recvSensorLen = 0;
  while(SensorSerial.available() > 0)
  {
    _data = SensorSerial.read(); 
    g_recvSensorDatas[g_recvSensorLen] = _data;            
    g_recvSensorLen++; 

    delay(1);

    // 50バイト以上の場合は中断 
    if(g_recvSensorLen >= 50) break;
  }  
}

/// センサの応答送信

void sendPacketSensor()
{
    // データサイズ確認
  //if (g_recvSensorLen == 0) return false;

    // ヘッターの確認
  //if (g_recvSensorDatas[0] != 0xC0) return;

  Serial.write(g_recvSensorDatas, g_recvSensorLen);
  Serial.flush();
}

//**********************************************************************************
//   PC⇔セレクタの処理
//**********************************************************************************

/// セレクタの受信解析

bool parsePacketSelect()
{
  // データサイズ確認
  if (g_recvHostLen != 8) return false;

  // ヘッターとフッターの確認
  if (g_recvHostDatas[0] != 0x01) return false;
  if (g_recvHostDatas[7] != 0x04) return false;

  //　チェックサムの確認
  int sum=0;           
  for(int i =0 ; i<=4 ; i++) sum+=(int)g_recvHostDatas[i];
  int checksum =sum % 256;
   
  //　4ビットを左にシフト(16倍)してから、論理和している。(例：00001010→10100000)
  int receivedchecksum = (asc2int(g_recvHostDatas[5]) << 4|asc2int(g_recvHostDatas[6]));

  if(checksum != receivedchecksum) return false;

  return true;
}

/// セレクタの応答送信

void sendPacketSelect()
{
  Serial.write(g_recvHostDatas, g_recvHostLen);
  Serial.flush();
}

/// セレクタのコマンド処理

bool processSelect()
{
  switch(g_recvHostDatas[4])
  {
    //1CH
    case 0x30:
    digitalWrite(4 , LOW);
    digitalWrite(5 , LOW);
    digitalWrite(6 , LOW);    
    return true;
    
    //2CH
    case 0x31:
    digitalWrite(4 , HIGH); 
    digitalWrite(5 , LOW);
    digitalWrite(6 , LOW);    
    return true;

    //3CH
    case 0x32:
    digitalWrite(4 , LOW); 
    digitalWrite(5 , HIGH);
    digitalWrite(6 , LOW);
    return true;

    //4CH
    case 0x33:
    digitalWrite(4 , HIGH); 
    digitalWrite(5 , HIGH);
    digitalWrite(6 , LOW);   
    return true;

    //5CH
    case 0x34:
    digitalWrite(4 , LOW);
    digitalWrite(5 , LOW);
    digitalWrite(6 , HIGH);    
    return true;

    //6CH
    case 0x35:
    digitalWrite(4 , HIGH);
    digitalWrite(5 , LOW);
    digitalWrite(6 , HIGH);    
    return true;

    //7CH
    case 0x36:
    digitalWrite(4, LOW);
    digitalWrite(5, HIGH);
    digitalWrite(6, HIGH);    
    return true;

    //8CH
    case 0x37:
    digitalWrite(4 , HIGH);
    digitalWrite(5 , HIGH);
    digitalWrite(6 , HIGH);    
    return true;
    
    default:
    return false;

  }    
  return false;            
}

/******************************************
   共有関数
 *****************************************/
int int2asc(int src)
{  
  if (src < 10) return (src + 0x30);  
  else if (src < 16) return ((src - 10) + 0x41);
  else return 0;
}

int asc2int(int src)
{
  if (src > 0x40) return (src - 0x41 + 10);  
  else if (src >= 0x30) return (src - 0x30);
  else return 0;
}
