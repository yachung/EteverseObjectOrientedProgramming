using System;

class Program
{
    static void Main(string[] args)
    {
        // 계좌 객체 생성.
        BankAccount bankAccount = new BankAccount(10000);
        bankAccount.ShowBalance();

        // 학생 객체 생성
        Student yachung = new Student("김윤성", 22);
        yachung.SetAge(28);
        yachung.PrintData();
    }
}