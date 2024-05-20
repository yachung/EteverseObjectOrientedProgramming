﻿using System;

// 이름, 나이, 학생 정보를 캡슐화하는 Student 클래스
public class Student
{
    // 필드는 private으로
    private string name;
    private int age;

    // 생성자
    public Student(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    // Getter
    public string GetName() { return name; }
    public int GetAge() { return age; }

    // Setter
    public void SetName(string name)
    {
        // 검증
        // 메소드에서 전달받은 name 문자열 값이 빈 문자열이 아닌지 검증
        if (!string.IsNullOrEmpty(name) &&
            !string.IsNullOrWhiteSpace(name))
        {
            this.name = name;
        }
        else
        {
            throw new ArgumentNullException("이름 값은 빈 문자열이면 안됩니다");
        }
    }

    public void SetAge(int age)
    {
        // 검증
        if (age < 0)
        {
            throw new ArgumentException("나이는 양수여야 합니다.");
        }
        else
        {
            this.age = age;
        }
    }

    // 출력 함수
    public void PrintData()
    {
        Console.WriteLine($"이름: {name} | 나이: {age}");
    }
}