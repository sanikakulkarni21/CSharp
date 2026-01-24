using Hr;

SalesManager salesManager = new SalesManager(
empId: 1,
firstName: "Sanika",
lastName: "kulkarni",
basicSalary: 60000,
incentive: 7000,
target: 150000,
bonus: 10000


);

SalesEmployee salesEmployee = new SalesEmployee(
empId: 2,
firstName: "Sejal",
lastName: "kulkarni",
basicSalary: 60000,
incentive: 7000,
target: 150000
);

   





salesManager.Achieved = 160000;

Console.WriteLine(salesManager.ToString());
Console.WriteLine(salesEmployee.ToString());
salesManager.DoWork();
salesEmployee.DoWork();
double totalPay = salesManager.ComputePay();
Console.WriteLine($"Total Pay: {totalPay}");
