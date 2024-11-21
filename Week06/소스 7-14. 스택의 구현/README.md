# 자동차 주차 프로그램 - 주차장 관리 예제

## 문제 설명

5개의 공간을 가진 주차장 배열을 이용하여 자동차의 주차와 출차를 관리하는 C# 프로그램을 작성한다.

## 코드 풀이

이 프로그램은 다음과 같은 이유로 작성되었다:

### 주요 코드 설명

- **주차장 배열 생성 및 자동차 주차**
  - `parking`이라는 크기 5의 문자형 배열을 생성하고, `top` 변수를 사용하여 배열의 현재 인덱스를 관리한다. `top`은 주차장에 자동차가 들어오고 나갈 때마다 증가하거나 감소하며, 이를 통해 주차 공간을 관리한다.

  ```csharp
  char[] parking = new char[5];
  int top = 0;

  parking[top] = 'A';
  print.WriteLine($"{parking[top++]} 자동차가 주차장에 들어감");

  parking[top] = 'B';
  print.WriteLine($"{parking[top++]} 자동차가 주차장에 들어감");

  parking[top] = 'C';
  print.WriteLine($"{parking[top++]} 자동차가 주차장에 들어감\n");
  ```

- **자동차 출차**
  - 자동차가 주차장에서 나갈 때는 `top` 변수를 감소시켜 출차된 자동차를 관리하고, 해당 배열의 값을 공백으로 초기화한다. 이를 통해 주차장의 상태를 업데이트한다.

  ```csharp
  print.WriteLine($"{parking[--top]} 자동차가 주차장에 빠져나감");
  parking[top] = ' ';

  print.WriteLine($"{parking[--top]} 자동차가 주차장에 빠져나감");
  parking[top] = ' ';

  print.WriteLine($"{parking[--top]} 자동차가 주차장에 빠져나감");
  parking[top] = ' ';
  ```

## 정리

이 프로그램은 5개의 주차 공간을 가진 배열을 이용하여 자동차의 주차와 출차를 관리하는 예제이다. `top` 변수를 통해 배열의 현재 상태를 관리하고, 배열에 자동차의 정보를 저장하거나 삭제하면서 주차장의 상태를 표현한다.