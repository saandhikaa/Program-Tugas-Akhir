#include <Servo.h>
  Servo MyServo;
  const int Servo_Pin[4] = {10,9,11};
  const int Potentio[3]  = {A2,A1,A3};

void setup() {
  const int Selected_Servo = 2;       // Start from 0 -> 2.
  
  MyServo.attach(Servo_Pin[Selected_Servo]);

  Serial.begin(9600);
  Serial.println("\n Getting initial data for servo motor");
  
  int data[3][181];
  int adcvalue;
  
  for (int s = 0; s < 3; s++){
    Serial.println("\n\nPercobaan " + String(s+1));
    for (int a = 0; a <= 180; a++){
      MyServo.write(a);
      if (a == 0) delay(2000);
      else delay(1000);
      adcvalue = analogRead(Potentio[Selected_Servo]);
      Serial.println(String(a) + ", " + String(adcvalue));
      data[s][a] = adcvalue;
      delay(100);
    }
  }
  
  Serial.println("\nSudut, Uji 1, Uji 2, Uji 3");
  for (int s = 0; s <= 180; s++){
    Serial.print(String(s) + ", ");
    Serial.print(String(data[0][s]) + ", ");
    Serial.print(String(data[1][s]) + ", ");
    Serial.print(String(data[2][s]) + "\n");
  }
  
}

void loop() {
  // put your main code here, to run repeatedly:

}
