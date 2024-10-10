# 띠 알아보기 프로그램 - 연도에 따른 띠 확인 예제

## 문제 설명

사용자가 입력한 연도를 통해 해당 연도의 띠를 찾아 출력하는 C# 프로그램을 작성한다. 이 프로그램은 중국의 12간지를 사용하여 사용자가 입력한 연도의 띠를 이미지로 표시하며, Nakov.TurtleGraphics 대신 GUI 환경에서 연도를 시각적으로 이해하는 데 유용하다.

## 코드 풀이

이 프로그램은 다음과 같은 이유로 작성되었다:

### 주요 코드 설명

- **연도 입력 및 12간지 계산**
  - 사용자가 입력한 연도를 `year % 12` 연산을 통해 해당 연도의 띠를 찾는다. 이 계산은 12개의 띠를 순환하여 해당 연도에 맞는 동물 이미지를 찾도록 한다.

- **띠에 맞는 이미지 표시**
  - 12간지의 띠에 맞는 이미지를 `PictureBox`에 표시한다. 띠의 종류는 원숭이, 닭, 개, 돼지, 쥐, 소, 호랑이, 토끼, 용, 뱀, 말, 양이다. 해당 연도에 따라 각 띠에 맞는 이미지를 로드하여 사용자에게 보여준다.

  ```csharp
  this.Text = "띠 알아보기";
  int year = Convert.ToInt32(zodiacTextBox.Text);
  string imageFile = "C:\\Users\\pr620\\source\\repos\\ZodiacFinder\\Images\\";

  switch (year % 12)
  {
      case 0: imageFile += "원숭이.png"; break;
      case 1: imageFile += "닭.png"; break;
      case 2: imageFile += "개.png"; break;
      case 3: imageFile += "돼지.png"; break;
      case 4: imageFile += "쥐.png"; break;
      case 5: imageFile += "소.png"; break;
      case 6: imageFile += "호랑이.png"; break;
      case 7: imageFile += "토끼.png"; break;
      case 8: imageFile += "용.png"; break;
      case 9: imageFile += "뱀.png"; break;
      case 10: imageFile += "말.png"; break;
      case 11: imageFile += "양.png"; break;
  }

  zodiacPictureBox.Image = Image.FromFile(imageFile);
  zodiacPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
  ```

## 정리

이 프로그램은 사용자가 입력한 연도를 통해 해당 연도의 띠를 찾고, 그에 해당하는 이미지를 표시하는 예제이다. 연도의 나머지 연산을 통해 띠를 계산하고, 이를 통해 사용자가 자신의 띠를 쉽게 이해할 수 있도록 돕는다. GUI 환경에서 이미지와 함께 띠를 표시하여 사용자가 보다 직관적으로 결과를 확인할 수 있게 한다.