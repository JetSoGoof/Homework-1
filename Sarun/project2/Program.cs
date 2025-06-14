﻿// See https://aka.ms/new-console-template for more information
// แสดงเลข 1-100 เฉพาะเลขคี่
var oddNumbers = Enumerable.Range(1, 100).Where(n => n % 2 != 0).ToList();
Console.WriteLine("เลขคี่: " + string.Join(", ", oddNumbers));

// แสดงเลข 1-100 เฉพาะเลขคู่
var evenNumbers = Enumerable.Range(1, 100).Where(n => n % 2 == 0).ToList();
Console.WriteLine("เลขคู่: " + string.Join(", ", evenNumbers));

// แสดงเลข 1-100 เฉพาะเลขจำนวนเฉพาะ
bool IsPrime(int n)
{
    if (n < 2) return false;
    for (int i = 2; i <= Math.Sqrt(n); i++)
        if (n % i == 0) return false;
    return true;
}
var primes = Enumerable.Range(1, 100).Where(IsPrime).ToList();
Console.WriteLine("เลขจำนวนเฉพาะ: " + string.Join(", ", primes));





Console.Write("กรุณากรอกอายุ: ");
if (int.TryParse(Console.ReadLine(), out int age))
{
    if (age >= 1 && age <= 12)
        Console.WriteLine("เด็ก");
    else if (age >= 13 && age <= 19)
        Console.WriteLine("วัยรุ่น");
    else if (age >= 20 && age <= 50)
        Console.WriteLine("วัยผู้ใหญ่");
    else if (age >= 51)
        Console.WriteLine("วัยชรา");
    else
        Console.WriteLine("กรุณากรอกอายุที่ถูกต้อง");
}
else
{
    Console.WriteLine("กรุณากรอกตัวเลขที่ถูกต้อง");
}