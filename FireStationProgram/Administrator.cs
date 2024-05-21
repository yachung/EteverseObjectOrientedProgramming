﻿// 관리자 클래스.
class Administrator : INamedPerson
{
    public string Title { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Name
    {
        get
        {
            return $"{Title} {Firstname} {Lastname}";
        }
    }
}