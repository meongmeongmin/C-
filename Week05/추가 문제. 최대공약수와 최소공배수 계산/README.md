# 최대공약수와 최소공배수 계산 프로그램 - 두 수의 연산 예제

## 문제 설명

사용자가 입력한 두 정수의 최대공약수를 이용하여 최소공배수를 계산하고 출력하는 C# 프로그램을 작성한다. 이 프로그램은 유클리드 알고리즘을 활용하여 최대공약수를 구하고, 이를 사용해 최소공배수를 계산하는 연습에 유용하다.

## 코드 풀이

이 프로그램은 다음과 같은 이유로 작성되었다:

### 주요 코드 설명

- **최대공약수(GCD) 계산**
  - 유클리드 알고리즘을 사용하여 두 정수의 최대공약수를 계산한다. 유클리드 알고리즘은 두 수를 나눈 나머지를 반복적으로 구하여 나머지가 0이 될 때의 나누는 수가 최대공약수가 된다.

  ```csharp
  static int Gcd(int num1, int num2)
  {
      int remainder;
      int tmp;

      if (num1 < num2)
      {
          tmp = num1;
          num1 = num2;
          num2 = tmp;
      }

      if (num2 == 0)
          return num1;

      while (true)
      {
          remainder = num1 % num2;
          if (remainder == 0)
              return num2;

          num1 = num2;
          num2 = remainder;
      }
  }
  ```

- **최소공배수(LCM) 계산**
  - 두 수의 최소공배수는 두 수의 곱을 최대공약수로 나눈 값으로 구할 수 있다. 이를 통해 최소공배수를 효율적으로 계산하고 출력한다.

  ```csharp
  int num1 = Convert.ToInt32(read.ReadLine());
  int num2 = Convert.ToInt32(read.ReadLine());

  var result = (num1 * num2) / Gcd(num1, num2);
  print.Write(result);
  ```

## 정리

이 프로그램은 사용자가 입력한 두 정수의 최대공약수를 계산하고, 이를 이용하여 최소공배수를 구하는 예제이다. 유클리드 알고리즘을 사용하여 최대공약수를 구하고, 최소공배수를 효율적으로 계산하는 방법을 연습하는 데 도움이 된다.