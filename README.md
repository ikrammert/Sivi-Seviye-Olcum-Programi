# Sivi-Seviye-Olcum Programi
 Arduino ile Sıvı Seviyesini Ölçen Program
 Arduino üzerindeki sensörden gelen sıvı seviye bilgisini C# üzerinden progress bar aracılığı ile gösteren program
 Kullanıcı adı:12345 Şifre:12345
Hazırlayanlar:
Cihat SÖZEN
İkram MERT

Arduino Kodu:

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
