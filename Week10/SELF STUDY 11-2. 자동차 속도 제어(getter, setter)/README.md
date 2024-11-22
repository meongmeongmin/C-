## 문제 설명

이 프로그램은 `Car` 클래스를 사용하여 자동차의 속도를 증가시키거나 감소시키는 기능을 구현한다. 속도는 속성을 통해 관리되며, 적절한 속도 제한이 적용된다.

![alt text](image.png)

## 코드 풀이

### 주요 클래스 설명

1. **`Car` 클래스**
   - **필드**
     - `_maxSpeed`: 자동차의 최대 속도(200)
     - `_speed`: 현재 속도
   - **속성**
     - `Speed`: 현재 속도를 관리하며, 변경된 값만 반영한다.
   - **메서드**
     - `UpSpeed(int value)`: 속도를 `value`만큼 증가시키되, 최대 속도인 200을 초과하지 않는다.
     - `DownSpeed(int value)`: 속도를 `value`만큼 감소시키되, 최소 속도인 0 미만으로 내려가지 않는다.

   ```csharp
   public void UpSpeed(int value)
   {
       Speed = (_maxSpeed >= (Speed + value)) ? (Speed + value) : 200;
   }

   public void DownSpeed(int value)
   {
       Speed = (0 <= (Speed - value)) ? (Speed - value) : 0;
   }
   ```

2. **`CarSpeedController` 클래스**
   - `Car` 객체를 생성하고 초기 속도를 설정한다.
   - `UpSpeed` 메서드를 호출하여 속도를 증가시키고, 현재 속도를 출력한다.

   ```csharp
   Car car = new Car();
   car.Speed = 0;

   car.UpSpeed(30);
   print.WriteLine($"현재 속도 ==> {car.Speed}");
   ```

## 정리

이 프로그램은 자동차의 속도 조절 기능을 구현하며, 속성과 메서드를 활용하여 속도를 안전하게 관리한다. 객체 지향 프로그래밍의 기본 개념과 속성(Property) 사용 방법을 학습하는 데 유용하다.