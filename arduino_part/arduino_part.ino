bool led;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  led = false;
  pinMode(13,OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  Serial.println("test");
  digitalWrite(13,led);
  led = !led;
  delay(500);
}
