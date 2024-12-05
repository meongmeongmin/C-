# 추상 클래스 상속을 활용한 자동차 속도 조절 프로그램

## 문제 설명

이 프로그램은 추상 클래스 `Car`를 기반으로 `Sedan`과 `Truck` 클래스에서 `UpSpeed` 메서드를 각각 구현하여 속도를 조절한다.

![alt text](image-1.png)

## 코드 풀이

### 주요 클래스 설명

1. **`Car` 추상 클래스**
   - **속성**
     - `Speed`: 현재 속도
   - **추상 메서드**
     - `UpSpeed(int value)`: 속도 증가 메서드로, 파생 클래스에서 구현해야 한다.

   ```csharp
   abstract class Car
   {
       public int Speed = 0;

       public abstract void UpSpeed(int value);
   }
   ```

2. **`Sedan` 클래스**
   - `Car` 추상 클래스를 상속받아 `UpSpeed` 메서드를 구현
   - **특징**
     - 최대 속도 제한: 150
     - 속도가 최대치를 초과하지 않도록 제한

   ```csharp
   class Sedan : Car
   {
       int _maxSpeed = 150;

       public override void UpSpeed(int value)
       {
           Speed = (Speed + value) > _maxSpeed ? _maxSpeed : (Speed + value);
           Console.WriteLine($"승용차 속도({value}가속) ==> {Speed}");
       }
   }
   ```

3. **`Truck` 클래스**
   - `Car` 추상 클래스를 상속받아 `UpSpeed` 메서드를 구현
   - **특징**
     - 최대 속도 제한: 130
     - 속도가 최대치를 초과하지 않도록 제한

   ```csharp
   class Truck : Car
   {
       int _maxSpeed = 130;

       public override void UpSpeed(int value)
       {
           Speed = (Speed + value) > _maxSpeed ? _maxSpeed : (Speed + value);
           Console.WriteLine($"트럭 속도({value}가속) ==> {Speed}");
       }
   }
   ```

### 주요 동작 설명

1. **객체 생성 및 초기화**
   - `Sedan`과 `Truck` 객체를 생성
   - 각각의 `UpSpeed` 메서드를 호출하여 속도를 증가

   ```csharp
   Sedan sedan1 = new Sedan();
   Truck truck1 = new Truck();

   sedan1.UpSpeed(150);
   truck1.UpSpeed(300);
   ```

2. **출력**
   - `Sedan`은 최대 속도 150을 초과하지 않도록 제한
   - `Truck`은 최대 속도 130을 초과하지 않도록 제한

   ```plaintext
   승용차 속도(150가속) ==> 150
   트럭 속도(300가속) ==> 130
   ```

![alt text](image.png)

## 정리

이 프로그램은 추상 클래스와 메서드 오버라이딩을 활용하여 공통 동작과 고유 동작을 분리한 설계 방식을 보여준다.