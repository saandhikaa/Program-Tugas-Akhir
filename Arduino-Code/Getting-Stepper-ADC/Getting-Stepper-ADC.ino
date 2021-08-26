#include <Wire.h>
#include <LiquidCrystal_I2C.h>
  LiquidCrystal_I2C lcd = LiquidCrystal_I2C (0x27,16,2);

const int dirPin    = 4,
          stepPin   = 3,
          enable    = 2;

const int AnalogPin = A0;

#define Stepper_turn_CCW  digitalWrite(dirPin, HIGH)
#define Stepper_turn_CW   digitalWrite(dirPin, LOW)
#define Stepper_on        digitalWrite(enable, LOW);
#define Stepper_off       digitalWrite(enable, HIGH);

const long revolution = 200*32;

const int Mydelay[2] = {100, 1000};

int last_angle = 0,
    MiddleBase = 502,
    adcvalue;

//////////////////////////////////////////////////////////////////

void setup() {
  lcd.begin();
  lcd.backlight();
  lcd.clear(); lcd.print("i'm Ready");
  
  pinMode(AnalogPin, INPUT);
  pinMode(stepPin,  OUTPUT);
  pinMode(dirPin,   OUTPUT);
  pinMode(enable,   OUTPUT);
  Stepper_off;
  
  delay(5000);
  Serial.begin(9600);
  Serial.println("\nSTART...");
  
  //gotozero();
  last_angle = 180;
  Stepper_on;
  delay(1000);
  
  Getdata2();
  Stepper_off;

}

void loop() {
  //int sa = map(analogRead(AnalogPin),134,870,0,360);
  int sa = analogRead(AnalogPin);
  
  lcd.clear();
  lcd.print(sa);
  delay(500);
}


void Getdata(){
  int data[3][41];

  Serial.println("Ready..." + String(analogRead(AnalogPin)));
  delay(2000);

  for (int s = 0; s < 3; s++){
    Serial.println("\n Percobaan " + String(s+1));
    delay(1000);
    Angle(0);
    delay(1000);
    
    for (int a = 0; a <= 40; a++){
      Angle(a*9);
      //delay(500);
      adcvalue = analogRead(AnalogPin);
      Serial.println(String(a*9) + ", " + String(adcvalue));
      data[s][a] = adcvalue;
      //delay(500);
    }
  }

  Serial.println("\nSudut, ADC 1, ADC 2, ADC 3");
  for (int s = 0; s <= 40; s++){
    Serial.print(String(s*9) + ", ");
    Serial.print(String(data[0][s]) + ", ");
    Serial.print(String(data[1][s]) + ", ");
    Serial.println(data[2][s]);
  }
  
}

void Getdata2(){
  for (int s = 0; s <= 40; s++){
    Angle(s*9);
    delay(1000);
    Stepper_off;
    Serial.print("\n" + String(s*9));
    for (int a = 0; a < 20; a++){
      lcd.clear();
      adcvalue = analogRead(AnalogPin);
      lcd.setCursor(0,0); lcd.print(s*9);
      lcd.setCursor(0,1); lcd.print(adcvalue);
      Serial.print(", " + String(adcvalue));
      delay(500);
    }
    Stepper_on;
    delay(1000);
  }
}


void Angle(int value){
  if (value > last_angle) Stepper_turn_CW;
  else                    Stepper_turn_CCW;

  long steps = map(abs(value-last_angle), 0, 360, 0, revolution);
  for (int s = 0; s < steps; s++)
    Steps_run();

  last_angle = value;
}


void Steps_run(){
  digitalWrite(stepPin, HIGH);  delayMicroseconds(Mydelay[1]);
  digitalWrite(stepPin, LOW);   delayMicroseconds(Mydelay[0]);
}


void gotozero(){
  if (analogRead(AnalogPin) > MiddleBase)
    Stepper_turn_CCW;
  else if (analogRead(AnalogPin) < MiddleBase)
    Stepper_turn_CW;
    
  while(analogRead(AnalogPin) != MiddleBase)
    Steps_run();
  
  last_angle = 180;
}
