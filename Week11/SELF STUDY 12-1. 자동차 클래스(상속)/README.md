# 자동차 클래스 상속 예제 프로그램

## 문제 설명

이 프로그램은 `Car` 클래스를 기반으로 한 `Sedan`, `Truck`, `Electric` 세 가지 파생 클래스를 정의하고, 각 클래스의 속성과 메서드를 활용하여 자동차의 특성을 출력한다.

![alt text](image.png)

## 코드 풀이

### 주요 클래스 설명

1. **`Car` 클래스**
   - 기본 속성과 메서드:
     - `Color`: 자동차 색상
     - `Speed`: 현재 속도
     - `UpSpeed(int value)`: 속도를 입력값만큼 증가
     - `DownSpeed(int value)`: 속도를 입력값만큼 감소

   ```csharp
   class Car
   {
       public Color Color;
       public int Speed;

       public void UpSpeed(int value)
       {
           Speed += value;
       }

       public void DownSpeed(int value)
       {
           Speed -= value;
       }
   }
   ```

2. **`Sedan` 클래스**
   - `Car` 클래스를 상속받아 `SeatNum`(좌석 수) 속성을 추가하였다.

   ```csharp
   class Sedan : Car
   {
       public int SeatNum { get; set; }
   }
   ```

3. **`Truck` 클래스**
   - `Car` 클래스를 상속받아 `Capacity`(적재량) 속성을 추가하였다.

   ```csharp
   class Truck : Car
   {
       public int Capacity { get; set; }
   }
   ```

4. **`Electric` 클래스**
   - `Car` 클래스를 상속받아 `Mileage`(주행거리) 속성과 `GetMileage` 메서드를 추가하였다.

   ```csharp
   class Electric : Car
   {
       public int Mileage { get; set; }

       public int GetMileage()
       {
           return Mileage;
       }
   }
   ```

### 주요 동작 설명

1. **객체 생성 및 초기화**
   - `Sedan`, `Truck`, `Electric` 객체를 생성하여 속도, 좌석 수, 적재량, 주행거리를 설정

   ```csharp
   Sedan sedan1 = new Sedan();
   Truck truck1 = new Truck();
   Electric electric = new Electric();

   sedan1.UpSpeed(150);
   sedan1.SeatNum = 5;

   truck1.UpSpeed(100);
   truck1.Capacity = 50;

   electric.UpSpeed(200);
   electric.Mileage = 500;
   ```

2. **출력**
   - 각 객체의 속성과 속도를 출력하여 결과 확인

   ```csharp
   print.WriteLine($"승용차 속도는 {sedan1.Speed}km, 좌석수는 {sedan1.SeatNum}개 입니다 ");
   print.WriteLine($"트럭 속도는 {truck1.Speed}km, 적재량은 {truck1.Capacity}톤 입니다 ");
   print.Write($"전기차 속도는 {electric.Speed}km, 주행거리는 {electric.GetMileage()}km 입니다 ");
   ```

### 실행 예제

![alt text](image-1.png)

## 정리

이 프로그램은 상속을 활용하여 기본 클래스에서 공통 기능을 정의하고, 파생 클래스에서 특화된 속성과 메서드를 추가하는 방식을 보여준다.