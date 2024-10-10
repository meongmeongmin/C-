# CSharpProgramming

## 설명

대구가톨릭대학교의 C#프로그래밍 강의에서 실습 및 과제를 업로드하는 공간이다. 실습 코드와 과제 파일을 공유하고 관리한다.

## 구성 요소

- C# 실습 코드
- 과제 파일 및 솔루션
- 강의 관련 참고 자료

## 미리보기

```csharp
using System;
using System.Text;

class HelloWorld
{
    static void Main()
    {
        #region I/O
        // 콘솔의 입출력 인코딩을 UTF-8로 설정
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        using var read = new System.IO.StreamReader(Console.OpenStandardInput());
        using var print = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true };
        #endregion

        print.Write("Hello, world!");
    }
}
```

![image](https://github.com/user-attachments/assets/46f367f6-db31-4ca3-9c98-17e9e43bdf8f)

