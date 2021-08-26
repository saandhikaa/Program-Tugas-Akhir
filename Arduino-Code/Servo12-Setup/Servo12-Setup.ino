#include <Servo.h>
  Servo servo_1, servo_2;
  
  #define servoPin_1  10
  #define servoPin_2  9

#include <Wire.h>
#include <LiquidCrystal_I2C.h>
  LiquidCrystal_I2C lcd = LiquidCrystal_I2C (0x27,16,2);

long DataIn[2];
int TData = 2;

void setup() {
  // put your setup code here, to run once:

  Serial.begin(9600);
  Serial.println("\nSTART ===================");
  
  lcd.init();
  lcd.backlight();
  lcd.clear();
  lcd.print("Ready..");
  
  servo_1.attach(servoPin_1);
  servo_2.attach(servoPin_2);

  Axis(1,80);
  Axis(2,160);
  
} 

void loop() {
  if (Serial.available() > 0){
    for (int s = 0; s < TData; s++)
      DataIn[s] = Serial.parseInt();
    
    if (Serial.available() > 0){
      Serial.print("\nData Received:");
      lcd.clear();
      for (int s = 0; s < TData; s++)
        Serial.print(" " + String(DataIn[s]));

      //Myservo(DataIn[0], DataIn[1]);
      Axis(DataIn[0], DataIn[1]);
      
      lcd.print("Axis " + String(DataIn[0]) + ": " + String(DataIn[1]));
        
    }
  }
  
}

void Axis(int nservo, int value){
  int right_angle;
  switch (nservo){
    
    case 1:
      right_angle = 98;
      Myservo(1,map(value, 0, 180, right_angle+90, right_angle-90));
    break;
    
    case 2:
      right_angle = 63;
      Myservo(2,map(value, 0, 180, right_angle-90, right_angle+90));
    break;
    
  }
  
}

void Myservo(int num, int value){
  if(num == 1) servo_1.write(value);
  if(num == 2) servo_2.write(value);
}
