using System.Collections.Generic;

public class FireStation
{
    private List<INamedPerson> clockedInStaff = new List<INamedPerson>();

    // 출근 기록 메소드
    public void ClockIn(INamedPerson staffMember)
    {
        if (!clockedInStaff.Contains(staffMember))
        {
            clockedInStaff.Add(staffMember);
            Console.WriteLine($"{staffMember.Name} 직원이 출근했습니다.");
        }
    }

    // 출근한 직원의 이름을 출력하는 기능 (인터페이스)
    public void RollCall()
    {
        foreach (var staffMember in clockedInStaff)
            Console.WriteLine(staffMember.Name);

        // 현재는 참조 => 참조로 변환하기 때문에 박싱이 일어나지 않지만, 값타입이 들어와서 박싱이 일어날 수도 있기 때문에 좋은 코드가 아님.
        //foreach (object staffMember in clockedInStaff)
        //{
        //    switch (staffMember)
        //    {
        //        case FirefighterBase:
        //            var fireFighter = staffMember as FirefighterBase;
        //            Console.WriteLine(fireFighter?.Name);
        //            break;
        //        case Administrator:
        //            var admin = staffMember as Administrator;
        //            Console.WriteLine(admin?.Name);
        //            break;
        //    }
        //}
    }
}