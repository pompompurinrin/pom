using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEditor;
using UnityEngine;


// 주석 한 줄
/* 주석 여러 줄
 * 이게 주석 여러 줄이다
 * 접을 수도 있다
 */



public class Study_01 : MonoBehaviour
{

/*
    list 선언
    list<데이터 타입> 리스트 이름 = new list<데이터 타입();
    크기를 지정하고 만들고 싶을 때는
    List<Datatype> name = new List <DataType>(new DataType[size])
    빈거 size짜리 리스트를 만듬
    List도 생성과 동시에 초기화 해서 대입 가능
    List<struib> ssh = new List<string>() {"신성호", "바보"};
    이러먼 ssh 리스트 안에 0번째는 "신성호", 1번째는 "바보"
    ssh[0] = "신성호", ssh[1] = "바보"
    리스트는 다른 리스트를 받아서 대입할 수 있음
    List<string> yyw = new List<string>(ssh);
    yyw = ssh
    리스트에 데이터 추가하는 방법
    Add 함수 이용
    얘는 리스트의 맨 뒤에 추가하는 방법임
    */
    List<string> ssh = new List<string>();
    void Start()
    {
        ssh.Add("신 성 호 우");
        //여기서는 ssh 초기화 후 별도로 값을 안넣어놨어서 size가 0임 (아무것도 없음)
        //그래서 "신 성 호 우"가 ssh[0]에 들어감4
        ssh.Add("신 성 호 이");
        //추가한 "신 성 호 이"는 ssh[1]에 위치

        //insert 함수 이용 방법
        //말 그대로 끼워 넣는 방식임
        //끼워 넣으니까 기존에 있던 애들은 뒤로 밀림
        ssh.Insert(0, "유 용 워 이");
        /* 이러면 ssh는?
        [유용워이, 신성호우, 신성호이]

        배열, 리스트의 크기를 구하는 방법
        배열일 경우
        배열이름.Length;
        리스트일 경우
        리스트이름.Count;
        배열과 리스트의 크기를 구하는 방법이 다름
        방법이 다른데 리스트와 배열의 이름을 비슷하게 지으면?
        배열이름.Count; 이렇게 하려고 해서 에러가 나올 것임

         리스트에서 데이터 삭제하는 방법
        -Remove 함수
        원하는 "값"을 찾아서 지움
        같은 값이 여러개는 맨 처음 값을 지우는데

        같은 ID를 가지는 3마리 중 2번째를 지워야 하는 상황에서는
        -RemoveAt 함수 사용
        얘는 인덱스 정보로 지움
        배열과 동일하게 0부터 시작

        이거 말고도 RemoveAll, Clear 함수가 있음
        근데 안씀
        RemoveAll 사용
        리스트이름.RemoveAll(x => x == "yyw");
        x => x== "yyh"는 람다식이라고 하는데 몰라도 된다
        내용은 x가 yyw인 애를 모두 지운다는 내용

         lua 구구단
        for i = 1,i <= 9 do
        for s = 1, s <= 9 do
        print i * s
        end

        C# 구구단은 중괄호로 묶어줌
        */
        for (int i = 0; i < 9; i++)
        {
            // int i : i가 0부터 시작
            // i < 9 : 9보다 작을 때까지 반복
            // i++ : i를 1씩 증가
            UnityEngine.Debug.Log(i);
        }

        int sum = 0; //합계를 담을 정수형 변수
        int odd = 0;

        for (int i = 2; i < 10; i++)
        {
            for (int j = 1; j < 10; j++)
            {
                int result = i * j;
               
                UnityEngine.Debug.Log(i + "X" + j + "=" + result);
                sum += result;
                
                if(result % 2 ==1)
                    {
                        odd++;
                    }
            }
        }
        /*
        스위치
        얘도 조건에 따른 제어문임 (if랑 비슷)
        근데 얘는 하나의 값을 참조해서 일치하는 경우에만 해당 명령어를 실행하는 방식
        비교, 논리 연산 불가
        정확히 일치하는 값이 있어야 쓸 수 있음

            switch(비교값)
               {
                    case 일치값:
                        실행할 명령어
                    break;
                    default:
                       일치값이 없을 때 실행할 내용
                    break;
               }
        */
        int randValue;
        randValue = Random.Range(0, 9);
        //int 일 때 끝값(9) 포함 안됨
        //float일 때는 포함됨
       // randValue = (int)Random.RandomRange(0f, 9f);
        //
        

    }




}
