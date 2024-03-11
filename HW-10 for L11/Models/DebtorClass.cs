namespace Lesson11.Models;

public class Debtor
{
	public Debtor(string fullName, DateTime birthDay, string phoneNum, string email, string address, double debt)
	{
		this.FullName = fullName;
		this.BirthDay = birthDay;
		this.Phone = phoneNum;
		this.Email = email;
		this.Address = address;
		this.Debt = debt;
	}


	public string FullName { get; set; }
	public DateTime BirthDay { get; set; }
	public string Phone { get; set; }
	public string Email { get; set; }
	public string Address { get; set; }
	public double Debt { get; set; }

	public override string ToString()
	{
		return $"{this.FullName} | {this.BirthDay.ToShortDateString()} | {this.Phone} | {this.Email} | {this.Address} | Debt : {this.Debt} AZN";
	}

}
