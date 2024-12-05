# GUI 기반 데이터 조회

## 문제 설명

이 프로그램은 SQL Server 데이터베이스와 연동하여 사용자로부터 입력받은 데이터를 삽입하거나 테이블의 모든 데이터를 조회하여 화면에 출력한다. 사용자는 간단한 GUI를 통해 데이터를 관리할 수 있다.

## 코드 풀이

### 주요 구성 요소

1. **데이터베이스 연결**
   - **`SqlConnection`**: 데이터베이스 연결 객체
   - **`SqlCommand`**: SQL 쿼리를 실행하는 객체
   - 연결 문자열(`_connStr`)을 설정하여 데이터베이스와 연결한다.

   ```csharp
   _connStr = "연결 문자열";    // 적절한 연결 문자열을 설정
   _conn = new SqlConnection(_connStr);
   _conn.Open();
   ```

2. **`Form1_Load`**
   - 프로그램 실행 시 데이터베이스 연결을 초기화
   - `ListView` 컨트롤(`resultListView`)의 열(Header)을 설정하여 데이터 조회 결과를 표시할 준비를 한다.

   ```csharp
   resultListView.Columns.Add("아이디", (int)(listWidth * 0.2));
   resultListView.Columns.Add("이름", (int)(listWidth * 0.3));
   resultListView.Columns.Add("이메일", (int)(listWidth * 0.3));
   resultListView.Columns.Add("출생연도", (int)(listWidth * 0.2));
   ```

3. **`insertButton_Click`**
   - 사용자 입력(`idTextBox`, `nameTextBox`, `emailTextBox`, `birthYearTextBox`)을 사용하여 데이터를 삽입
   - SQL `insert` 쿼리를 실행

   ```csharp
   string sql = $"insert into userTable values('{idTextBox.Text}', '{nameTextBox.Text}', '{emailTextBox.Text}', '{birthYearTextBox.Text}')";
   _cmd.CommandText = sql;
   _cmd.ExecuteNonQuery();
   ```

4. **`selectButton_Click`**
   - SQL `select` 쿼리를 실행하여 `userTable`의 모든 데이터를 조회
   - `ListView`에 조회된 데이터를 추가하여 화면에 표시

   ```csharp
   _cmd.CommandText = "select * from userTable";
   SqlDataReader reader = _cmd.ExecuteReader();

   resultListView.Items.Clear();
   while (reader.Read())
   {
       ListViewItem item = new ListViewItem(reader.GetString(0));
       item.SubItems.Add(reader.GetString(1));
       item.SubItems.Add(reader.GetString(2));
       item.SubItems.Add(reader.GetInt32(3).ToString());

       resultListView.Items.Add(item);
   }

   reader.Close();
   ```

5. **`Form1_FormClosed`**
   - 프로그램 종료 시 데이터베이스 연결을 해제

   ```csharp
   _conn.Close();
   MessageBox.Show("DB 연결을 종료합니다~");
   ```

## 실행 예제

![alt text](<스크린샷.png>)
![alt text](<스크린샷2.png>)

1. **데이터 삽입**
   - `idTextBox`: `john`
   - `nameTextBox`: `John Doe`
   - `emailTextBox`: `john@example.com`
   - `birthYearTextBox`: `1990`
   - 입력 버튼 클릭 시 데이터베이스에 저장

2. **데이터 조회**
   - 조회 버튼 클릭 시 `userTable`의 모든 데이터가 `ListView`에 표시

   출력 예제:
   ```
   아이디      이름           이메일              출생연도
   -----------------------------------------------
   john      John Bann    john@naver.com    1990
   kim       Kim Chi      kim@daum.net      1992
   ```

## 주요 코드 구조

- **데이터 삽입**: 사용자 입력을 받아 SQL `INSERT` 쿼리를 실행
- **데이터 조회**: 데이터베이스에서 `SELECT` 쿼리 결과를 `ListView`에 표시
- **연결 관리**: `Form1_Load`에서 연결 초기화, `Form1_FormClosed`에서 연결 해제