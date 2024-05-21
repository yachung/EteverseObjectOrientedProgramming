using System;

// 추상클래스가 되기 위해선 추상 메소드를 적어도 1개 이상은 가져야 함.(ExtinguishFire)
public abstract class FirefighterBase : INamedPerson
{
    //public FirefighterBase(string name)
    //{
    //    this.Name = name;
    //}

    // 필드(Field) 변수/프로퍼티
    public string Name { get; set; }

    // 추상메소드 - 이 클래스를 상속하는 자손 클래스에서 꼭 구현을 재정의 해야하는 메소드.
    public abstract void ExtinguishFire();

    //protected virtual void TurnOnHose()
    //{
    //    Console.WriteLine("불이 완전히 꺼졌습니다.");
    //}

    //protected virtual void TrainHoseOnFire()
    //{
    //    Console.WriteLine("호스를 불에 조준.");
    //}

    // 공개 소방차 운전 메소드 - 인터페이스(interface)
    public void Drive(Firetruck truckToDrive, Point coordinates)
    {
        // 내가 운전할 수 있는 트럭인지 확인
        if (truckToDrive.Driver != this)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{Name} 소방관은 이 트럭의 운전자가 아니여서 운전이 불가능합니다.");
            Console.ForegroundColor = ConsoleColor.White;
            return;
        }

        // 트럭을 전달 받은 좌표로 이동(운전)
        truckToDrive.Drive(coordinates);
    }
}