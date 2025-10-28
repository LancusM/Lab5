public abstract class Employee
{
	public string FirstName { get; }
	public string LastName { get; }
	public string SSN { get; }
	
	public Employee(string fName, string lName, string ssn)
	{
		FirstName = fName;
		LastName = lName;
		SSN = ssn;
	}
	
	public override string ToString()
	{
		return FirstName + " " + LastName + " SSN: " + SSN + " ";
	}
	
	public abstract decimal Earnings();
}

public class SalaryEmployee : Employee
{
	public decimal WeeklySalary { get; }

	public SalaryEmployee(string fName, string lName, string ssn, decimal weeklySalary)
		: base(fName, lName, ssn)
	{
		WeeklySalary = weeklySalary;
	}

	public override decimal Earnings()
	{
		return WeeklySalary;
	}

	public override string ToString()
	{
		return "Salaried Employee: " + base.ToString() + "Weekly Salary: " + WeeklySalary.ToString("C");
	}
}

public class HourlyEmployee : Employee
{
	public decimal Wages { get; }
    public int Hours { get; }

    public HourlyEmployee(string fName, string lName, string ssn, decimal wages, int hours)
        : base(fName, lName, ssn)
    {
        Wages = wages;
        Hours = hours;
    }
    public override decimal Earnings()
    {
        if (Hours <= 40)
            return Wages * Hours;
        else
            return (40 * Wages) + ((Hours - 40) * Wages * 1.5M);
    }
    public override string ToString()
    {
        return "Hourly Employee: " + base.ToString() + "Wages: " + Wages.ToString("C") + "; Hours: " + Hours;
    }
}
public class CommissionEmployee : Employee
{
    public decimal GrossSales { get; }
    public decimal CommissionRate { get; }
    public CommissionEmployee(string fName, string lName, string ssn, decimal grossSales, decimal commissionRate)
        : base(fName, lName, ssn)
    {
        GrossSales = grossSales;
        CommissionRate = commissionRate;
    }
    public override decimal Earnings()
    {
        return GrossSales * CommissionRate;
    }
    public override string ToString()
    {
        return "Commission Employee: " + base.ToString() + "Gross Sales: " + GrossSales.ToString("C") + "; Commission Rate: " + CommissionRate;
    }
}