
int sivi=A0;
void setup() {

  Serial.begin(9600);
 
}

void loop() {
  // put your main code here, to run repeatedly:
  int deger=analogRead(sivi);
  Serial.println(deger);
  delay(1000);
  

}
