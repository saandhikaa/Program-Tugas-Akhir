#include <Servo.h>
  Servo servo_1, servo_2, servo_3, servo_4;
  const int servoPin_1 = 10,
            servoPin_2 = 9,
            servoPin_3 = 11,
            servoPin_4 = 12;

  const int rightAngle[3] = {98,63,90};
  
// Initialization Potentiometer IRL Pin_______________
const int Potentio_0  = A0,           // stepper
          Potentio_1  = A2,           // Servo 1
          Potentio_2  = A1,           // Servo 2
          Potentio_3  = A3;           // Servo 3

void setup() {
  //servo_1.attach(servoPin_1);
  //servo_2.attach(servoPin_2);
  servo_3.attach(servoPin_3);
  //servo_4.attach(servoPin_4);
  
  Serial.begin(9600);
  
  Ax_Servo(3,0);
  delay(2000);
  Serial.print("0   ");
  Serial.println(analogRead(Potentio_3));
  delay(2000);
  
  Ax_Servo(3,90);
  delay(2000);
  Serial.print("90  ");
  Serial.println(analogRead(Potentio_3));
  delay(2000);
  
  Ax_Servo(3,-90);
  delay(2000);
  Serial.print("-90 ");
  Serial.println(analogRead(Potentio_3));
  delay(2000);
  
}

void loop() {
  // put your main code here, to run repeatedly:

}

void Getdata1(){          
  int data[3][181];
  int adcvalue;

  for (int s = 0; s < 3; s++){
    Serial.println("\n\nPercobaan " + String(s+1));
    for (int a = 0; a <= 180; a++){
      Ax_Servo(1,a);
      if (a == 0) delay(2000);
      else delay(1000);
      adcvalue = analogRead(Potentio_1);
      Serial.println(String(a) + ", " + String(adcvalue));
      data[s][a] = adcvalue;
    }
  }

  Serial.println("\nSudut, ADC 1, ADC 2, ADC 3");
  for (int s = 0; s <= 180; s++){
    Serial.println(String(s) + ", " + String(data[0][s]) + ", " + String(data[1][s]) + ", " + String(data[2][s]));
  }
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
    
  }
}


float Fmap(float x, float inmin, float inmax, float outmin, float outmax){
  return (x - inmin) * (outmax - outmin) / (inmax - inmin) + outmin;
}
