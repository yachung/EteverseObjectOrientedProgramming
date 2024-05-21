class Program
{
    // 프로그램 진입점(Entry Point)
    static void Main(string[] args)
    {
        // 소방관 객체
        Firefighter yachung = new Firefighter { Name = "Yachung" };

        Firefighter james = new Firefighter { Name = "James" };

        // 소방차 객체
        Firetruck truckOne = new Firetruck();
        truckOne.Driver = yachung;

        //운전//
        yachung.Drive(truckOne, new Point(3, 4));

        // 불끄기
        yachung.ExtinguishFire();
        james.ExtinguishFire();

        truckOne.Driver = james;
        yachung.Drive(truckOne, new Point(10, 2));

        // 소방서장 객체 생성
        //FireChief fireChief = new FireChief { Name = "Harry", NumberOne = yachung };
        Firefighter fireChief = new FireChief { Name = "Harry", NumberOne = yachung };
        truckOne.Driver = fireChief;
        fireChief.Drive(truckOne, new Point(20, 30));

        // 소방서장이 다른 소방관에게 불끄라고 지시함
        //fireChief.TellFirefightenToeExtinguishFire(yachung);
        fireChief.ExtinguishFire();

        // Harry 소방서장을 참조해 사용함. Firefighter 타입으로 사용
        // 업캐스팅 - 다형성 활용
        //Firefighter stillHarry = fireChief;
        //Firefighter joe = new Firefighter { Name = "Joe" };
        // 업캐스팅을 한 후에는 부모 클래스가 가진 기능만 사용이 가능하다.
        //stillHarry.TellFirefightenToeExtinguishFire(joe);

        Firefighter bill = new TraineeFirefighter { Name = "bill" };
        bill.ExtinguishFire();
    }
}