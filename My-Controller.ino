// Initialization LCD with I2C________________________
#include <Wire.h>
#include <LiquidCrystal_I2C.h>
  LiquidCrystal_I2C lcd = LiquidCrystal_I2C (0x27,16,2);

// Initialization Servo control_______________________
#include <Servo.h>
  Servo servo_1, servo_2, servo_3, servo_4;
  const int servoPin_1 = 10,
            servoPin_2 = 9,
            servoPin_3 = 11,
            servoPin_4 = 12;

  const int rightAngle[3] = {98,69,90};
  float servo_LastDegree[4];          // last position of servo (in. degree)

// Initialization Stepper control_____________________
const int stepperPin_Dir  = 4,
          stepperPin_Step = 3,
          stepperPin_En   = 2;

const long  MiddleBase  = 502,        // potentiometer value on stepper
            Revolutions = 200*32,     // 17.7 steps per degree
            StepTon     = 500,        // delayMicrosecond On Time
            StepToff    = 50;         // delayMicrosecond Off Time

float stepper_LastDegree;

#define Stepper_turn_CCW  digitalWrite(stepperPin_Dir, HIGH)
#define Stepper_turn_CW   digitalWrite(stepperPin_Dir, LOW)

// Initialization Potentiometer IRL Pin_______________
const int Potentio_0  = A0,           // stepper
          Potentio_1  = A2,           // Servo 1
          Potentio_2  = A1,           // Servo 2
          Potentio_3  = A3;           // Servo 3

// Initialization IR Sensor___________________________
const int IRSensorPin  = 8;
#define Box digitalRead(IRSensorPin)

////////////////////////////////////////////////////////////////////////////////////////////

const int StepperADC[41] = {142,156,173,189,206,224,
                                240,257,273,291,308,
                                326,344,362,381,400,
                                420,439,460,481,501,
                                521,541,562,582,602,
                                623,642,661,679,698,
                                716,732,750,769,786,
                                803,821,838,853,868};

const int ServoADC[3][2] = {{616,  61}, {62,617}, { 83, 626}};
const int ServoDeg[3][2] = {{rightAngle[0]-90, rightAngle[0]+90},
                            {0-(rightAngle[1]-90), 180-(rightAngle[1]-90)},
                            {0-rightAngle[2], 180-rightAngle[2]}};

int dataConfig[7];          // 0      Total data
                            // 1,2,3  Box: length, width, height
                            // 4      Palletizing? 1/0 (yes/no)
                            // 5      Selected position to release
                            // 6      Total Layer
                            
int GetAngle[5][10];        // 5 Motor, max.10 (dataConfig[0])
int GetAngles[5][5][5][3];  // 5 Motor, max.5 layer, 5 box/layer, 3 act (dataConfig[5])

////////////////////////////////////////////////////////////////////////////////////////////

void setup() {
  pinMode(IRSensorPin, INPUT);
  pinMode(stepperPin_En, OUTPUT);
  pinMode(stepperPin_Dir, OUTPUT);
  pinMode(stepperPin_Step, OUTPUT);
  
  Motor(0);
  
  Serial.begin(9600);
  
  lcd.begin();
  lcd.backlight();
  lcd.clear();
  lcd.print("i'm Ready");

  //Recording();
}

void loop() {
  if (Serial.available() > 0){
    int byteIn = Serial.read();
    switch(byteIn){
      
      case '1':
        lcd.clear(); lcd.print("Connected"); delay(1000);
        lcd.clear();
      break;

      // Side Record - Clicked
      case '2':
        Recording();
      break;

      // Control Send - Clicked
      case '3':
        Receiving();
      break;

      // Control Play - Clicked
      case '4':
        Acceleration();
        //ShowData();
      break;
      
    }
  }
}

////////////////////////////////////////////////////////////////////////////////////////////


int ADCPosition(int nPot){
  switch(nPot){
    case 0: return analogRead(Potentio_0); // Stepper    // Axis 1
    case 1: return analogRead(Potentio_1); // Servo 1    // Axis 2
    case 2: return analogRead(Potentio_2); // Servo 2    // Axis 3
    case 3: return analogRead(Potentio_3); // Servo 3    // Axis 4
  }
}


void Recording(){
  boolean RecordLoop[2];
  int GetDegree[4],
      GetDegreePrev[4];
  int CursorX[4] = {3, 11, 3, 11};
  int CursorY[4] = {0,  0, 1,  1};
  
  lcd.clear(); lcd.print("Recording"); delay(1000);      
  lcd.clear();
  lcd.setCursor(0,0); lcd.print("A1:     A2:");
  lcd.setCursor(0,1); lcd.print("A3:     A4:");
  
  Motor(0);
  RecordLoop[0] = true;
  while(RecordLoop[0]){  // Looping in Record Panel
    
    // Get Degree of Axis_____________________________________________________________
    int SAC = 0;
    int ADCtmp = ADCPosition(0);
    while(1){
      if (ADCtmp - StepperADC[SAC] < StepperADC[SAC+1] - StepperADC[SAC]){
        GetDegree[0] = map(ADCtmp, StepperADC[SAC], StepperADC[SAC+1], SAC*9-180, (SAC+1)*9-180);
        break;
      }
      SAC++; 
    }

    for (int s = 0; s < 3; s++){
      GetDegree[s+1] = map(ADCPosition(s+1), ServoADC[s][0], ServoADC[s][1], ServoDeg[s][0], ServoDeg[s][1]);
    }
    
    for (int s = 0; s < 4; s++){
      if (GetDegree[s] != GetDegreePrev[s]) {
        lcd.setCursor(CursorX[s],CursorY[s]);
        if (GetDegree[s] >= 0   && GetDegree[s] < 10)  lcd.print(String(GetDegree[s]) + "   "); else
        if (GetDegree[s] >= -9  && GetDegree[s] < 100) lcd.print(String(GetDegree[s]) + "  ");  else
        if (GetDegree[s] >= -99)                       lcd.print(String(GetDegree[s]) + " ");
        else lcd.print(GetDegree[s]);
        GetDegreePrev[s] == GetDegree[s];
      }
    }

    delay(100);
    
    // Case in Side Record:____________________________________________________________
    if (Serial.available() > 0){
      int byteIn = Serial.read();
      switch (byteIn){ // Select case in Side Record:
        
        case '1':  // Record Get Data - Clicked
          RecordLoop[1] = true;
          while(RecordLoop[1]){  // Looping for Sending GetDegree[]
            if (Serial.available() > 0){
              byteIn = Serial.read();
              switch (byteIn){
                case '1': Serial.println(GetDegree[0]); break;  // Send stepper degree
                case '2': Serial.println(GetDegree[1]); break;  // Send servo 1 degree
                case '3': Serial.println(GetDegree[2]); break;  // Send servo 2 degree
                case '4': Serial.println(GetDegree[3]);         // Send servo 3 degree
                          RecordLoop[1] = false;
                          break;
              }
            }
          }
          lcd.clear(); lcd.print("Sent to PC"); delay(1000);
          lcd.clear();
          lcd.setCursor(0,0); lcd.print("A1:     A2:");
          lcd.setCursor(0,1); lcd.print("A3:     A4:");
        break;

        // Get out from Side Record and Recording()
        case '2':  // Side Input - clicked
          lcd.clear(); lcd.print("Side Input");
          RecordLoop[0] = false;
        break;

        case '3':  // Side Control - clicked
          lcd.clear(); lcd.print("Side Control");
          RecordLoop[0] = false;
        break;
        
        case '4':  // Disconnect - clicked
          lcd.clear(); lcd.print("Disconnected..");
          RecordLoop[0] = false;
        break;
      }
    }
    
  }
}


void Receiving(){
  lcd.clear(); lcd.print("Receiving..");
  
  while(1){
    if (Serial.available() > 0){
      for (int s = 0; s < 7; s++) dataConfig[s] = Serial.parseInt();
      break;
    }
  }

  while(1){
    if (Serial.available() > 0){
      for (int s = 0; s < dataConfig[0]; s++)
      for (int a = 0; a < 5; a++) 
        GetAngle[a][s] = Serial.parseInt();
      break;
    }
  }

  while(dataConfig[4]){
    if (Serial.available() > 0){
      for (int s = 0; s < dataConfig[6]; s++)         // Total Layer
      for (int a = 0; a < 5; a++)                     // 5 Box position
      for (int n = 0; n < 3; n++)                     // 3 Action
      for (int d = 0; d < 5; d++)                     // 5 Motor
        GetAngles[d][s][a][n] = Serial.parseInt();    // motor - layer - box - action
      break;
    }
  }

  lcd.clear(); lcd.print("Received!!");
}


void Acceleration(){
  float Ax[4];
  Motor(1);
  lcd.clear(); lcd.print("Acceleration ");
  
  // Palletizing_______________________________________________________________________
  if (dataConfig[4]){                             // [4] Palletizing
    for (int s = 0; s < dataConfig[6]; s++){      // [6] Total layer
      for (int a = 0; a < 5; a++){                //  5  Boxs per layer
        Steps_zero();
        
        for (int n = 0; n < dataConfig[0]; n++){  // [0] Total data
          if (n == dataConfig[5]-1){              // [5] Selected position to release
            for (int d = 0; d < 3; d++){          // 3x Moves to release
              for (int h = 0; h < 4; h++)         // Move 4 Axis sametime
                Ax[h] = GetAngles[h][s][a][d];
              MyAxis(Ax);
              if (GetAngles[4][s][a][d]==2)
                delay(1000);
              Ax_Servo(0,GetAngles[4][s][a][d]);  // Gripper action
              delay(500);
            }
          }
          
          else {                                  // Others position except release
            for (int i = 0; i < 4; i++)           // Move 4 Axis sametime
              Ax[i] = GetAngle[i][n];
            MyAxis(Ax);
            while(GetAngle[4][n]==1){             // waiting for box to grip
              lcd.setCursor(0,1);
              lcd.print("Waiting..");
              if (!Box){                          // IRSensor value = LOW
                delay(3000);
                lcd.setCursor(0,1);
                lcd.print("         ");
                break;
              }
            }
            Ax_Servo(0,GetAngle[4][n]);           // Gripper action
            delay(500);
          }
        }
        
      }
    }
  }

  // non-Palletizing___________________________________________________________________
  else{
    Steps_zero();
    for (int s = 0; s < dataConfig[0]; s++){
      for (int a = 0; a < 4; a++)                 // Move 4 Axis sametime
        Ax[a] = GetAngle[a][s];
      MyAxis(Ax);
      
      if (GetAngle[4][s]==2) delay(1000);
      while(GetAngle[4][s]==1){                   // waiting for box to grip
        lcd.setCursor(0,1);
        lcd.print("Waiting..");
        if (!Box){                                // IRSensor value = LOW
          delay(3000);
          lcd.setCursor(0,1);
          lcd.print("         ");
          break;
        }
      }
      
      Ax_Servo(0,GetAngle[4][s]);                 // Gripper action
      delay(500);
    }
  }

  lcd.setCursor(0,1); lcd.print("Finished");
}


void MyAxis(float Ax[4]){
  long stepper_Steps;
  
  float servo_Space[4];
  float servo_Steps[4][80];
  int   AAxis_Steps = 80;
  int   serv = 0;
  
  //convert angle target to stepper steps
  int stepper_Space = abs(Ax[0] - stepper_LastDegree);
      stepper_Steps = map(stepper_Space, 0, 360, 0, Revolutions); 

  //selecting stepper turn cw / ccw
  if (Ax[0] > stepper_LastDegree) Stepper_turn_CW;
  else                            Stepper_turn_CCW;

  //getting servo steps
  for (int s = 1; s <= 3; s++){
    servo_Space[s] = Ax[s] - servo_LastDegree[s];
    for (int a = 0; a < AAxis_Steps; a++)
      servo_Steps[s][a] = servo_LastDegree[s] + ( servo_Space[s] / AAxis_Steps * (a+1) );
  }

  //Running Stepper and Servo sametime
  int servo_Dist = stepper_Steps/AAxis_Steps;
  if (stepper_Space >= 5){
    for (int s = 0; s < stepper_Steps; s++){
      Steps_run(0);
      if (serv < 80 && s%servo_Dist == 0){
        for (int a = 1; a <= 3; a++) Ax_Servo(a,servo_Steps[a][serv]);
        if (stepper_Space < 45) delay(20); 
        serv++;
      }
    }
  }
  
  else{
    for (int s = 0; s < stepper_Steps; s++) Steps_run(0);
    for (int s = 0; s < AAxis_Steps; s++){
      for (int a = 1; a <= 3; a++)  Ax_Servo(a,servo_Steps[a][s]);
      delay(20);
    }
  }

  //save last degree
  for (int s = 1; s <= 3; s++) servo_LastDegree[s] = Ax[s];
  stepper_LastDegree = Ax[0];
}


void Motor(int status){
  if (status){
    for (int s = 0; s < 3; s++){
      servo_LastDegree[s+1] = map(ADCPosition(s+1), ServoADC[s][0], ServoADC[s][1], ServoDeg[s][0], ServoDeg[s][1]);
      Ax_Servo(s+1, servo_LastDegree[s+1]);
    }
    
    digitalWrite(stepperPin_En, LOW);
    servo_1.attach(servoPin_1);
    servo_2.attach(servoPin_2);
    servo_3.attach(servoPin_3);
    servo_4.attach(servoPin_4);
  }
  else{
    digitalWrite(stepperPin_En, HIGH);
    servo_1.detach();
    servo_2.detach();
    servo_3.detach();
    servo_4.detach();
  }
  
}


void Steps_zero(){
  if (ADCPosition(0) > MiddleBase){
    Stepper_turn_CCW;
    while (ADCPosition(0) >= MiddleBase-10) Steps_run(1);
  }
  else if (ADCPosition(0) < MiddleBase){
    Stepper_turn_CW;
    while (ADCPosition(0) <= MiddleBase+5) Steps_run(1);
  }

  stepper_LastDegree = 0;
}


void Steps_run(int value){
  digitalWrite(stepperPin_Step, HIGH); delayMicroseconds(StepTon+(value*250));
  digitalWrite(stepperPin_Step, LOW);  delayMicroseconds(StepToff+(value*25));
}

void Ax_Servo(int nservo, float value){
  switch (nservo){
    
    case 1:
      servo_1.write(Fmap(value, 0, 180, rightAngle[0]+90, rightAngle[0]-90));
    break;
    
    case 2:
      servo_2.write(Fmap(value, 0, 180, rightAngle[1]-90, rightAngle[1]+90));
    break;
    
    case 3:
      servo_3.write(Fmap(value, -90, 90, rightAngle[2]-90, rightAngle[2]+90));
    break;

    case 0:
      // value: 0 same as previous, 1 hold, 2 release
      int grip = 90;
      if (value == 1 && dataConfig[1] >= 50 && dataConfig[1] <= 80)
        grip = map(dataConfig[1], 50, 80, 10, 90) - 10;
      if (value != 0)
        servo_4.write(grip);
    break;
    
  }
}

float Fmap(float x, float inmin, float inmax, float outmin, float outmax){
  return (x - inmin) * (outmax - outmin) / (inmax - inmin) + outmin;
}
