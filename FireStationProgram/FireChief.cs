using System;

// 소방서장 클래스
// 소방관이면서 다른                                                                      
public class FireChief : FirefighterBase
{
    public FireChief(string name, Firefighter numberOne)
    {
        this.Name = name;
        this.NumberOne = numberOne;
    }

    // 1순위 소방관
    public Firefighter? NumberOne { get; set; }

    // 불끄기 함수
    public override void ExtinguishFire()
    {
        //Console.WriteLine($"{Name} 소방관이 불을 끄고 있습니다.");
        // 직접 불을 끄는 대신, 1순위 소방관에게 불끄도록 지시한다.
        TellFirefightenToeExtinguishFire(NumberOne);
    }

    public void TellFirefightenToeExtinguishFire(Firefighter colleague)
    {
        colleague.ExtinguishFire();
    }
}
